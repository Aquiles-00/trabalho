using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        private string Login = "C:/Users/aquil/OneDrive/Documentos/login.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string usuarioDigitado = txtlogin.Text.Trim();
            string senhaDigitada = txtsenha.Text.Trim();

            if (usuarioDigitado == "admin" && senhaDigitada == "123")
            {
                MessageBox.Show("Login realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmprinc telaPrincipal = new frmprinc();
                telaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
