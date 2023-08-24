[TestCase(1)]
public class ReceiveAndVerifyEmail
{
    [TestStep(1)]
    public void Step1(ITester t)
    {
        // trigger email to configured address before or shortly after calling next line
        var activationLink = ReceiveEmails.GetActivationLinkFromEmail(t);

        t.Report.PassFailStep(!string.IsNullOrEmpty(activationLink),
            $"Activation link received by email: {activationLink}",
            $"No email with activation link received within 10 minutes.");
    }
}
