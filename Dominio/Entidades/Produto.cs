using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    [Table("Produtos")]
    public class Produto
    {
        [Column("id_produto")]
        public int Id { get; set; }

        [Column("nm_produto")]
        public required string nome { get; set; }

        [Column("nu_valor")]
        public Decimal valor { get; set; }
    }
}
