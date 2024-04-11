using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SistemaInventarioNet.App
{
    public partial class FrmLogin : Form
    {
        private bool draggable;
        private int mouseX;
        private int mouseY;
        string usu = "";
        string pas = "";

        private Conexion mConexion;
        public FrmLogin()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                draggable = true;
                mouseX = Cursor.Position.X - this.Left;
                mouseY = Cursor.Position.Y - this.Top;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (this.txtUsuario.Text == usu)
            {
                if (this.txtContraseña.Text == pas)
                {
                    var frmPrincipal = new FrmIndex();
                    frmPrincipal.Show();
                    this.Hide();

                    frmPrincipal.FormClosing += FrmPrincipal_FormClosing;


                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void FrmPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.txtUsuario.Clear();
            this.txtContraseña.Clear();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            string consulta = "selct * from usuario";
            if (mConexion.getConexion() != null)
            {

                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = mConexion.getConexion();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    usu = mySqlDataReader.GetString("usuario");
                    pas = mySqlDataReader.GetString("contraseña");
                }

            }
            else
            {
                MessageBox.Show("Error al conectar en la base de datos");
            }
        }
    }
}
