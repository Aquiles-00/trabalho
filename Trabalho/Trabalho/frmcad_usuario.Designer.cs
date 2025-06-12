namespace Trabalho
{
    partial class frmcad_usuario
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
            label2 = new Label();
            label1 = new Label();
            txtsenha = new TextBox();
            txtlogin = new TextBox();
            btnentrar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 146);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 9;
            label2.Text = "Nova Senha.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 57);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 8;
            label1.Text = "Novo Usuario.";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(62, 183);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(145, 27);
            txtsenha.TabIndex = 7;
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(62, 95);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(145, 27);
            txtlogin.TabIndex = 6;
            // 
            // btnentrar
            // 
            btnentrar.Location = new Point(62, 293);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(145, 46);
            btnentrar.TabIndex = 5;
            btnentrar.Text = "Salvar";
            btnentrar.UseVisualStyleBackColor = true;
            // 
            // frmcad_usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsenha);
            Controls.Add(txtlogin);
            Controls.Add(btnentrar);
            Name = "frmcad_usuario";
            Text = "frmcad_usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtsenha;
        private TextBox txtlogin;
        private Button btnentrar;
    }
}