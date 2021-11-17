using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaAlvaroMerino
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void pistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmAdminPistas")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        this.MdiChildren[0].Close();
                        frmAdminPistas f = new frmAdminPistas();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                frmAdminPistas f = new frmAdminPistas();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void rESERVASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmReservas")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        this.MdiChildren[0].Close();
                        frmReservas f = new frmReservas();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                frmReservas f = new frmReservas();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmAdminSocios")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        this.MdiChildren[0].Close();
                        frmAdminSocios f = new frmAdminSocios();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                frmAdminSocios f = new frmAdminSocios();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }
    }
}
