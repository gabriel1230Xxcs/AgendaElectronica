using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaElectronica
{
    public partial class Form1 : Form
    {
        Conexion conexion = new Conexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Apellido_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Contactos(Nombre,Apellido,FechaNacimiento,Direccion,Genero,EstadoCivil,Movil,Telefono,Correo) VALUES(@Nombre,@Apellido,@Fecha,@Direccion,@Genero,@Estado,@Movil,@Telefono,@Correo)",
                    conexion.AbrirConexion());

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Fecha", dtpFechaNacimiento.Value);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Genero", cmbGenero.Text);
                cmd.Parameters.AddWithValue("@Estado", cmbEstadoCivil.Text);
                cmd.Parameters.AddWithValue("@Movil", txtMovil.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                MessageBox.Show("Registro guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Contactos WHERE Nombre=@Nombre",
                    conexion.AbrirConexion());

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtApellido.Text = dr["Apellido"].ToString();
                    dtpFechaNacimiento.Value = Convert.ToDateTime(dr["FechaNacimiento"]);
                    txtDireccion.Text = dr["Direccion"].ToString();
                    cmbGenero.Text = dr["Genero"].ToString();
                    cmbEstadoCivil.Text = dr["EstadoCivil"].ToString();
                    txtMovil.Text = dr["Movil"].ToString();
                    txtTelefono.Text = dr["Telefono"].ToString();
                    txtCorreo.Text = dr["Correo"].ToString();
                }
                else
                {
                    MessageBox.Show("Contacto no encontrado.");
                }

                dr.Close();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Contactos SET Apellido=@Apellido, FechaNacimiento=@Fecha, Direccion=@Direccion, Genero=@Genero, EstadoCivil=@Estado, Movil=@Movil, Telefono=@Telefono, Correo=@Correo WHERE Nombre=@Nombre",
                    conexion.AbrirConexion());

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Fecha", dtpFechaNacimiento.Value);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Genero", cmbGenero.Text);
                cmd.Parameters.AddWithValue("@Estado", cmbEstadoCivil.Text);
                cmd.Parameters.AddWithValue("@Movil", txtMovil.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);

                int filas = cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                if (filas > 0)
                {
                    MessageBox.Show("Registro modificado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el contacto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Contactos WHERE Nombre=@Nombre",
                    conexion.AbrirConexion());

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);

                int filas = cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                if (filas > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el contacto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtMovil.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            cmbGenero.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;

            dtpFechaNacimiento.Value = DateTime.Now;

            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Desea salir de la aplicación?",
        "Confirmar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    

}
