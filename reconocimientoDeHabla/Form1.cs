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

namespace reconocimientoDeHabla
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine oEscucha = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            oEscucha.SetInputToDefaultAudioDevice();
            oEscucha
        }
    }
}
