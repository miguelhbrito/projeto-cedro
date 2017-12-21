using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using projetoWebApi.Models;

namespace projetoWebApi.Models
{
    public class Prato
    {
        [Key]
        public int IdPrato { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Preco { get; set; }

        //Relação N - 1 com Restaurante
        [ForeignKey("RestauranteId")]
        public virtual Restaurante Restaurante { get; set; }
    }
}
