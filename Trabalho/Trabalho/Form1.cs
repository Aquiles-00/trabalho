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
            var login = File.ReadAllLines(Login).ToList();
           

        
        
        
        }
    }
}
