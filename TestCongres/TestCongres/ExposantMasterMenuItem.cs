﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCongres
{

    public class ExposantMasterMenuItem
    {
        public ExposantMasterMenuItem()
        {
            TargetType = typeof(ExposantMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public Type TargetType { get; set; }
    }
}