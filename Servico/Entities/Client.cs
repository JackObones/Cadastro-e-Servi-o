using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Entities
{
    class Client
    {
        public string ClientName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string clientname, string email, DateTime birthdate)
        {
            ClientName = clientname;
            Email = email;
            BirthDate = birthdate;
        }

        public override string ToString()
        {
            return ClientName
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}

