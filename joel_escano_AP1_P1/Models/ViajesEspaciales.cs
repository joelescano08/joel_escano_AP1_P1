using System.ComponentModel.DataAnnotations;

namespace joel_escano_AP1_P1.Models
{
    public class ViajesEspaciales
    {
        [Key]
        public int ViajeId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime Fecha { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Descripcion { get; set; }



        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Cantidad { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        public float Costo { get; set; }

    }
}
