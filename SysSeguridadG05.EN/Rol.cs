using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysSeguridadG05.EN
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nombre es obligatorio")]
        [StringLength(20, ErrorMessage ="Maximo 20 caracteres")]
        public string Nombre { get; set; }
        public List<Usuario> Usuarios { get; set; }
        [NotMapped]
        public int Top_Aux { get; set; }

    }
}
