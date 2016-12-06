using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject.logic
{
    class ClientModel
    {
        private List<Client> mClientList;
        public List<Client> ClientList
        {
            get
            {
                return mClientList;
            }
        set{ }
        }

        public ClientModel() { }

        public ClientModel(List<Client> clientList)
        {
            ClientList = clientList;
        }
    }
}
