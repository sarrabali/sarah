using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.sarah
{
    internal class Hotel
    {
        //écrire les propriétés
        public List<Client> Clients { get; set; }

        //écrire le constructeur
        public Hotel()
        {
            Clients = new List<Client>();
        }


        //écrire la méthode pour ajouter un client
        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
    }
}
