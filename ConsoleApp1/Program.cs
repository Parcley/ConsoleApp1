using MimeKit;

MailKit.Net.Smtp.SmtpClient client = new()
{
    ServerCertificateValidationCallback = (_, _, _, _) => true // accept any certificate
};

MimeMessage message = new();

await client.ConnectAsync("host.example.com", 587, true);
_ = await client.SendAsync(message);
await client.DisconnectAsync(true);
