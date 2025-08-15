namespace CalculadoraDePromedios.Models
{
    public class Registro
    {
        // Propiedades para los datos del formulario
        public string NombreAlumno { get; set; }
        public string NombreRamo { get; set; }
        public float Calificacion1 { get; set; }
        public float Calificacion2 { get; set; }
        public float Calificacion3 { get; set; }
        public float Calificacion4 { get; set; }
        public int Ponderacion1 { get; set; }
        public int Ponderacion2 { get; set; }
        public int Ponderacion3 { get; set; }
        public int Ponderacion4 { get; set; }
        public float NotaExamen { get; set; }

        // Propiedad para el resultado del cálculo
        public float PromedioFinal { get; set; }
    }
}