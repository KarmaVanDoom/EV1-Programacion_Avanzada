using System; 

namespace CalculadoraDePromedios.Helpers
{
    public static class Calculos
    {
        
        private static float CalcularPromedioPonderado(float c1, int p1, float c2, int p2, float c3, int p3, float c4, int p4)
        {
            // La "f" es importante para decirle a C# que son números de tipo float
            float promedio = (c1 * p1 / 100f) + (c2 * p2 / 100f) + (c3 * p3 / 100f) + (c4 * p4 / 100f);
            return promedio;
        }

       
        public static float CalcularPromedioFinal(float c1, int p1, float c2, int p2, float c3, int p3, float c4, int p4, float notaExamen)
        {
            float promedioPonderado = CalcularPromedioPonderado(c1, p1, c2, p2, c3, p3, c4, p4);
            float promedioFinal = (promedioPonderado * 0.7f) + (notaExamen * 0.3f);

            // Redondeamos el resultado a 1 decimal
            return (float)Math.Round(promedioFinal, 1);
        }


        public static float CalcularNotaExamenNecesaria(float c1, int p1, float c2, int p2, float c3, int p3, float c4, int p4)
        {
            float promedioPonderado = CalcularPromedioPonderado(c1, p1, c2, p2, c3, p3, c4, p4);

            
        
            float notaNecesaria = (4.0f - (promedioPonderado * 0.7f)) / 0.3f;

            return (float)Math.Round(notaNecesaria, 1);
        }
    }
}