using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using Parcial3._1.Clases.Items;

namespace Parcial3._1.Clases
{
    public class Dog : Interface
    {
        string Name;

        public Dog(string name)
        {
            this.Name = name;

        }
        public string Talk()
        {
            string habla = "guau";
            return habla;
        }


    }
}
