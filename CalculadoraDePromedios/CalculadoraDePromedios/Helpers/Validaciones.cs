namespace CalculadoraDePromedios.Helpers
{
    public static class Validaciones
    {
        
        public static bool ValidarCalificacion(float calificacion)
        {
            if (calificacion >= 1.0f && calificacion <= 7.0f)
            {
                return true; // Es válida
            }
            return false; // No es válida
        }

        
        public static bool SumaPonderacionEsCien(int p1, int p2, int p3, int p4)
        {
            if ((p1 + p2 + p3 + p4) == 100)
            {
                return true; // Es correcta
            }
            return false; // Es incorrecta
        }
    }
}