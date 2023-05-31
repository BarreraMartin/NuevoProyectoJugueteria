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
    public partial class frmRol : Form
    {
        private List<Rol> _listado;

        public frmRol()
        {
            InitializeComponent();
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _listado = RolBL.Instance.SelectAll();
            var query = from x in _listado
                        select new
                        {
                            Id = x.RolId,
                            Nombre = x.Nombre,
                            Estado = x.Estado.Nombre
                        };
            metroGrid1.DataSource = query.ToList();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmRolNuevo frm = new frmRolNuevo();
            frm.ShowDialog();
            UpdateGrid();
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            _listado = RolBL.Instance.SelectAll();
            var busqueda = from x in _listado
                           select new
                           {
                               Id = x.RolId,
                               Nombre = x.Nombre,
                               Estado = x.Estado.Nombre
                           };
            var query = busqueda.Where(x => x.Nombre.ToLower().Contains(metroTextBox1.Text.ToLower())).ToList();
            metroGrid1.DataSource = query.ToList(); 
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentRow.Cells["Editar"].Selected)
            {

                int id = (int)metroGrid1.CurrentRow.Cells[2].Value;
                string nombre = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                int estadoId = _listado.FirstOrDefault(x => x.RolId.Equals(id)).EstadoId;


                Rol entity = new Rol()
                {
                    RolId = id,
                    Nombre = nombre,
                    EstadoId = estadoId
                };
                //Editar
                frmRolNuevo frm = new frmRolNuevo(entity);
                frm.ShowDialog();
                UpdateGrid();


            }
            if (metroGrid1.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int id = int.Parse(metroGrid1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                DialogResult dr = MessageBox.Show("Desea eliminar el registro actual?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (RolBL.Instance.Delete(id))
                    {
                        MessageBox.Show("Se elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                UpdateGrid();
            }
        }
    }
}
