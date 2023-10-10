using Satbayev.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.BLL
{
    public class ServiceClass
    {
        
        public string Path{ get; set; }
        public ServiceClass(string Path) {
            this.Path = Path;

        }
        public void Registration(Client client)
        {
            
            RepositoryClient reposity = new RepositoryClient(Path);
            bool result = reposity.CreateClient(client);
            
        }

        public Client Auth(string login,string password)
        {
            RepositoryClient repository = new RepositoryClient(Path);
            Client client = repository.GetClient(login, password);
            return client;

        }

    }
   
}
