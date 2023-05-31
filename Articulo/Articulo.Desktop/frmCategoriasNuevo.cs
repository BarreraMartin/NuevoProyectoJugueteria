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
using MetroFramework;

namespace Articulo.Desktop
{
    public partial class frmCategoriasNuevo : MetroForm
    {
        int id = 0;
        public frmCategoriasNuevo()
        {
            InitializeComponent();
            UpdateCombo();
        }

        public frmCategoriasNuevo(Categoria entity)
        {
            InitializeComponent();
            id = entity.CategoriaId;

            metroTextBox1.Text = entity.Nombre;
            UpdateCombo();
            metroComboBox1.SelectedValue = entity.EstadoId;
        }

        private void frmCategoriasNuevo_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateCombo()
        {
            metroComboBox1.DisplayMember = "Nombre";
            metroComboBox1.ValueMember = "EstadoId";
            metroComboBox1.DataSource = EstadoBL.Instance.SellectAll();
            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Categoria entity = new Categoria()
            {
                CategoriaId =id,
                Nombre = metroTextBox1.Text.Trim(),
                EstadoId =(int) metroComboBox1.SelectedValue
            };
            if(id == 0)
            {
                if (CategoriaBL.Instance.Insert(entity))
                {
                    MetroMessageBox.Show(this, "Registro se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }
            else
            {
                if (CategoriaBL.Instance.Update(entity))
                {
                    MetroMessageBox.Show(this, "Registro se edito con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
