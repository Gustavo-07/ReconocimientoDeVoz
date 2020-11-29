using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Runtime.InteropServices;

namespace reconocimientoDeHabla
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine oEscucha = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
        }



        private void BtnDetener_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnRestaurar.Visible = true;
            BtnMaximizar.Visible = false;

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            CtrlConsultar ctrlConsultar = new CtrlConsultar();
            if (!(PanelContenedor.Contains(ctrlConsultar)))
            {
                PanelContenedor.Controls.Add(ctrlConsultar);
                ctrlConsultar.Dock = DockStyle.Fill;
                ctrlConsultar.BringToFront();
            }
            {
                ctrlConsultar.BringToFront();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
