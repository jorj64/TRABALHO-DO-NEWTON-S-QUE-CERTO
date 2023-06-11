namespace Login
{
    partial class Emprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emprestimo));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtEndereço = new TextBox();
            label7 = new Label();
            txtTelefone = new TextBox();
            label6 = new Label();
            ComboBoxLivro = new ComboBox();
            btnEfetuar = new Button();
            DataTimePicker = new DateTimePicker();
            txtNome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btnExit = new Button();
            btnLimp = new Button();
            btnProcurar = new Button();
            txtMatrícula = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 135);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(445, 64);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 1;
            label1.Text = "Empréstimo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(txtEndereço);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtTelefone);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ComboBoxLivro);
            panel2.Controls.Add(btnEfetuar);
            panel2.Controls.Add(DataTimePicker);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(272, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 406);
            panel2.TabIndex = 1;
            // 
            // txtEndereço
            // 
            txtEndereço.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereço.Location = new Point(211, 117);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.ReadOnly = true;
            txtEndereço.Size = new Size(200, 25);
            txtEndereço.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(11, 121);
            label7.Name = "label7";
            label7.Size = new Size(155, 21);
            label7.TabIndex = 12;
            label7.Text = "Endereço do Aluno";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(211, 81);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.ReadOnly = true;
            txtTelefone.Size = new Size(200, 25);
            txtTelefone.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 85);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 10;
            label6.Text = "Telefone do Aluno";
            // 
            // ComboBoxLivro
            // 
            ComboBoxLivro.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxLivro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxLivro.FormattingEnabled = true;
            ComboBoxLivro.Location = new Point(211, 155);
            ComboBoxLivro.Name = "ComboBoxLivro";
            ComboBoxLivro.Size = new Size(200, 25);
            ComboBoxLivro.TabIndex = 9;
            ComboBoxLivro.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnEfetuar
            // 
            btnEfetuar.FlatStyle = FlatStyle.Popup;
            btnEfetuar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEfetuar.Location = new Point(280, 257);
            btnEfetuar.Name = "btnEfetuar";
            btnEfetuar.Size = new Size(131, 43);
            btnEfetuar.TabIndex = 8;
            btnEfetuar.Text = "Efetuar Empréstimo";
            btnEfetuar.UseVisualStyleBackColor = true;
            btnEfetuar.Click += btnEfetuar_Click;
            // 
            // DataTimePicker
            // 
            DataTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DataTimePicker.Location = new Point(211, 190);
            DataTimePicker.Name = "DataTimePicker";
            DataTimePicker.Size = new Size(200, 25);
            DataTimePicker.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(211, 45);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(200, 25);
            txtNome.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 194);
            label5.Name = "label5";
            label5.Size = new Size(165, 21);
            label5.TabIndex = 2;
            label5.Text = "Data de Empréstimo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 159);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 1;
            label4.Text = "Nome do Livro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 49);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 0;
            label3.Text = "Nome do Aluno";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnLimp);
            panel3.Controls.Add(btnProcurar);
            panel3.Controls.Add(txtMatrícula);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(-2, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(277, 406);
            panel3.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(166, 318);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(79, 33);
            btnExit.TabIndex = 5;
            btnExit.Text = "Sair";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button3_Click;
            // 
            // btnLimp
            // 
            btnLimp.FlatStyle = FlatStyle.Popup;
            btnLimp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimp.Location = new Point(19, 318);
            btnLimp.Name = "btnLimp";
            btnLimp.Size = new Size(89, 33);
            btnLimp.TabIndex = 4;
            btnLimp.Text = "Limpar";
            btnLimp.UseVisualStyleBackColor = true;
            btnLimp.Click += btnLimp_Click;
            // 
            // btnProcurar
            // 
            btnProcurar.FlatStyle = FlatStyle.Popup;
            btnProcurar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcurar.Location = new Point(61, 228);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(151, 47);
            btnProcurar.TabIndex = 3;
            btnProcurar.Text = "Procurar Aluno";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // txtMatrícula
            // 
            txtMatrícula.Location = new Point(19, 188);
            txtMatrícula.Name = "txtMatrícula";
            txtMatrícula.Size = new Size(226, 23);
            txtMatrícula.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 153);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 1;
            label2.Text = "Matrícula do Aluno";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(85, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Emprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 125);
            ClientSize = new Size(723, 539);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emprestimo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emprestimo";
            Load += Emprestimo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnExit;
        private Button btnLimp;
        private Button btnProcurar;
        private TextBox txtMatrícula;
        private Label label2;
        private Button btnEfetuar;
        private DateTimePicker DataTimePicker;
        private TextBox txtNome;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox ComboBoxLivro;
        private TextBox txtTelefone;
        private Label label6;
        private TextBox txtEndereço;
        private Label label7;
    }
}