using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [StringLength (60)]
        public string Nombre { get; set; }

        [DataType(DataType.EmailAddress), StringLength(30)]
        public string Email { get; set; }

        [Required]
        public string NivelUsuario { get; set; }

        [Required]
        public String Username { get; set; }

        [Required]
        public string Clave { get; set; }

        [DataType(DataType.Date) ,DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime FechaIngreso { get; set; }



        public Usuario()
        {
            UsuarioId = 0;
            Nombre = String.Empty;
            Email = String.Empty;
            Clave = String.Empty;
            NivelUsuario = String.Empty;
            Username = String.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
