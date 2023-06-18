using EmailPlatform.Core.Entities;

namespace EmailPlatform.Core.Interfaces
{
    public interface IMailRepository
    {
        Task<IEnumerable<Mail>> GetMails();

        Task<Mail> GetMail(int id);

        Task<Mail> UpdateMail(Mail mail);

        Task DeleteMail(int id);
    }
}
