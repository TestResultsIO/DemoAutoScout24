using TRIO.AddOn.OTP;
using System.Drawing;

[TestCase(1)]
public class _2FA : TestCase
{
    [TestStep(1, 
        TestInput = "Activate 2FA with a QR code displayed on the Screen.", 
        ExpectedResults ="2FA can be activated.")
    ]
    public void Step1(ITester t)
    {
        //make sure to add the NuGet Package "TestResults.AddOn.OTP" to this testcase project
        //in your application navigate to the screen where you enable 2FA
        //make sure the QR code is visible on the screen
        //for testing you can also use an online qr code - for example https://stefansundin.github.io/2fa-qr/

        var code = OtpReader.GetOtpCode(t.Connections.Active.CurrentScreenAsImage, out string otpAuthUri); //reads the QR code from the screen and returns the code
        t.Report.PassStep($"Received code for 2FA: \"{code}\" and URI: \"{otpAuthUri}\"");

        //enter the code in your Application to activate 2FA
        //WARNING: if you activate 2FA, make sure you save the otpAuthUri string or you will later be locked out of your account

        //if the code is rejected, it is most likely already expired. Call "OtpReader.GetOtpCode(_otpAuthUri)" to get a new code
        //if you logout and login again you can also request a new code like this
        var newCode = OtpReader.GetOtpCode(otpAuthUri);
    }
}
