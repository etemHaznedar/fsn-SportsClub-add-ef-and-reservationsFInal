using System.Net.Mail;
using SportsClub.API.Repositories.Contracts;
using SportsClub.SharedModels;

namespace SportsClub.API.Repositories;

public class EmailService : IEmailService
{
    public async Task SendEmailAsync(MailData mailData)
    {
        using (var smtpClient = new SmtpClient("192.168.50.16", 1025)) //Local Smtp server 
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress("SportClubApp@Avans.nl"),
                Subject = mailData.Subject,
                Body = mailData.Body
            };
            
            foreach(string email in mailData.To){
                mailMessage.To.Add(email);
            }

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}