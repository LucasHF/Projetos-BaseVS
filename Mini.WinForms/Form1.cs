using Mini.Classes;

namespace Mini.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Minificador.Executar(new string[] { "/o=" + Origem.Text, "/d=" + Destino.Text });
        }
    }
}