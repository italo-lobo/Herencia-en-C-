using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instituto_2021
{
    public partial class FormDocente : Form
    {
        public FormDocente()
        {
            InitializeComponent();
        }

        private void rbtRegistrar_Click(object sender, EventArgs e)
        {
            Docentes docente = new Docentes();
            //cargando los datos en la clase 
            try
            {
                docente.pDni = Convert.ToInt32(txtDni.Text);
                docente.pLegajo = Convert.ToInt32(txtLegajo.Text);
                docente.pNombre = txtNombre.Text;
                docente.pMateria = cbxMateria.SelectedItem.ToString();
                docente.pNac = Convert.ToDateTime(dtpNac.Value.ToShortDateString());
                // cargando los datos en el data
                docente.Sexo(rbtMasc.Checked, rbtFem.Checked);
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = docente.pLegajo;
                dataGridView1.Rows[n].Cells[1].Value = docente.pDni;
                dataGridView1.Rows[n].Cells[2].Value = docente.pNombre;
                dataGridView1.Rows[n].Cells[3].Value = docente.pMateria;
                dataGridView1.Rows[n].Cells[4].Value = docente.pSexo;
                dataGridView1.Rows[n].Cells[5].Value = docente.pNac.ToShortDateString();
                dataGridView1.Rows[n].Cells[6].Value = docente.Edad(docente.pNac.Year);
                limpiar();

               
            }
            catch (Exception)
            {
                MessageBox.Show("Complete todos los campos ");
            }
            #region limpiar 
                void limpiar()
                {
                    txtLegajo.Text = "";
                    txtDni.Text = "";
                    txtDni.Focus();
                    txtNombre.Text = "";
                    cbxMateria.Text = "";
                    rbtFem.Checked = false;
                    rbtMasc.Checked = false;
                    dtpNac.Value = DateTime.Today;
                }
                #endregion
        }
    }
}
