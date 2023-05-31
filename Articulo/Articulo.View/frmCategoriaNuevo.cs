using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Articulo.BusinessLogic;
using Articulo.Entities;
using MetroFramework.Forms;


namespace Articulo.View
{
    public partial class frmCategoriaNuevo : MetroForm
    {

        int id = 0;
        public frmCategoriaNuevo()
        {
            InitializeComponent();
            UpdateCombo();

        }
        public frmCategoriaNuevo(Categoria entity)
        {
            InitializeComponent();
            id = entity.CategoriaId;

            metroTextBox1.Text = entity.Nombre;
            UpdateCombo();
            metroComboBox1.SelectedValue = entity.EstadoId;


        }

        private void frmCategoriaNuevo_Load(object sender, EventArgs e)
        {

        }

        private void UpdateCombo()
        {
            metroComboBox1.DisplayMember = "Nombre";
            metroComboBox1.ValueMember = "EstadoId";
            metroComboBox1.DataSource = EstadoBL.Instance.SelectAll();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           


            Categoria entity = new Categoria()
            {
               CategoriaId = id,
                Nombre = metroTextBox1.Text.Trim(),
                EstadoId = (int)metroComboBox1.SelectedValue

            };
            if (id == 0)
            {
                if (CategoriaBL.Instance.Insert(entity))
                {
                    MessageBox.Show( "Registro se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (CategoriaBL.Instance.Update(entity))
                {
                    MessageBox.Show("Registro se edito con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            this.Close();

     


        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
