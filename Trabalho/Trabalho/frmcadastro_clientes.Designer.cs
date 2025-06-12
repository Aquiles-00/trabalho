namespace Trabalho
{
    partial class frmcadastro_clientes
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
            txtcpf = new TextBox();
            txtnome = new TextBox();
            label6 = new Label();
            txtemail = new TextBox();
            txtend = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtzapzap = new TextBox();
            txttel = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 23);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 18;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 17;
            label1.Text = "nome";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(182, 56);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(125, 27);
            txtcpf.TabIndex = 13;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(26, 56);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(125, 27);
            txtnome.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 99);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 23;
            label6.Text = "WhatsApp";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(323, 56);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(125, 27);
            txtemail.TabIndex = 15;
            // 
            // txtend
            // 
            txtend.Location = new Point(479, 56);
            txtend.Name = "txtend";
            txtend.Size = new Size(125, 27);
            txtend.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 20);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 19;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 20);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 20;
            label4.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 99);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 21;
            label5.Text = "Telefone";
            // 
            // txtzapzap
            // 
            txtzapzap.Location = new Point(182, 135);
            txtzapzap.Name = "txtzapzap";
            txtzapzap.Size = new Size(124, 27);
            txtzapzap.TabIndex = 22;
            // 
            // txttel
            // 
            txttel.Location = new Point(26, 135);
            txttel.Name = "txttel";
            txttel.Size = new Size(125, 27);
            txttel.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(662, 188);
            dataGridView1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(367, 120);
            button1.Name = "button1";
            button1.Size = new Size(126, 57);
            button1.TabIndex = 25;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmcadastro_clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(txtzapzap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtend);
            Controls.Add(txtemail);
            Controls.Add(txttel);
            Controls.Add(txtcpf);
            Controls.Add(txtnome);
            Name = "frmcadastro_clientes";
            Text = "frmcadastro_clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtcpf;
        private TextBox txtnome;
        private Label label6;
        private TextBox txtemail;
        private TextBox txtend;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtzapzap;
        private TextBox txttel;
        private DataGridView dataGridView1;
        private Button button1;
    }
}