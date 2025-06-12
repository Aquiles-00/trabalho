namespace Trabalho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnentrar = new Button();
            txtlogin = new TextBox();
            txtsenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnentrar
            // 
            btnentrar.Location = new Point(63, 298);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(145, 46);
            btnentrar.TabIndex = 0;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = true;
            btnentrar.Click += btnsalvar_Click;
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(63, 100);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(145, 27);
            txtlogin.TabIndex = 1;
            txtlogin.TextChanged += txtlogin_TextChanged;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(63, 188);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(145, 27);
            txtsenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 62);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 151);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 419);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsenha);
            Controls.Add(txtlogin);
            Controls.Add(btnentrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnentrar;
        private TextBox txtlogin;
        private TextBox txtsenha;
        private Label label1;
        private Label label2;
    }
}
