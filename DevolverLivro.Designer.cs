namespace Login
{
    partial class DevolverLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolverLivro));
            panel3 = new Panel();
            btnExit = new Button();
            btnLimp = new Button();
            btnProcurar = new Button();
            txtAluno = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnCncl = new Button();
            btnDevolver = new Button();
            dateTimePicker = new DateTimePicker();
            txtEmissao = new TextBox();
            txtLivro = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnLimp);
            panel3.Controls.Add(btnProcurar);
            panel3.Controls.Add(txtAluno);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 406);
            panel3.TabIndex = 1;
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
            btnExit.Click += btnExit_Click;
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
            // txtAluno
            // 
            txtAluno.Location = new Point(19, 188);
            txtAluno.Name = "txtAluno";
            txtAluno.Size = new Size(226, 23);
            txtAluno.TabIndex = 2;
            txtAluno.TextChanged += txtAluno_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 153);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 1;
            label2.Text = "Nome do Aluno";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(283, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(713, 406);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(btnCncl);
            panel1.Controls.Add(btnDevolver);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(txtEmissao);
            panel1.Controls.Add(txtLivro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 437);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 164);
            panel1.TabIndex = 3;
            // 
            // btnCncl
            // 
            btnCncl.FlatStyle = FlatStyle.Popup;
            btnCncl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCncl.Location = new Point(616, 108);
            btnCncl.Name = "btnCncl";
            btnCncl.Size = new Size(89, 33);
            btnCncl.TabIndex = 7;
            btnCncl.Text = "Cancelar";
            btnCncl.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            btnDevolver.FlatStyle = FlatStyle.Popup;
            btnDevolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDevolver.Location = new Point(521, 108);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(89, 33);
            btnDevolver.TabIndex = 6;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Location = new Point(231, 103);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(216, 25);
            dateTimePicker.TabIndex = 5;
            // 
            // txtEmissao
            // 
            txtEmissao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmissao.Location = new Point(231, 64);
            txtEmissao.Name = "txtEmissao";
            txtEmissao.Size = new Size(216, 25);
            txtEmissao.TabIndex = 4;
            // 
            // txtLivro
            // 
            txtLivro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLivro.Location = new Point(231, 25);
            txtLivro.Name = "txtLivro";
            txtLivro.Size = new Size(216, 25);
            txtLivro.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(76, 108);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 2;
            label4.Text = "Data de Devolução";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(76, 69);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 1;
            label3.Text = "Data de Emissão";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome do Livro";
            // 
            // DevolverLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1000, 461);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DevolverLivro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DevolverLivro";
            Load += DevolverLivro_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnExit;
        private Button btnLimp;
        private Button btnProcurar;
        private TextBox txtAluno;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private DateTimePicker dateTimePicker;
        private TextBox txtEmissao;
        private TextBox txtLivro;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnCncl;
        private Button btnDevolver;
    }
}