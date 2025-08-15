namespace CalculadoraDePromedios
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreRamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtPond1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtPond2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtPond3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtPond4 = new System.Windows.Forms.TextBox();
            this.txtNotaExamen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalcularNecesaria = new System.Windows.Forms.Button();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.dgvAprobados = new System.Windows.Forms.DataGridView();
            this.colAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPond1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPond2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPond3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPond4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReprobados = new System.Windows.Forms.DataGridView();
            this.colAlumno_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRamo_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota1_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPond1_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota2_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPond2_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota3_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPond3_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota4_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPond4_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExamen_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedioFinal_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotaNecesaria_Rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprobados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReprobados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Ramo:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(170, 140);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(100, 26);
            this.txtNombreAlumno.TabIndex = 2;
            // 
            // txtNombreRamo
            // 
            this.txtNombreRamo.Location = new System.Drawing.Point(435, 140);
            this.txtNombreRamo.Name = "txtNombreRamo";
            this.txtNombreRamo.Size = new System.Drawing.Size(100, 26);
            this.txtNombreRamo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " Nota 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ponderación (%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nota 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ponderación (%):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nota 3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ponderación (%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nota 4:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ponderación (%):";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(168, 212);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 26);
            this.txtNota1.TabIndex = 12;
            // 
            // txtPond1
            // 
            this.txtPond1.Location = new System.Drawing.Point(435, 212);
            this.txtPond1.Name = "txtPond1";
            this.txtPond1.Size = new System.Drawing.Size(100, 26);
            this.txtPond1.TabIndex = 13;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(168, 259);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 26);
            this.txtNota2.TabIndex = 14;
            // 
            // txtPond2
            // 
            this.txtPond2.Location = new System.Drawing.Point(435, 256);
            this.txtPond2.Name = "txtPond2";
            this.txtPond2.Size = new System.Drawing.Size(100, 26);
            this.txtPond2.TabIndex = 15;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(168, 307);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 26);
            this.txtNota3.TabIndex = 16;
            // 
            // txtPond3
            // 
            this.txtPond3.Location = new System.Drawing.Point(435, 307);
            this.txtPond3.Name = "txtPond3";
            this.txtPond3.Size = new System.Drawing.Size(100, 26);
            this.txtPond3.TabIndex = 17;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(168, 354);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 26);
            this.txtNota4.TabIndex = 18;
            // 
            // txtPond4
            // 
            this.txtPond4.Location = new System.Drawing.Point(435, 357);
            this.txtPond4.Name = "txtPond4";
            this.txtPond4.Size = new System.Drawing.Size(100, 26);
            this.txtPond4.TabIndex = 19;
            // 
            // txtNotaExamen
            // 
            this.txtNotaExamen.Location = new System.Drawing.Point(302, 408);
            this.txtNotaExamen.Name = "txtNotaExamen";
            this.txtNotaExamen.Size = new System.Drawing.Size(100, 26);
            this.txtNotaExamen.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nota Examen:";
            // 
            // btnCalcularNecesaria
            // 
            this.btnCalcularNecesaria.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalcularNecesaria.Location = new System.Drawing.Point(168, 465);
            this.btnCalcularNecesaria.Name = "btnCalcularNecesaria";
            this.btnCalcularNecesaria.Size = new System.Drawing.Size(234, 40);
            this.btnCalcularNecesaria.TabIndex = 22;
            this.btnCalcularNecesaria.Text = "Calcular Nota Necesaria";
            this.btnCalcularNecesaria.UseVisualStyleBackColor = false;
            this.btnCalcularNecesaria.Click += new System.EventHandler(this.btnCalcularNecesaria_Click);
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalcularPromedio.Location = new System.Drawing.Point(168, 511);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(233, 44);
            this.btnCalcularPromedio.TabIndex = 23;
            this.btnCalcularPromedio.Text = "Calcular Promedio y Registrar";
            this.btnCalcularPromedio.UseVisualStyleBackColor = false;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);
            // 
            // dgvAprobados
            // 
            this.dgvAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAprobados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlumno,
            this.colRamo,
            this.colNota1,
            this.colPond1,
            this.colNota2,
            this.colPond2,
            this.colNota3,
            this.colPond3,
            this.colNota4,
            this.colPond4,
            this.colExamen,
            this.colPromedioFinal});
            this.dgvAprobados.Location = new System.Drawing.Point(673, 95);
            this.dgvAprobados.Name = "dgvAprobados";
            this.dgvAprobados.RowHeadersWidth = 62;
            this.dgvAprobados.RowTemplate.Height = 28;
            this.dgvAprobados.Size = new System.Drawing.Size(660, 150);
            this.dgvAprobados.TabIndex = 24;
            // 
            // colAlumno
            // 
            this.colAlumno.HeaderText = "Alumno";
            this.colAlumno.MinimumWidth = 8;
            this.colAlumno.Name = "colAlumno";
            this.colAlumno.Width = 150;
            // 
            // colRamo
            // 
            this.colRamo.HeaderText = "Ramo";
            this.colRamo.MinimumWidth = 8;
            this.colRamo.Name = "colRamo";
            this.colRamo.Width = 150;
            // 
            // colNota1
            // 
            this.colNota1.HeaderText = "Nota 1";
            this.colNota1.MinimumWidth = 8;
            this.colNota1.Name = "colNota1";
            this.colNota1.Width = 150;
            // 
            // colPond1
            // 
            this.colPond1.HeaderText = "Pond. 1";
            this.colPond1.MinimumWidth = 8;
            this.colPond1.Name = "colPond1";
            this.colPond1.Width = 150;
            // 
            // colNota2
            // 
            this.colNota2.HeaderText = "Nota 2";
            this.colNota2.MinimumWidth = 8;
            this.colNota2.Name = "colNota2";
            this.colNota2.Width = 150;
            // 
            // colPond2
            // 
            this.colPond2.HeaderText = "Pond. 2";
            this.colPond2.MinimumWidth = 8;
            this.colPond2.Name = "colPond2";
            this.colPond2.Width = 150;
            // 
            // colNota3
            // 
            this.colNota3.HeaderText = "Nota 3";
            this.colNota3.MinimumWidth = 8;
            this.colNota3.Name = "colNota3";
            this.colNota3.Width = 150;
            // 
            // colPond3
            // 
            this.colPond3.HeaderText = "Pond. 3";
            this.colPond3.MinimumWidth = 8;
            this.colPond3.Name = "colPond3";
            this.colPond3.Width = 150;
            // 
            // colNota4
            // 
            this.colNota4.HeaderText = "Nota 4";
            this.colNota4.MinimumWidth = 8;
            this.colNota4.Name = "colNota4";
            this.colNota4.Width = 150;
            // 
            // colPond4
            // 
            this.colPond4.HeaderText = "Pond. 4";
            this.colPond4.MinimumWidth = 8;
            this.colPond4.Name = "colPond4";
            this.colPond4.Width = 150;
            // 
            // colExamen
            // 
            this.colExamen.HeaderText = "Examen";
            this.colExamen.MinimumWidth = 8;
            this.colExamen.Name = "colExamen";
            this.colExamen.Width = 150;
            // 
            // colPromedioFinal
            // 
            this.colPromedioFinal.HeaderText = "Promedio Final";
            this.colPromedioFinal.MinimumWidth = 8;
            this.colPromedioFinal.Name = "colPromedioFinal";
            this.colPromedioFinal.Width = 150;
            // 
            // dgvReprobados
            // 
            this.dgvReprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReprobados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlumno_Rep,
            this.colRamo_Rep,
            this.colNota1_Rep,
            this.colPond1_Rep,
            this.colNota2_Rep,
            this.colPond2_Rep,
            this.colNota3_Rep,
            this.colPond3_Rep,
            this.colNota4_Rep,
            this.colPond4_Rep,
            this.colExamen_Rep,
            this.colPromedioFinal_Rep,
            this.colNotaNecesaria_Rep});
            this.dgvReprobados.Location = new System.Drawing.Point(673, 337);
            this.dgvReprobados.Name = "dgvReprobados";
            this.dgvReprobados.RowHeadersWidth = 62;
            this.dgvReprobados.Size = new System.Drawing.Size(660, 150);
            this.dgvReprobados.TabIndex = 25;
            // 
            // colAlumno_Rep
            // 
            this.colAlumno_Rep.HeaderText = "Alumno";
            this.colAlumno_Rep.MinimumWidth = 8;
            this.colAlumno_Rep.Name = "colAlumno_Rep";
            this.colAlumno_Rep.Width = 150;
            // 
            // colRamo_Rep
            // 
            this.colRamo_Rep.HeaderText = "Ramo";
            this.colRamo_Rep.MinimumWidth = 8;
            this.colRamo_Rep.Name = "colRamo_Rep";
            this.colRamo_Rep.Width = 150;
            // 
            // colNota1_Rep
            // 
            this.colNota1_Rep.HeaderText = "Nota 1";
            this.colNota1_Rep.MinimumWidth = 8;
            this.colNota1_Rep.Name = "colNota1_Rep";
            this.colNota1_Rep.Width = 150;
            // 
            // colPond1_Rep
            // 
            this.colPond1_Rep.HeaderText = "Pond. 1";
            this.colPond1_Rep.MinimumWidth = 8;
            this.colPond1_Rep.Name = "colPond1_Rep";
            this.colPond1_Rep.Width = 150;
            // 
            // colNota2_Rep
            // 
            this.colNota2_Rep.HeaderText = "Nota 2";
            this.colNota2_Rep.MinimumWidth = 8;
            this.colNota2_Rep.Name = "colNota2_Rep";
            this.colNota2_Rep.Width = 150;
            // 
            // colPond2_Rep
            // 
            this.colPond2_Rep.HeaderText = "Pond. 2";
            this.colPond2_Rep.MinimumWidth = 8;
            this.colPond2_Rep.Name = "colPond2_Rep";
            this.colPond2_Rep.Width = 150;
            // 
            // colNota3_Rep
            // 
            this.colNota3_Rep.HeaderText = "Nota 3";
            this.colNota3_Rep.MinimumWidth = 8;
            this.colNota3_Rep.Name = "colNota3_Rep";
            this.colNota3_Rep.Width = 150;
            // 
            // colPond3_Rep
            // 
            this.colPond3_Rep.HeaderText = "Pond. 3";
            this.colPond3_Rep.MinimumWidth = 8;
            this.colPond3_Rep.Name = "colPond3_Rep";
            this.colPond3_Rep.Width = 150;
            // 
            // colNota4_Rep
            // 
            this.colNota4_Rep.HeaderText = "Nota 4";
            this.colNota4_Rep.MinimumWidth = 8;
            this.colNota4_Rep.Name = "colNota4_Rep";
            this.colNota4_Rep.Width = 150;
            // 
            // colPond4_Rep
            // 
            this.colPond4_Rep.HeaderText = "Pond. 4";
            this.colPond4_Rep.MinimumWidth = 8;
            this.colPond4_Rep.Name = "colPond4_Rep";
            this.colPond4_Rep.Width = 150;
            // 
            // colExamen_Rep
            // 
            this.colExamen_Rep.HeaderText = "Examen";
            this.colExamen_Rep.MinimumWidth = 8;
            this.colExamen_Rep.Name = "colExamen_Rep";
            this.colExamen_Rep.Width = 150;
            // 
            // colPromedioFinal_Rep
            // 
            this.colPromedioFinal_Rep.HeaderText = "Promedio Final";
            this.colPromedioFinal_Rep.MinimumWidth = 8;
            this.colPromedioFinal_Rep.Name = "colPromedioFinal_Rep";
            this.colPromedioFinal_Rep.Width = 150;
            // 
            // colNotaNecesaria_Rep
            // 
            this.colNotaNecesaria_Rep.HeaderText = "Nota Necesaria";
            this.colNotaNecesaria_Rep.MinimumWidth = 8;
            this.colNotaNecesaria_Rep.Name = "colNotaNecesaria_Rep";
            this.colNotaNecesaria_Rep.Width = 150;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SeaGreen;
            this.label12.Location = new System.Drawing.Point(669, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Alumnos Aprobados";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.IndianRed;
            this.label13.Location = new System.Drawing.Point(669, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Alumnos Reprobados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 686);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvReprobados);
            this.Controls.Add(this.dgvAprobados);
            this.Controls.Add(this.btnCalcularPromedio);
            this.Controls.Add(this.btnCalcularNecesaria);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNotaExamen);
            this.Controls.Add(this.txtPond4);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtPond3);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtPond2);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtPond1);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreRamo);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprobados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReprobados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtNombreRamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtPond1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtPond2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtPond3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtPond4;
        private System.Windows.Forms.TextBox txtNotaExamen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalcularNecesaria;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.DataGridView dgvAprobados;
        private System.Windows.Forms.DataGridView dgvReprobados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPond1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPond2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPond3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPond4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromedioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlumno_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRamo_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota1_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPond1_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota2_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPond2_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota3_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPond3_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota4_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPond4_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamen_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromedioFinal_Rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaNecesaria_Rep;
    }
}