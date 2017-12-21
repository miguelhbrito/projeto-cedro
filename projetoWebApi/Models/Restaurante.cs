using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetoWebApi.Models
{
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        //Relação 1 - N com Prato
        public List<Prato> Pratos{ get; set; }
    }
}
