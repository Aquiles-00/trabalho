namespace Trabalho
{
    partial class frmcad_pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnome = new TextBox();
            txtcpf = new TextBox();
            txtquant = new TextBox();
            txtnp = new TextBox();
            txtcod = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtpre = new TextBox();
            label6 = new Label();
            dgvpedido = new DataGridView();
            btnsalvar = new Button();
            btnapagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvpedido).BeginInit();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(22, 42);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(125, 27);
            txtnome.TabIndex = 0;
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(178, 42);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(125, 27);
            txtcpf.TabIndex = 1;
            // 
            // txtquant
            // 
            txtquant.Location = new Point(335, 121);
            txtquant.Name = "txtquant";
            txtquant.Size = new Size(88, 27);
            txtquant.TabIndex = 2;
            txtquant.TextChanged += textBox3_TextChanged;
            // 
            // txtnp
            // 
            txtnp.Location = new Point(22, 121);
            txtnp.Name = "txtnp";
            txtnp.Size = new Size(125, 27);
            txtnp.TabIndex = 3;
            // 
            // txtcod
            // 
            txtcod.Location = new Point(178, 121);
            txtcod.Name = "txtcod";
            txtcod.Size = new Size(125, 27);
            txtcod.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 5;
            label1.Text = "nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 9);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 6;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 85);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 7;
            label3.Text = "Nome do produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 85);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 8;
            label4.Text = "Código do produto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 85);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 9;
            label5.Text = "quantidade:";
            // 
            // txtpre
            // 
            txtpre.Location = new Point(450, 121);
            txtpre.Name = "txtpre";
            txtpre.Size = new Size(76, 27);
            txtpre.TabIndex = 10;
            txtpre.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 85);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 11;
            label6.Text = "preço";
            // 
            // dgvpedido
            // 
            dgvpedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpedido.Location = new Point(22, 191);
            dgvpedido.Name = "dgvpedido";
            dgvpedido.RowHeadersWidth = 51;
            dgvpedido.Size = new Size(642, 188);
            dgvpedido.TabIndex = 12;
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(22, 409);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(94, 29);
            btnsalvar.TabIndex = 13;
            btnsalvar.Text = "SALVAR";
            btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btnapagar
            // 
            btnapagar.Location = new Point(570, 409);
            btnapagar.Name = "btnapagar";
            btnapagar.Size = new Size(94, 29);
            btnapagar.TabIndex = 14;
            btnapagar.Text = "APAGAR";
            btnapagar.UseVisualStyleBackColor = true;
            btnapagar.Click += btnapagar_Click;
            // 
            // frmcad_pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 450);
            Controls.Add(btnapagar);
            Controls.Add(btnsalvar);
            Controls.Add(dgvpedido);
            Controls.Add(label6);
            Controls.Add(txtpre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcod);
            Controls.Add(txtnp);
            Controls.Add(txtquant);
            Controls.Add(txtcpf);
            Controls.Add(txtnome);
            Name = "frmcad_pedido";
            Text = "frmcad_pedido";
            Load += frmcad_pedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvpedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnome;
        private TextBox txtcpf;
        private TextBox txtquant;
        private TextBox txtnp;
        private TextBox txtcod;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtpre;
        private Label label6;
        private DataGridView dgvpedido;
        private Button btnsalvar;
        private Button btnapagar;
    }
}