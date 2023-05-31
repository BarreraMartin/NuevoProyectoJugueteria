using Articulo.BusinessLogic;
using Articulo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;

namespace Articulo.View
{
    public partial class frmAgregarProducto : Form
    {
        int id = 0;
       
        public frmAgregarProducto()
        {
            InitializeComponent();
            UpdateComboCategoria();
            UpdateComboEstado();
        }
        public frmAgregarProducto(Producto entity)
        {
            InitializeComponent();
            id = entity.ProductoId;

            metroTexboxNombre.Text = entity.NombreProducto;
            metroTextDescripcion.Text = entity.Descripcion;
            metroTexPrecioUnitario.Text = Convert.ToDecimal(entity.PrecioUnitario).ToString();
            UpdateComboCategoria();
            metroComboCategoria.SelectedValue = entity.CategoriaId;
            UpdateComboEstado();
            metroComboEstado.SelectedValue = entity.EstadoId;


        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateComboEstado()
        {
            metroComboEstado.DisplayMember = "Nombre";
            metroComboEstado.ValueMember = "EstadoId";
            metroComboEstado.DataSource = EstadoBL.Instance.SelectAll();
        }
        private void UpdateComboCategoria()
        {
            metroComboCategoria.DisplayMember = "Nombre";
            metroComboCategoria.ValueMember = "CategoriaId";
            metroComboCategoria.DataSource = CategoriaBL.Instance.SelectAll();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Producto entity = new Producto()
            {
                ProductoId= id,
                NombreProducto = metroTexboxNombre.Text,
                Descripcion = metroTextDescripcion.Text,
                PrecioUnitario = decimal.Parse(metroTexPrecioUnitario.Text.ToString()),
                CategoriaId = (int)metroComboCategoria.SelectedValue,
                EstadoId=(int)metroComboEstado.SelectedValue


            };
           
            if (id == 0)
            {
                if (ProductoBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Registro se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerarCodigo(entity.ProductoId);
                }
            }
            else
            {
                if (ProductoBL.Instance.Update(entity))
                {
                    MessageBox.Show("Se edito con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();

            }


            //this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void GenerarCodigo(int id)
        {
            string codigo = id.ToString().PadLeft(4,'0');

            Barcode bc = new Barcode();
            bc.BackColor = Color.White;
            bc.ForeColor = Color.Black;
            Image img = bc.Encode(TYPE.CODE39, codigo, Color.Black, Color.White, (int)(pictureBox1.Width * 0.9), (int)(pictureBox1.Height * 0.9));
            pictureBox1.Image = img;
            pictureBox1.Image.Save(@"C:\Users\admin\Desktop\Articulo\Articulo\codebar\products\" + codigo + ".png");
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
