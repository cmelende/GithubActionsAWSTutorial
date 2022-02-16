using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Services.Interface
{
    public interface IDataService
    {
        public IEnumerable<Account> GetAllAccounts();
        public IEnumerable<Account> GetAccountsWithLastName(string lastName);
    }
}