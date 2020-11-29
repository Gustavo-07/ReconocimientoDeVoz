using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace reconocimientoDeHabla
{
    public partial class CtrlConsultar : UserControl
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=RICKY330;Initial Catalog=Biblioteca;Integrated Security=True");
        SpeechRecognitionEngine oEscucha = new SpeechRecognitionEngine();
        public CtrlConsultar()
        {
            InitializeComponent();
        }

        private void CtrlConsultar_Load(object sender, EventArgs e)
        {

        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            oEscucha.RecognizeAsyncStop();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            oEscucha.SetInputToDefaultAudioDevice();
            oEscucha.LoadGrammar(new DictationGrammar());
            oEscucha.SpeechRecognized += Deteccion;
            oEscucha.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Deteccion(object sender, SpeechRecognizedEventArgs s)
        {
            txtTexto.Text = s.Result.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM libros where titulo like ('" + txtTexto.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            DtgLibros.DataSource = dt;

            conexion.Close();
        }
    }
}
