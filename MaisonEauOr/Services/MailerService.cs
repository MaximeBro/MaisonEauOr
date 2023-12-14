using System.Net;
using System.Net.Mail;

namespace MaisonEauOr.Services;

public class MailerService
{
	private readonly SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", 587);
	private const string DefaultMailer = "maximebrochard.pro@gmail.com";
	private const string DefaultPassword = "rpoc umgi leaw hbkg";

	public MailerService()
	{
		_smtpClient.Credentials = new NetworkCredential(DefaultMailer, DefaultPassword);
		_smtpClient.EnableSsl = true;
	}
	
	/// <summary>
	/// Sends asynchronously a mail with the given information. Can be canceled with the given token.
	/// </summary>
	/// <param name="recipient">Recipient</param>
	/// <param name="subject">Subject of the mail</param>
	/// <param name="content">The content as a string, it doesn't support HTML body</param>
	/// <param name="token">A cancellation token - optional</param>
	/// <returns>True if the mail was successfully delivered. False if the token has been canceled.</returns>
	public async Task<bool> SendEmailAsync(string recipient, string subject, string content, CancellationTokenSource? token = default)
	{
		var mail = new MailMessage { From = new MailAddress(DefaultMailer), Subject = subject, Body = content }; 
		if (token is null)
		{
			await SendEmailAsync(mail, recipient);
			return true;
		}

		while (!token.IsCancellationRequested)
		{
			await SendEmailAsync(mail, recipient);
			return true;
		}

		return false;
	}

	private async Task SendEmailAsync(MailMessage mail, string dest)
	{
		mail.To.Add(new MailAddress(dest));
		await _smtpClient.SendMailAsync(mail);
	}
}