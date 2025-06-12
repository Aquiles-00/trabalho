namespace Trabalho
{
    partial class frmprinc
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
            btnuser = new Button();
            btnproduto = new Button();
            btnpedido = new Button();
            btncad = new Button();
            SuspendLayout();
            // 
            // btnuser
            // 
            btnuser.Location = new Point(228, 252);
            btnuser.Name = "btnuser";
            btnuser.Size = new Size(153, 112);
            btnuser.TabIndex = 0;
            btnuser.Text = "Cadastro de Usuários";
            btnuser.UseVisualStyleBackColor = true;
            btnuser.Click += btnuser_Click;
            // 
            // btnproduto
            // 
            btnproduto.Location = new Point(228, 56);
            btnproduto.Name = "btnproduto";
            btnproduto.Size = new Size(153, 112);
            btnproduto.TabIndex = 1;
            btnproduto.Text = "Cadastro de Produtos";
            btnproduto.UseVisualStyleBackColor = true;
            btnproduto.Click += btnproduto_Click;
            // 
            // btnpedido
            // 
            btnpedido.Location = new Point(42, 252);
            btnpedido.Name = "btnpedido";
            btnpedido.Size = new Size(153, 112);
            btnpedido.TabIndex = 2;
            btnpedido.Text = "Cadastro de Pedidos";
            btnpedido.UseVisualStyleBackColor = true;
            btnpedido.Click += btnpedido_Click;
            // 
            // btncad
            // 
            btncad.Location = new Point(42, 56);
            btncad.Name = "btncad";
            btncad.Size = new Size(153, 112);
            btncad.TabIndex = 3;
            btncad.Text = "Cadastro de Clientes";
            btncad.UseVisualStyleBackColor = true;
            btncad.Click += btncad_Click;
            // 
            // frmprinc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(btncad);
            Controls.Add(btnpedido);
            Controls.Add(btnproduto);
            Controls.Add(btnuser);
            Name = "frmprinc";
            Text = "frmprinc";
            ResumeLayout(false);
        }

        #endregion

        private Button btnuser;
        private Button btnproduto;
        private Button btnpedido;
        private Button btncad;
    }
}