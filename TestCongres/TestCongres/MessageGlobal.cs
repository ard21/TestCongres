using System;
using System.Collections.Generic;
using System.Text;

namespace TestCongres
{
    public class MessageGlobal
    {
        public string DeQui { get; set; }
        public string Sujet { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return DeQui;
        }

    }
}
