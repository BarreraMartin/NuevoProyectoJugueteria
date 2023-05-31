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
    public partial class frmUsuarioNuevo : MetroForm
    {
        int id = 0;
        public frmUsuarioNuevo()
        {
            InitializeComponent();
            UpdateCombo();

        }
        public frmUsuarioNuevo(Usuario entity)
        {
            InitializeComponent();
            id = entity.UsuarioId;
            metroTextBox1.Text = entity.Email;
            //metroTextBox2.Text = entity.Password;
            UpdateCombo();
            metroComboBox1.SelectedValue = entity.RolId;



        }

        private void frmUsuarioNuevo_Load(object sender, EventArgs e)
        {
        }
        private void UpdateCombo()
        {
            metroComboBox1.DisplayMember = "Nombre";
            metroComboBox1.ValueMember = "RolId";
            metroComboBox1.DataSource = RolBL.Instance.SelectAll();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (metroTextBox1.Text == "")
            {
                errorProvider1.SetError(metroTextBox1, "Campo obligatorio");
                return;
            }
            if (metroTextBox2.Text == "")
            {
                errorProvider1.SetError(metroTextBox2, "Campo obligatorio");
                return;
            }


            Usuario entity = new Usuario()
            {
                UsuarioId = id,
                Email = metroTextBox1.Text.Trim(),
                //Password = metroTextBox2.Text.Trim(),
                RolId = (int)metroComboBox1.SelectedValue

            };
            if (id == 0)
            {
                if (UsuarioBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Registro se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (UsuarioBL.Instance.Update(entity))
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
