using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Rend
    {
        public string Nome { get; set; }
        public string Email { get; set; }



        public Rend(string nome, string email) {
        
        Nome = nome;
        Email = email;
        }


        public override string ToString()
        {
            return  Nome + ", " + Email;

        }
    }
}
