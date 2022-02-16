using System.Collections.Generic;
using Domain.Entities;
using Domain.Services.Interface;

namespace Domain.Services.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IDataService _dataService;

        public AccountService(IDataService dataService)
        {
            _dataService = dataService;
        }
        public void SendMail(string lastName)
        {
            IEnumerable<Account> accounts = _dataService.GetAccountsWithLastName(lastName);

            foreach (Account account in accounts)
            {
                Send(account);
            }
        }

        private void Send(Account account)
        {
            //send mail business logic
        }
    }
}