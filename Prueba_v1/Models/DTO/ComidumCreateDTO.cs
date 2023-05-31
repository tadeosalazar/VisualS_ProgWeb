using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Prueba_v1.Models.DTO
{
    public class ComidumCreateDTO : Controller
    {
        [Key]
        [Column("id_comida")]
        public int IdComida { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        [Unicode(false)]
        public string Nombre { get; set; } = null!;
        [Column("descripcion")]
        [StringLength(300)]
        [Unicode(false)]
        public string Descripcion { get; set; } = null!;
        [Column("precio", TypeName = "numeric(18, 0)")]
        public decimal Precio { get; set; }
        [Column("id_categoria")]
        public int IdCategoria { get; set; }

       
        public SelectList? Categorium { get; set; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
