namespace CalculadoraDePromedios.Models
{
    // La sintaxis ": Registro" significa que esta clase HEREDA de la clase Registro
    public class RegistroReprobatorio : Registro
    {
        // Esta clase tiene todas las propiedades de Registro, y además...
        public float CalificacionEstimadaDeAprobacion { get; set; }
    }
}