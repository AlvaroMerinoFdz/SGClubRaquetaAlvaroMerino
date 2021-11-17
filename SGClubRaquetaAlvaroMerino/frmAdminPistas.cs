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
    public partial class frmAdminPistas : Form
    {
        dsBDTableAdapters.reservasTableAdapter taReservas = new dsBDTableAdapters.reservasTableAdapter();
        public frmAdminPistas()
        {
            InitializeComponent();
        }

        private void pistasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

            this.bindingNavigatorAddNewItem.Enabled = true;
            this.bindingNavigatorDeleteItem.Enabled = true;

        }

        private void frmAdminPistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.dsBD.pistas);

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            ofdFoto.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofdFoto.FileName);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //Modificamos el botón eliminar item
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("¿Seguro que quieres eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resp == DialogResult.Yes)
            {
                //Tenemos que comprobar que la pista no está alquilada.
                taReservas.FillByPista(dsBD.reservas, int.Parse(this.lblIdPista.Text));

                if(dsBD.reservas.Count > 0) // la pista tiene reservas
                {
                    DialogResult respuesta = MessageBox.Show("La pista tiene reservas \n ¿Deseas eliminarlas también?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if(respuesta == DialogResult.Yes)
                    {
                        //Si está alquilada comprobamos que se puedan eliminar los alquileres y luego la pista
                        taReservas.Delete(int.Parse(lblIdPista.Text));
                        MessageBox.Show("Reservas eliminadas", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pistasTableAdapter.Fill(dsBD.pistas);

                        //Ahora eliminamos la pista
                        this.pistasTableAdapter.Delete(int.Parse(lblIdPista.Text));
                        MessageBox.Show("Pista eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pistasTableAdapter.Fill(dsBD.pistas);
                    }
                    else
                    {
                        MessageBox.Show("La pista no se puede eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    this.pistasTableAdapter.Delete(int.Parse(lblIdPista.Text));
                    MessageBox.Show("Pista eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pistasTableAdapter.Fill(dsBD.pistas);
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
        }
    }
}
