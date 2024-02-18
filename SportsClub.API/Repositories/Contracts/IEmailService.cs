using SportsClub.SharedModels;

namespace SportsClub.API.Repositories.Contracts;

public interface IEmailService
{
    Task SendEmailAsync(MailData mailData);

}