using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCCGWT.Models
{
    public class Produto
    {
        public int IdProd { get; set; }

        public string NomeProd { get; set; }

        public string DescProd { get; set; }

        public string PrecoProd { get; set; }

        public string CategoriaProd { get; set; }

        public string StatusProd { get; set; }
    }
}