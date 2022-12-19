using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pedido.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthdayDate { get; set; }
        public Client()
        {
        }
        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            BirthdayDate = date;
        }

        public override string ToString()
        {
            return $"{Name} {BirthdayDate} - {Email}";
        }
    }
}
