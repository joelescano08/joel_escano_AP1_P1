using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace joel_escano_AP1_P1.Models;

public class Cervezas
{
    [Key]
    public int IdCerveza { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Nombre { get; set; } = string.Empty;


    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Marca { get; set; } = string.Empty;

    [Required(ErrorMessage ="Este campo es obligatorio")]
    [Range(1,int.MaxValue, ErrorMessage ="El valor introducido tiene que ser mayor a 0")]
    public int Puntuacion { get;set;  }
}
