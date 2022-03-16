using System.Net.Mail;

namespace Clean.Architecture.SharedKernel.Interfaces;
public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}

