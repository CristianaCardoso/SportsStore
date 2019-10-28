using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Product
    {
        //chave primaria nome da tabela Product mais ID
        public int ProductId { get; set; }


        //nome obrigatorio
        [Required]
        public string Name { get; set; }

        public string Descriptiom{get; set;}

        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}
