using CalculadoraDePromedios.Helpers;
using CalculadoraDePromedios.Models;
using System;
using System.Windows.Forms;

namespace CalculadoraDePromedios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularNecesaria_Click(object sender, EventArgs e)
        {
            try
            {
                float c1 = float.Parse(txtNota1.Text);
                float c2 = float.Parse(txtNota2.Text);
                float c3 = float.Parse(txtNota3.Text);
                float c4 = float.Parse(txtNota4.Text);
                int p1 = int.Parse(txtPond1.Text);
                int p2 = int.Parse(txtPond2.Text);
                int p3 = int.Parse(txtPond3.Text);
                int p4 = int.Parse(txtPond4.Text);

                if (!Validaciones.SumaPonderacionEsCien(p1, p2, p3, p4))
                {
                    MessageBox.Show("La suma de las ponderaciones debe ser 100%.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float notaNecesaria = Calculos.CalcularNotaExamenNecesaria(c1, p1, c2, p2, c3, p3, c4, p4);

                if (notaNecesaria > 7.0f)
                {
                    MessageBox.Show($"La nota necesaria en el examen es {notaNecesaria}. ¡Es imposible aprobar!", "Estimación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (notaNecesaria < 1.0f)
                {
                    MessageBox.Show("¡Felicidades! Con un 1.0 en el examen ya apruebas el ramo.", "Estimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Para aprobar el ramo con un 4.0, se necesita un {notaNecesaria} en el examen.", "Estimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrese de que todos los campos de notas y ponderaciones contengan números válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text) || string.IsNullOrWhiteSpace(txtNombreRamo.Text))
                {
                    MessageBox.Show("El nombre del alumno y del ramo son requeridos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float c1 = float.Parse(txtNota1.Text);
                float c2 = float.Parse(txtNota2.Text);
                float c3 = float.Parse(txtNota3.Text);
                float c4 = float.Parse(txtNota4.Text);
                int p1 = int.Parse(txtPond1.Text);
                int p2 = int.Parse(txtPond2.Text);
                int p3 = int.Parse(txtPond3.Text);
                int p4 = int.Parse(txtPond4.Text);
                float notaExamen = float.Parse(txtNotaExamen.Text);

                if (!Validaciones.SumaPonderacionEsCien(p1, p2, p3, p4))
                {
                    MessageBox.Show("La suma de las ponderaciones debe ser 100%.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validaciones.ValidarCalificacion(c1) || !Validaciones.ValidarCalificacion(c2) || !Validaciones.ValidarCalificacion(c3) || !Validaciones.ValidarCalificacion(c4) || !Validaciones.ValidarCalificacion(notaExamen))
                {
                    MessageBox.Show("Todas las calificaciones deben estar entre 1.0 y 7.0.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float promedioFinal = Calculos.CalcularPromedioFinal(c1, p1, c2, p2, c3, p3, c4, p4, notaExamen);

                if (promedioFinal >= 4.0f)
                {
                    Registro registroAprobado = new Registro
                    {
                        NombreAlumno = txtNombreAlumno.Text,
                        NombreRamo = txtNombreRamo.Text,
                        Calificacion1 = c1,
                        Ponderacion1 = p1,
                        Calificacion2 = c2,
                        Ponderacion2 = p2,
                        Calificacion3 = c3,
                        Ponderacion3 = p3,
                        Calificacion4 = c4,
                        Ponderacion4 = p4,
                        NotaExamen = notaExamen,
                        PromedioFinal = promedioFinal
                    };
                    dgvAprobados.Rows.Add(
                        registroAprobado.NombreAlumno, registroAprobado.NombreRamo,
                        registroAprobado.Calificacion1, registroAprobado.Ponderacion1,
                        registroAprobado.Calificacion2, registroAprobado.Ponderacion2,
                        registroAprobado.Calificacion3, registroAprobado.Ponderacion3,
                        registroAprobado.Calificacion4, registroAprobado.Ponderacion4,
                        registroAprobado.NotaExamen, registroAprobado.PromedioFinal
                    );
                }
                else
                {
                    float notaNecesaria = Calculos.CalcularNotaExamenNecesaria(c1, p1, c2, p2, c3, p3, c4, p4);
                    RegistroReprobatorio registroReprobado = new RegistroReprobatorio
                    {
                        NombreAlumno = txtNombreAlumno.Text,
                        NombreRamo = txtNombreRamo.Text,
                        Calificacion1 = c1,
                        Ponderacion1 = p1,
                        Calificacion2 = c2,
                        Ponderacion2 = p2,
                        Calificacion3 = c3,
                        Ponderacion3 = p3,
                        Calificacion4 = c4,
                        Ponderacion4 = p4,
                        NotaExamen = notaExamen,
                        PromedioFinal = promedioFinal,
                        CalificacionEstimadaDeAprobacion = notaNecesaria
                    };
                    dgvReprobados.Rows.Add(
                       registroReprobado.NombreAlumno, registroReprobado.NombreRamo,
                       registroReprobado.Calificacion1, registroReprobado.Ponderacion1,
                       registroReprobado.Calificacion2, registroReprobado.Ponderacion2,
                       registroReprobado.Calificacion3, registroReprobado.Ponderacion3,
                       registroReprobado.Calificacion4, registroReprobado.Ponderacion4,
                       registroReprobado.NotaExamen, registroReprobado.PromedioFinal,
                       registroReprobado.CalificacionEstimadaDeAprobacion
                   );
                }
                LimpiarFormulario();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrese de que todos los campos numéricos contengan valores válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreAlumno.Clear();
            txtNombreRamo.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtPond1.Clear();
            txtPond2.Clear();
            txtPond3.Clear();
            txtPond4.Clear();
            txtNotaExamen.Clear();
            txtNombreAlumno.Focus();
        }
    }
}