﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductIBID
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Produto()
        {
            Nome = "";
        }
    }
}
