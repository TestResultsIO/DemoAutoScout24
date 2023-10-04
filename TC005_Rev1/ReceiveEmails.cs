using Progile.TRIO.EmailHelper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

// If emails should be received and verified in multiple testcases, this class should be moved to the sw model
public static class ReceiveEmails
{
    static readonly string EmailUserName = "triotestuser"; // configure with your email account (without domain)
    static readonly string EmailProvider = "outlook.com"; // currently supported: outlook.com, gmx.net, Gmail.com (prone for blocking on automated execution).
    static readonly string Password = "my password for pop3";

    public const string SenderAddress = ""; // "no-reply@mycompany.com"; 

    /// <summary>
    /// Waits for new emails and filters according to provided information. Searches for a URL in all matching messages and returns it. 
    /// </summary>
    /// <param name="t">Access to the ITester Interface for logging</param>
    /// <param name="emailTag">The email tag that is added to the username to form the email address. E.g. username+emailTag@example.com</param>
    /// <param name="subject">The expected subject to filter for</param>
    /// <param name="timeStamp">The earliest time (in the past) for which received emails are considered</param>
    /// <returns></returns>
    public static string GetActivationLinkFromEmail(ITester t, string emailTag = null, string subject = null, DateTime timeStamp = default)
    {
        var matchingMsgs = GetMessages(t, emailTag, subject, timeStamp);
        string activationLink = string.Empty;

        if (matchingMsgs.Count == 0)
        {
            throw new TestStepAbortedException("Too many emails received");
        }

        foreach (var message in matchingMsgs)
        {
            // adjust according to your needs.
            var pattern = new Regex(@"http\S*");
            activationLink = pattern.Match(message).Value;
            break;
        }

        return activationLink;
    }

    /// <summary>
    /// Waits for new emails and filters according to provided information. Returns all received message bodies as a list of strings.
    /// </summary>
    /// <param name="t">Access to the ITester Interface for logging</param>
    /// <param name="emailTag">The email tag that is added to the username to form the email address. E.g. username+emailTag@example.com</param>
    /// <param name="subject">The expected subject to filter for</param>
    /// <param name="timeStamp">The earliest time for which received emails are considered</param>
    /// <returns></returns>
    public static List<string> GetMessages(ITester t, string emailTag = null, string subject = null, DateTime timeStamp = default)
    {         
        // ignore emails, received more than a minute ago.
        var earliestReceiveTime = timeStamp != default ? timeStamp : DateTime.Now - TimeSpan.FromMinutes(1);
        string receiverAddress;
        if (string.IsNullOrEmpty(emailTag))
            receiverAddress = $"{EmailUserName}@{EmailProvider}";
        else
            receiverAddress = $"{EmailUserName}+{emailTag}@{EmailProvider}";

        var mailHandler = new Pop3MailHandler(receiverAddress, Password);

        t.Log("Start getting emails.");
        // if more data than just the Body is required use "ReceiveEmail"
        // leave sender and subject null or empty if you don't want to filter for it.
        var filteredEmails = mailHandler.ReceiveEmailAsDecodedHtmlBody(earliestReceiveTime, SenderAddress, subject, timeOutInMins: 10);
        t.Log("Finish getting emails.");
        return filteredEmails;
    }
}
