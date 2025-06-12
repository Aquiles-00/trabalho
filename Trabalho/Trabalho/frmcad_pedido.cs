using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class frmcad_pedido : Form
    {
        private string pedidocompleto = "C:/Users/aquil/OneDrive/Documentos/dadosproduto.CSV";
        private int indiceEdicao = -1;

        public frmcad_pedido()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            if (dgvpedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int RowIndex = dgvpedido.SelectedRows[0].Index;
            var linhas = File.ReadAllLines(pedidocompleto).ToList();


            linhas.RemoveAt(RowIndex + 1); // +1 por causa do cabeçalho
            File.WriteAllLines(pedidocompleto, linhas);
            MessageBox.Show("Registro excluído.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            caminhoListaCSV();
        }

        private void frmcad_pedido_Load(object sender, EventArgs e)
        {

        }
        private void caminhoListaCSV()
        {
            try
            {
                DataTable tabela = new DataTable();
                string[] linhas = File.ReadAllLines(pedidocompleto);
                if (linhas.Length > 0)
                {
                    string[] colunas = linhas[0].Split(',');

                    foreach (string coluna in colunas)
                        tabela.Columns.Add(coluna);
                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] dados = linhas[i].Split(',');
                        tabela.Rows.Add(dados);
                    }
                }
                dgvpedido.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SalvarCompleto()
        {
            string nome = txtnome.Text.Trim();
            string CPF = txtcpf.Text.Trim();
            string nomeP = txtnp.Text.Trim();
            string cod = txtcod.Text.Trim();
            string quant = txtquant.Text.Trim();
            string preco = txtpre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(CPF) ||
                string.IsNullOrWhiteSpace(nomeP) || string.IsNullOrWhiteSpace(cod) || string.IsNullOrWhiteSpace(quant) || string.IsNullOrWhiteSpace(preco))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var linhas = File.ReadAllLines(pedidocompleto).ToList();

            int linhaExistente = -1;

            for (int i = 1; i < linhas.Count; i++)
            {
                var dados = linhas[i].Split(',');
                if (dados[1] == CPF)
                {
                    linhaExistente = i;
                    break;
                }
            }

            if (linhaExistente != -1)
            {
                // CPF já existe: editar
                linhas[linhaExistente] = $"{nome},{CPF},{nomeP},{cod},{quant},{preco}";
                MessageBox.Show("Cliente já cadastrado — os dados foram atualizados.", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Novo cadastro
                linhas.Add($"{nome},{CPF},{nomeP},{cod},{quant},{preco}");
                MessageBox.Show("Novo cliente cadastrado com sucesso!", "Criado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            File.WriteAllLines(pedidocompleto, linhas);

            // Resetar formulário
            txtnome.Clear();
            txtcpf.Clear();
            txtnp.Clear();
            txtcod.Clear();
            txtquant.Clear();
            txtpre.Clear();
            btnsalvar.Text = "Salvar";
            indiceEdicao = -1;

            caminhoListaCSV();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            SalvarCompleto();
        }
    }
}

