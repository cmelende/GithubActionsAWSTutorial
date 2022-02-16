using Domain.Entities;

namespace Domain.Services.Interface
{
    public interface IAccountService
    {
        void SendMail(string lastName);
    }
}