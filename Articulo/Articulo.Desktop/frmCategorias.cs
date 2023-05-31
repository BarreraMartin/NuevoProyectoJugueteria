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

namespace Articulo.Desktop
{
    public partial class frmCategorias : MetroForm
    {
        private List<Categoria> _listado;
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            
            _listado = CategoriaBL.Instance.SelectAll();

            var query = from x in _listado
                        select new
                        {
                            Id = x.CategoriaId,
                            Nombre = x.Nombre,
                            Estado = x.Estados.Nombre
                        };

            metroGrid1.DataSource = query.ToList();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmCategoriasNuevo frm = new frmCategoriasNuevo();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentRow.Cells["Editar"].Selected)
            {
                int id =(int) metroGrid1.CurrentRow.Cells[2].Value;
                string nombre = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                int estadoId = _listado.FirstOrDefault(x => x.CategoriaId.Equals(id)).EstadoId;

                Categoria entity = new Categoria()
                {
                    CategoriaId = id,
                    Nombre = nombre,
                    EstadoId = estadoId
                };

                frmCategoriasNuevo frm = new frmCategoriasNuevo(entity);
                frm.ShowDialog();
                UpdateGrid();
            }
        }
    }
}
