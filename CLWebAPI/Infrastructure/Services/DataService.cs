using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Services.Interface;

namespace Infrastructure.Services
{
    
    public class DataService : IDataService
    {
        private IList<Account> _accountStore = new List<Account>
        {
            new()
            {
                Id = 1,
                FirstName = "Cory",
                MiddleName = "Christian",
                LastName = "Melendez"
            }
        };
        
        public IEnumerable<Account> GetAllAccounts()
        {
            return _accountStore;
        }

        public IEnumerable<Account> GetAccountsWithLastName(string lastName)
        {
            return _accountStore.Where(x => x.LastName == lastName);
        }
    }
}