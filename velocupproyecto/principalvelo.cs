using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace velocupproyecto
{
    public partial class principalvelo : Form
    {
        Point formPosition;
        Boolean mouseAction;
        public principalvelo()
        {
            InitializeComponent();
        }

        private void principalvelo_Load(object sender, EventArgs e)
        {
            //para centrar el panel
            //Centrar el Panel
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            //Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            //Int32 alto = ((desktopSize.Height) / 2) - (panel1.Height / 2);
            //Int32 ancho = (+(desktopSize.Width) / 2) - (panel1.Width / 2);

            //panel1.Location = new Point(ancho, alto);
            //Fin central el Panel

            //Mostrar Fecha y Hora
            labelfecha.Text = DateTime.Now.ToLongDateString();
            labelhora.Text = DateTime.Now.ToLongTimeString();

        }

        private void principalvelo_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;

        }

        private void principalvelo_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);

            }

        }

        private void principalvelo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //nada
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            labelhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void botoncerrar_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("¿Seguro que deseas salir?", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                //Pone el Aviso en la parte de arriba
                //Pone el messageboxicon por default (el de information que es un signo de admiración)
                //Pone un botón por default
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botoningresar_Click(object sender, EventArgs e)
        {
            if (textousuario.Text.Trim() == "") //Si deja vacío el campo de texto en el usuario
            {
                MessageBox.Show("Debe ingresar un usuario"); //le deja una notificación
                textousuario.Focus(); //Establece foco de entrada en el label de texto usuario
            }
            else if (textopassword.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una contraseña");
                textopassword.Focus(); //establece foco de entrada en el label de password
            }
            else
            {
                MessageBox.Show("Bienvenido Sr.(a):" + textousuario.Text);
                this.Hide();
                formularioprincipal segunda = new formularioprincipal();
                segunda.Show();

            }
        }

        private void botonminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //El estado del formulario va a ser minimizado
        }

        private void botoningresar_MouseHover(object sender, EventArgs e)
        {
            botoningresar.Size = new Size(70, 60); //Cuando el mouse se posiciona sobre la imagen, esta cambia de (60,52) a (70,60) 
            
        }

        private void botoningresar_MouseLeave(object sender, EventArgs e)
        {
            botoningresar.BackgroundImageLayout = ImageLayout.Stretch; //Cuando el mouse deja de estar sobre la imagen, esta cambia del tamaño grande
                                                                       //y regresa a (60,52)
            botoningresar.Size= new Size(60,52);
        }
    }
}
