using System.Net;
using Twilio;


public static HttpResponseMessage Run(Message req, TraceWriter log) 
{
    var twilio = new TwilioRestClient(GetEnvironmentVariable("TwillioAccountSid"), GetEnvironmentVariable("TwillioAuthToken"));
    var msg = twilio.SendMessage(GetEnvironmentVariable("TwillioFromNumber"), req.PhoneNumber, req.Text);

    return new HttpResponseMessage(HttpStatusCode.OK);
}

public static string GetEnvironmentVariable(string name)
{
    return System.Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Process);
}

public class Message
{
    public string PhoneNumber { get; set; }
    public string Text { get; set; }
}