using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCongres
{

    public class ConferencierMasterMenuItem
    {
        public ConferencierMasterMenuItem()
        {
            TargetType = typeof(ConferencierMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}