using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPob;

namespace Examen
{
    public partial class Form1 : Form
    {
        CPExamenes objCPE = new CPExamenes();
        private string idExamen = null;
        private bool Edit = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                try
                {
                    objCPE.InsertEx(txtIdEx.Text, txtName.Text, txtDesc.Text);
                    MessageBox.Show("Examen Agregado de forma exitosa");
                    ShowProd();
                    ClrForms();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error producido por: " + ex);
                }
            } 
            else
            {
                try
                {
                    objCPE.UpdateEx(txtIdEx.Text, txtName.Text, txtDesc.Text);
                    MessageBox.Show("Se edito de forma correcta");
                    ShowProd();
                    Edit = false;
                    ClrForms();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el campo por: " + ex);
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowProd()
        {
            CPExamenes objCPE = new CPExamenes();
            dataGridView1.DataSource = objCPE.MostrarEx();
        }
            private void ClrForms()
        {
            txtIdEx.Clear();
            txtName.Clear();
            txtDesc.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ShowProd();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                Edit = true;
                txtIdEx.Text = dataGridView1.CurrentRow.Cells["idExamen"].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                idExamen = dataGridView1.CurrentRow.Cells["idExamen"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una fila");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idExamen = dataGridView1.CurrentRow.Cells["idExamen"].Value.ToString();
                objCPE.DeleteEx(idExamen);
                MessageBox.Show("Registro Eliminado");
                ShowProd();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una fila");
            }
        }

        private void btnSED_Click(object sender, EventArgs e)
        {
            CPExamenes objCPE = new CPExamenes();
            dataGridView1.DataSource = objCPE.MostrarED(txtName.Text, txtDesc.Text);
        }

        private void btnSALL_Click(object sender, EventArgs e)
        {
            ShowProd();
        }

        private void txtIdEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
