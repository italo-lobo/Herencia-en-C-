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
using System.Data.SqlClient;

namespace Instituto_2021
{
    public partial class formAlumnos : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-0DV9V2E\\SQLEXPRESS;Initial Catalog=Instituto2021;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public formAlumnos()
        {
            InitializeComponent();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            conexion.Open();
           

            //cargando los datos en la clase 
            try
            {
                alumno.pDni = Convert.ToInt32(txtDni.Text);
                alumno.pLegajo = Convert.ToInt32(txtLegajo.Text);
                alumno.pNombre = txtNombre.Text;
                alumno.pCarrera = cbxCarrera.SelectedItem.ToString();
                alumno.pNac = Convert.ToDateTime(dtpNac.Value.ToShortDateString());
                // cargando los datos en el data
                alumno.Sexo(rbtMasc.Checked, rbtFem.Checked);
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = alumno.pLegajo;
                dataGridView1.Rows[n].Cells[1].Value = alumno.pDni;
                dataGridView1.Rows[n].Cells[2].Value = alumno.pNombre;
                dataGridView1.Rows[n].Cells[3].Value = alumno.pCarrera;
                dataGridView1.Rows[n].Cells[4].Value = alumno.pSexo;
                dataGridView1.Rows[n].Cells[5].Value = alumno.pNac.ToShortDateString();
                dataGridView1.Rows[n].Cells[6].Value = alumno.Edad(alumno.pNac.Year);
                limpiar();
                
                string consulta = "insert into Alumnos values (" + txtDni + "," + txtLegajo + ",'" + txtNombre + "','" + alumno.pSexo + "','" + alumno.pCarrera + "','" + alumno.pNac + "')";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos cargados");
                conexion.Close();

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
                cbxCarrera.Text = "";
                rbtFem.Checked = false;
                rbtMasc.Checked = false;
                dtpNac.Value = DateTime.Today;
            }
            #endregion


        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
