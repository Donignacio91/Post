using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPost.Models
{
    [Table("Articulos")]
    public class Camiseta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IdProducto")]
        public int IdProducto { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("Descripcion")]
        public string Descripcion { get; set; }
        [Column("Imagen")]
        public string Imagen { get; set; }
        [Column("Precio")]
        public int Precio { get; set; }

    }
}
