using System.Net.Mail;
using Clean.Architecture.SharedKernel.Interfaces;
using Microsoft.Extensions.Logging;

namespace Clean.Architecture.Infra.Services;

public class OnlyLogEmailSender : IEmailSender
{
  private readonly ILogger<OnlyLogEmailSender> _logger;

  public OnlyLogEmailSender(ILogger<OnlyLogEmailSender> logger)
  {
    _logger = logger;
  }

  public Task SendEmailAsync(string to, string from, string subject, string body)
  {
    _logger.LogWarning($"Sending email to {to} from {from} with subject {subject}.");
    return Task.CompletedTask;
  }
}
