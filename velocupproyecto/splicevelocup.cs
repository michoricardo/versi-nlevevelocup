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
    public partial class splicevelocup : Form
    {
        Point formPosition;
        Boolean mouseAction;
        PictureBox[] circulitos; //declaro un picture box vacío
        int cuentacirculos = 0; //declaro el contador de circulos en cero

        public splicevelocup()
        {
            InitializeComponent();
        }

        private void splicevelocup_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void splicevelocup_MouseDown(object sender, MouseEventArgs e)
        {
            
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;

        }

        private void splicevelocup_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cuentacirculos < 5)
            {
                circulitos[cuentacirculos].BackgroundImage = velocupproyecto.Properties.Resources.Circle2;
                cuentacirculos++;
                labelcarga.Text= " Cargando al " + cuentacirculos * 20 + "% ";


            }
            else
            {
                timer1.Enabled = false; //desactivo el timer si ya cuentacirculos ya contó los 5 circulitos
                MessageBox.Show("La carga ya está completa");
                this.Close();
            }
        }

        private void splicevelocup_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // empieza a contar el timer desde que se carga la forma
            circulitos = new PictureBox[5] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            //Doy de alta un nuevo picturebox con 5 picturebox adentro (osea como una matriz)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splicevelocup_FormClosing(object sender, FormClosingEventArgs e)
        {
            principalvelo princi = new principalvelo();
            princi.Show();
        }

        private void labelversion_Click(object sender, EventArgs e)
        {

        }
    }
}
