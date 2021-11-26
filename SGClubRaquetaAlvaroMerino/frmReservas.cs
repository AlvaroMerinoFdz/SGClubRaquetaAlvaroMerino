using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SGClubRaquetaAlvaroMerino
{
    public partial class frmReservas : Form
    {
        public byte[] MyData { get; private set; }
        ArrayList listaCodPista = new ArrayList();
        ArrayList listaSocios = new ArrayList();
        ArrayList listaReservas = new ArrayList();
        private bool fechaCorrecta, pagado;
        DataSet dataSet;

        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.dsBD.socios);

            //Cargamos el combo de los socios
            cargarSocios();

            //Cargamos el Combo de las pistas
            cargarPistas();

            this.dataSet = new DataSet();

            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.Value = DateTime.Today;

        }

        private void cargarPistas()
        {
            dsBDTableAdapters.pistasTableAdapter tbPistas = new dsBDTableAdapters.pistasTableAdapter();
            tbPistas.Fill(dsBD.pistas);
            for (int i = 0; i < dsBD.pistas.Count; i++)
            {
                cmbPista.Items.Add(dsBD.pistas[i].nombre);
                listaCodPista.Add(dsBD.pistas[i].idPista);
            }
        }

        private void cargarSocios()
        {
            dsBDTableAdapters.sociosTableAdapter tbSocios = new dsBDTableAdapters.sociosTableAdapter();
            tbSocios.Fill(dsBD.socios);
            for (int i = 0; i < dsBD.socios.Count; i++)
            {
                cmbSocio.Items.Add(dsBD.socios[i].nombre);
                listaSocios.Add(dsBD.socios[i].DNI);
            }
            //cmbSocio.SelectedIndex = 0;
        }
        private void cargarReservasSocio()
        {
            this.dataSet.Reset();
            iniciarDGV();
            string dni = listaSocios[this.cmbSocio.SelectedIndex].ToString();
            reservasTableAdapter.FillByIDSocio(dsBD.reservas, dni);

            for (int i = 0; i < dsBD.reservas.Count; i++)
            {
                dataSet.Tables[0].Rows.Add(dsBD.reservas[i].fecha.ToString("dd/MM/yyyy"));
                dgvReservas.Rows[i].Cells["Hora"].Value = dsBD.reservas[i].hora;
                dgvReservas.Rows[i].Cells["Pista"].Value = dsBD.reservas[i].pista;
                dgvReservas.Rows[i].Cells["Pagado"].Value = dsBD.reservas[i].pagado;
                dgvReservas.Rows[i].Cells["Euros"].Value = dsBD.reservas[i].cantidad;
                listaReservas.Add(dsBD.reservas[i].idReserva);
            }
        }
        private void iniciarDGV()
        {
            this.dataSet.Reset();
            dataSet.Tables.Add(new DataTable("Reserva"));
            dataSet.Tables[0].Columns.Add("Fecha");
            dataSet.Tables[0].Columns.Add("Hora");
            dataSet.Tables[0].Columns.Add("Pista");
            dataSet.Tables[0].Columns.Add("Pagado");
            dataSet.Tables[0].Columns.Add("Euros");
            dgvReservas.DataSource = this.dataSet.Tables[0];

        }

        private void cmbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cada vez que cambiemos los datos del combo tendremos que cambiar también todos los datos.
            dsBDTableAdapters.sociosTableAdapter tbSocios = new dsBDTableAdapters.sociosTableAdapter();
            tbSocios.Fill(dsBD.socios);

            //Activamos los controles, este método solo se va a notar la primera vez que cambiemos los socios.
            activarControles();

            //Mostramos los datos de los socios
            lblDniSocio.Text = dsBD.socios[cmbSocio.SelectedIndex].DNI.ToString();
            txtNombre.Text = dsBD.socios[cmbSocio.SelectedIndex].nombre.ToString();
            txtApellidos.Text = dsBD.socios[cmbSocio.SelectedIndex].apellidos.ToString();
            txtDireccion.Text = dsBD.socios[cmbSocio.SelectedIndex].apellidos.ToString();
            txtEmail.Text = dsBD.socios[cmbSocio.SelectedIndex].email.ToString();
            mktTelefono.Text = dsBD.socios[cmbSocio.SelectedIndex].telefono.ToString();
            mktCuenta.Text = dsBD.socios[cmbSocio.SelectedIndex].cuentaCorriente.ToString();

            //cargamos las reservas de ese socio en el dgv
            cargarReservasSocio();

            //deshabilitamos el botón pagar.
            btnPagar.Enabled = false;
        }

        private void activarControles()
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            mktTelefono.Enabled = true;
            mktCuenta.Enabled = true;
            cmbPista.Enabled = true;
        }

        private void cmbPista_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarImagenPista();
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                btnReservar.Enabled = true;
                dtpFecha.Enabled = true;
                nupdHora.Enabled = true;
                nupdMinutos.Enabled = true;
            }

        }

        private void cargarImagenPista()
        {
            int idPista = int.Parse(listaCodPista[cmbPista.SelectedIndex].ToString());
            pistasTableAdapter.FillByPistaID(dsBD.pistas, idPista);
            if (dsBD.pistas.Rows.Count > 0)
            {

                DataRow myRow = dsBD.pistas.Rows[0];
                MyData = (byte[])myRow["foto"];
                MemoryStream stream = new MemoryStream(MyData);
                pcbImagen.Image = Image.FromStream(stream);


            }

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            var fechaActual = DateTime.Today;
            var fechaSelec = dtpFecha.Value;


            if (fechaSelec.CompareTo(fechaActual) < 0)
            {
                MessageBox.Show("La fecha es anterior a la actual", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fechaCorrecta = false;
            }
            else
            {
                fechaCorrecta = true;
            }
        }

       

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //Ya hemos comprobado que solamente se podrá pagar una pista cuando no esté pagada
            dsBDTableAdapters.reservasTableAdapter reservaTa = new dsBDTableAdapters.reservasTableAdapter();
            //Cogemos los valores del dgv
            int idPista = int.Parse(dgvReservas.SelectedRows[0].Cells["Pista"].Value.ToString());
            string hora = dgvReservas.SelectedRows[0].Cells["Hora"].Value.ToString(); ;

            reservaTa.UpdatePagado("Si", dtpFecha.Value.ToString(), hora, idPista);

            cargarReservasSocio();
            btnPagar.Enabled = false;

        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String pagadoSeleccionada = dgvReservas.SelectedRows[0].Cells["Pagado"].Value.ToString();
            if (pagadoSeleccionada.Equals("No"))
            {
                btnPagar.Enabled = true;
            }
            else
            {
                btnPagar.Enabled = false;
            }
        }

        private bool comprobarHora(TimeSpan horaBD, TimeSpan horaReserva)
        {
            bool correcto;
           
            //calculamos el intervalo entre las dos
            TimeSpan intervalo = horaReserva - horaBD;

            if ((Math.Abs(intervalo.Hours)) < 1)
            {
                correcto = false;
            }
            else if(Math.Abs(intervalo.Hours)>=2)
            {
                correcto = true;
            }else if ((Math.Abs(intervalo.Minutes)) >= 30)
            {
                //Si solo hay una hora de diferencia en el intervalo se mira que haya 30 minutos o más de espacio
                correcto = true;
            }
            else
            {
                correcto = false;
            }
            return correcto;

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            int idPista = int.Parse(listaCodPista[cmbPista.SelectedIndex].ToString());
            string horario = nupdHora.Value.ToString() + ":" + nupdMinutos.Value.ToString();
            var hora = DateTime.Parse(horario).TimeOfDay;


            //1º Tendremos que comprobar que el socio no tiene alguna reserva impagada con anterioridad.
            for (int i = 0; i < dsBD.reservas.Count; i++)
            {
                if (dsBD.reservas[i].pagado.Equals("No"))
                {
                    MessageBox.Show("El socio debe el pago de una pista anterior", "Error al reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pagado = false;
                }
                else
                {
                    pagado = true;
                }
            }


            //2º Comprobamos si la pista no está reservada ese día en esa misma franja horaria.
            if (pagado && fechaCorrecta)
            {
                this.reservasTableAdapter.FillByReservada(dsBD.reservas, dtpFecha.Value.ToString(), hora.ToString(), idPista);
                if (dsBD.reservas.Count > 0)
                {
                    MessageBox.Show("La pista ya tiene una reserva en ese horario", "Error al reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //3º Comprobamos que la pista no está alquilada ni hora y media antes, ni hora y media después
                    this.reservasTableAdapter.FillByPistaDia(dsBD.reservas, dtpFecha.Value.ToString(), idPista);
                    ArrayList reservas = new ArrayList(0);
                    for (int i = 0; i < dsBD.reservas.Count; i++)
                    {
                       
                        TimeSpan horaBd = dsBD.reservas[i].hora;

                        if (!comprobarHora(horaBd, hora))
                        {
                            reservas.Add(i);
                        }
                    }
                    if(reservas.Count > 0)
                    {
                        MessageBox.Show("La pista ya tiene una reserva en ese horario", "Error al reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Si la pista está libre tenemos que pedir un mensaje de confimación
                        DialogResult respuesta = MessageBox.Show("La pista está libre \n ¿Quieres alquilarla?", "Alquilar Pista", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (respuesta == DialogResult.Yes)
                        {
                            //Si la pista está libre procedemos a realizar la reserva, es decir a realizar el insert en la BBDD.
                            //4º Realizar el cálcula del coste de la reserva de 1h y 30 min, una vez hecho
                            //   se inserta en la tabla correspondiente poiendo campo pagado a NO.
                            pistasTableAdapter.FillByPistaID(dsBD.pistas, int.Parse(listaCodPista[cmbPista.SelectedIndex].ToString()));

                            //Calculamos el precio
                            int precioHora = int.Parse(dsBD.pistas[0].precioHora.ToString());
                            decimal precio = (decimal)(precioHora * 1.5);

                            //Insertamos la reserva en la tabla
                            reservasTableAdapter.InsertReserva(dtpFecha.Value.ToString(), hora.ToString(), idPista, lblDniSocio.Text.ToString(), precio);


                            //5º Refrescar los datos de dgv, de manera que refleje la nueva reserva.
                            cargarReservasSocio();
                        }
                    }
                }
            }


        }
    }
}
