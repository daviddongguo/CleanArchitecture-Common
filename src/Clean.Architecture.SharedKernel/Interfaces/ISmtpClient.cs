using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.SharedKernel.Interfaces;
public interface ISmtpClient
{
  Task SendMailAsync(MailMessage message);
}
