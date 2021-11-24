using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SGClubRaquetaAlvaroMerino
{
    public partial class frmAdminSocios : Form
    {
        public frmAdminSocios()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comprobarCamposVacios())
            {
                string dni = mktxtDni.Text;
                string nombre = txtNombre.Text;
                string apellidos = txtApellidos.Text;
                string domicilio = txtDomicilio.Text;
                string telefono = mtxtTelefono.Text;
                string email = txtEmail.Text;
                string cuenta = mtxtCCC.Text;

                if (comprobarSociosExistentes(dni))
                {
                    using (clubraquetaEntities objBd = new clubraquetaEntities())
                    {
                        socios objSocio = new socios();
                        objSocio.DNI = dni;
                        objSocio.nombre = nombre;
                        objSocio.apellidos = apellidos;
                        objSocio.domicilio = domicilio;
                        objSocio.telefono = telefono;
                        objSocio.email = email;
                        objSocio.cuentaCorriente = cuenta;

                        objBd.socios.Add(objSocio);
                        MessageBox.Show("Socio añadido correctamente...");
                        objBd.SaveChanges();
                        LimpiarCampo();
                    }
                }
            }
        }

        private void LimpiarCampo()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            mktxtDni.Text = "";
            mtxtCCC.Text = "";
            mtxtTelefono.Text = "";
        }

        /**
         * Método que comprueba que no exista algún socio con el mismo DNI.
         */
        private bool comprobarSociosExistentes(string text)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var consulta = from soc in objBD.socios
                               where soc.DNI == text
                               select soc;
                if (consulta.Count() > 0)
                {
                    MessageBox.Show("Socio Existente");
                    return false;
                }
                return true;

            }
        }

        /**
         * Método que comprueba que todas las máscaras están completas 
         * y que todos los textBox tienen algún dato. 
         */
        private bool comprobarCamposVacios()
        {
            if (!mktxtDni.MaskCompleted || string.IsNullOrEmpty(mktxtDni.Text))
            {
                MessageBox.Show("El dni está incompleto");
                return false;
            }
            else if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDomicilio.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Rellene todos los campos antes de seguir");
                return false;
            }
            else if (string.IsNullOrEmpty(mtxtTelefono.Text) || !mtxtTelefono.MaskCompleted)
            {
                MessageBox.Show("Rellene el campo telefono");
                return false;
            }
            else if (string.IsNullOrEmpty(mtxtCCC.Text) || !mtxtCCC.MaskCompleted)
            {
                MessageBox.Show("Rellene el campo de la cuenta corriente");
                return false;
            }
            return true;
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var consulta = from soc in objBD.socios
                               select new { DNI = soc.DNI, NOMBRE = soc.nombre, 
                                   APELLIDOS = soc.apellidos, DOMICILIO = soc.domicilio,
                                   TELEFONO = soc.telefono, EMAIL = soc.email, CCC = soc.cuentaCorriente};

                dgvSocios.DataSource = consulta.ToList();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string dni = mktxtDni.Text;
            if (comprobarCamposVacios() && !comprobarSociosExistentes(dni))
            {

                string nombre = txtNombre.Text;
                string apellidos = txtApellidos.Text;
                string domicilio = txtDomicilio.Text;
                string telefono = mtxtTelefono.Text;
                string email = txtEmail.Text;
                string cuenta = mtxtCCC.Text;


                using (clubraquetaEntities objBd = new clubraquetaEntities())
                {
                    socios objSocio = objBd.socios.First(x => x.DNI.Equals(dni));
                    objSocio.DNI = dni;
                    objSocio.nombre = nombre;
                    objSocio.apellidos = apellidos;
                    objSocio.domicilio = domicilio;
                    objSocio.telefono = telefono;
                    objSocio.email = email;
                    objSocio.cuentaCorriente = cuenta;
                    objBd.SaveChanges();
                    MessageBox.Show("Socio Actualizado correctamente");
                }
            }
            else if(comprobarSociosExistentes(dni))
            {
                MessageBox.Show("El socio no existe.");
            }else if (comprobarCamposVacios())
            {
                MessageBox.Show("Campos vacios");
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dni = mktxtDni.Text;
            if (!mktxtDni.MaskCompleted || string.IsNullOrEmpty(mktxtDni.Text))
            {
                MessageBox.Show("El dni está incompleto");

            }
            else
            {
                using (clubraquetaEntities objBD = new clubraquetaEntities())
                {
                    //Comprobamos si el socio existe
                    bool existe = objBD.socios.Any(x => x.DNI.Equals(dni));
                    if (existe)
                    {
                        //Ahora comprobamos si el socio tiene reservas de pista
                        existe = objBD.reservas.Any(x => x.socio.Equals(dni));
                        if (existe)
                        {
                            MessageBox.Show("El socio tiene alguna reserva, por tanto no se puede eliminar");
                        }
                        else
                        {
                            //Se elimina el objeto de la tabla, para quitarlo como registro
                            socios socio = objBD.socios.Find(dni);
                            objBD.socios.Remove(socio);

                            //Se guardan los cambios
                            objBD.SaveChanges();
                            MessageBox.Show("Socio eliminado correctamente");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado el socio.");
                    }

                }
            }
        }
    }
}
