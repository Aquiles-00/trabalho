namespace Trabalho
{
    partial class frmcad_produto
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtdesc = new TextBox();
            txtpreco = new TextBox();
            txtnomep = new TextBox();
            dgvprod = new DataGridView();
            btnsalvar = new Button();
            button2 = new Button();
            button3 = new Button();
            btnbuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvprod).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 27);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 33;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 30);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 32;
            label2.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 31;
            label1.Text = "Nome do produto";
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(363, 63);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(259, 27);
            txtdesc.TabIndex = 29;
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(188, 63);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(125, 27);
            txtpreco.TabIndex = 27;
            // 
            // txtnomep
            // 
            txtnomep.Location = new Point(32, 63);
            txtnomep.Name = "txtnomep";
            txtnomep.Size = new Size(125, 27);
            txtnomep.TabIndex = 26;
            // 
            // dgvprod
            // 
            dgvprod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvprod.Location = new Point(32, 192);
            dgvprod.Name = "dgvprod";
            dgvprod.RowHeadersWidth = 51;
            dgvprod.Size = new Size(663, 231);
            dgvprod.TabIndex = 34;
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(32, 126);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(94, 29);
            btnsalvar.TabIndex = 35;
            btnsalvar.Text = "SALVAR";
            btnsalvar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(554, 126);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 36;
            button2.Text = "Apagar.";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(154, 126);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 37;
            button3.Text = "Atualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(277, 126);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 38;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // frmcad_produto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(btnbuscar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnsalvar);
            Controls.Add(dgvprod);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtdesc);
            Controls.Add(txtpreco);
            Controls.Add(txtnomep);
            Name = "frmcad_produto";
            Text = "frmcad_produto";
            ((System.ComponentModel.ISupportInitialize)dgvprod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtdesc;
        private TextBox txtpreco;
        private TextBox txtnomep;
        private DataGridView dgvprod;
        private Button btnsalvar;
        private Button button2;
        private Button button3;
        private Button btnbuscar;
    }
}