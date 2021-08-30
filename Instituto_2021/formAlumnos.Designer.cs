
namespace Instituto_2021
{
    partial class formAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbtFem = new System.Windows.Forms.RadioButton();
            this.rbtMasc = new System.Windows.Forms.RadioButton();
            this.dtpNac = new System.Windows.Forms.DateTimePicker();
            this.cbxCarrera = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFnac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Legajo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Carrera:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de nacimiento";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(207, 39);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(150, 31);
            this.txtDni.TabIndex = 8;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(207, 99);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(150, 31);
            this.txtLegajo.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(207, 150);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 31);
            this.txtNombre.TabIndex = 10;
            // 
            // rbtFem
            // 
            this.rbtFem.AutoSize = true;
            this.rbtFem.Location = new System.Drawing.Point(615, 35);
            this.rbtFem.Name = "rbtFem";
            this.rbtFem.Size = new System.Drawing.Size(115, 29);
            this.rbtFem.TabIndex = 11;
            this.rbtFem.TabStop = true;
            this.rbtFem.Text = "Femenino";
            this.rbtFem.UseVisualStyleBackColor = true;
            // 
            // rbtMasc
            // 
            this.rbtMasc.AutoSize = true;
            this.rbtMasc.Location = new System.Drawing.Point(736, 35);
            this.rbtMasc.Name = "rbtMasc";
            this.rbtMasc.Size = new System.Drawing.Size(117, 29);
            this.rbtMasc.TabIndex = 12;
            this.rbtMasc.TabStop = true;
            this.rbtMasc.Text = "Masculino";
            this.rbtMasc.UseVisualStyleBackColor = true;
            // 
            // dtpNac
            // 
            this.dtpNac.Location = new System.Drawing.Point(524, 175);
            this.dtpNac.Name = "dtpNac";
            this.dtpNac.Size = new System.Drawing.Size(300, 31);
            this.dtpNac.TabIndex = 14;
            // 
            // cbxCarrera
            // 
            this.cbxCarrera.FormattingEnabled = true;
            this.cbxCarrera.Items.AddRange(new object[] {
            "Programacion",
            "Enfermeria",
            "Adm Empresas"});
            this.cbxCarrera.Location = new System.Drawing.Point(615, 85);
            this.cbxCarrera.Name = "cbxCarrera";
            this.cbxCarrera.Size = new System.Drawing.Size(182, 33);
            this.cbxCarrera.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLegajo,
            this.dgvDni,
            this.dgvNombre,
            this.dgvCarrera,
            this.dgvSexo,
            this.dgvFnac,
            this.dgvEdad});
            this.dataGridView1.Location = new System.Drawing.Point(12, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 225);
            this.dataGridView1.TabIndex = 16;
            // 
            // dgvLegajo
            // 
            this.dgvLegajo.HeaderText = "LEGAJO";
            this.dgvLegajo.MinimumWidth = 8;
            this.dgvLegajo.Name = "dgvLegajo";
            this.dgvLegajo.Width = 150;
            // 
            // dgvDni
            // 
            this.dgvDni.HeaderText = "DNI";
            this.dgvDni.MinimumWidth = 8;
            this.dgvDni.Name = "dgvDni";
            this.dgvDni.Width = 150;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "NOMBRE";
            this.dgvNombre.MinimumWidth = 8;
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.Width = 150;
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.HeaderText = "CARRERA";
            this.dgvCarrera.MinimumWidth = 8;
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.Width = 150;
            // 
            // dgvSexo
            // 
            this.dgvSexo.HeaderText = "SEXO";
            this.dgvSexo.MinimumWidth = 8;
            this.dgvSexo.Name = "dgvSexo";
            this.dgvSexo.Width = 150;
            // 
            // dgvFnac
            // 
            this.dgvFnac.HeaderText = "F NAC";
            this.dgvFnac.MinimumWidth = 8;
            this.dgvFnac.Name = "dgvFnac";
            this.dgvFnac.Width = 150;
            // 
            // dgvEdad
            // 
            this.dgvEdad.HeaderText = "EDAD";
            this.dgvEdad.MinimumWidth = 8;
            this.dgvEdad.Name = "dgvEdad";
            this.dgvEdad.Width = 150;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(484, 331);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 34);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // formAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 672);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxCarrera);
            this.Controls.Add(this.dtpNac);
            this.Controls.Add(this.rbtMasc);
            this.Controls.Add(this.rbtFem);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formAlumnos";
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbtFem;
        private System.Windows.Forms.RadioButton rbtMasc;
        private System.Windows.Forms.DateTimePicker dtpNac;
        private System.Windows.Forms.ComboBox cbxCarrera;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFnac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEdad;
        private System.Windows.Forms.Button btnRegistrar;
    }
}