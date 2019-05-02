using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using Parcial3._1.Clases.Items;


namespace Parcial3._1
{
    public class Cat: Interface
    {
        string Name;
        string sonido;
        public Cat(string Name, string sonido)
        {
            this.Name = Name;
            this.sonido = sonido;


        }
        public string Talk()
        {

            string habla = "miau";
            return habla;
        }

    }
}
