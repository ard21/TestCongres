using System;
using System.Collections.Generic;
using System.Text;

namespace TestCongres
{
    public class Fichier
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
