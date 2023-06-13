namespace Login
{
    partial class VerLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerLivros));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtBookName = new TextBox();
            BtnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtNPublicação = new TextBox();
            btnCnl = new Button();
            btnDlt = new Button();
            btnAtt = new Button();
            txtNEditora = new TextBox();
            txtNAutor = new TextBox();
            txtNLivro = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 134);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(543, 53);
            label1.Name = "label1";
            label1.Size = new Size(224, 30);
            label1.TabIndex = 1;
            label1.Text = "Livros Adicionados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, -39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(208, 144);
            label2.Name = "label2";
            label2.Size = new Size(141, 24);
            label2.TabIndex = 1;
            label2.Text = "Nome do livro";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookName.Location = new Point(355, 146);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(227, 25);
            txtBookName.TabIndex = 2;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // BtnRefresh
            // 
            BtnRefresh.FlatStyle = FlatStyle.Popup;
            BtnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRefresh.Location = new Point(588, 146);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(91, 24);
            BtnRefresh.TabIndex = 3;
            BtnRefresh.Text = "Limpar";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(967, 320);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(txtNPublicação);
            panel2.Controls.Add(btnCnl);
            panel2.Controls.Add(btnDlt);
            panel2.Controls.Add(btnAtt);
            panel2.Controls.Add(txtNEditora);
            panel2.Controls.Add(txtNAutor);
            panel2.Controls.Add(txtNLivro);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 503);
            panel2.Name = "panel2";
            panel2.Size = new Size(967, 284);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // txtNPublicação
            // 
            txtNPublicação.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNPublicação.Location = new Point(592, 85);
            txtNPublicação.Name = "txtNPublicação";
            txtNPublicação.Size = new Size(200, 25);
            txtNPublicação.TabIndex = 11;
            // 
            // btnCnl
            // 
            btnCnl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCnl.Location = new Point(717, 224);
            btnCnl.Name = "btnCnl";
            btnCnl.Size = new Size(75, 31);
            btnCnl.TabIndex = 10;
            btnCnl.Text = "Cancelar";
            btnCnl.UseVisualStyleBackColor = true;
            btnCnl.Click += btnCnl_Click;
            // 
            // btnDlt
            // 
            btnDlt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDlt.Location = new Point(636, 224);
            btnDlt.Name = "btnDlt";
            btnDlt.Size = new Size(75, 31);
            btnDlt.TabIndex = 9;
            btnDlt.Text = "Apagar";
            btnDlt.UseVisualStyleBackColor = true;
            btnDlt.Click += btnDlt_Click;
            // 
            // btnAtt
            // 
            btnAtt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtt.Location = new Point(555, 224);
            btnAtt.Name = "btnAtt";
            btnAtt.Size = new Size(75, 31);
            btnAtt.TabIndex = 8;
            btnAtt.Text = "Atualizar";
            btnAtt.UseVisualStyleBackColor = true;
            btnAtt.Click += btnAtt_Click;
            // 
            // txtNEditora
            // 
            txtNEditora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNEditora.Location = new Point(592, 48);
            txtNEditora.Name = "txtNEditora";
            txtNEditora.Size = new Size(200, 25);
            txtNEditora.TabIndex = 7;
            // 
            // txtNAutor
            // 
            txtNAutor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNAutor.Location = new Point(250, 85);
            txtNAutor.Name = "txtNAutor";
            txtNAutor.Size = new Size(200, 25);
            txtNAutor.TabIndex = 6;
            // 
            // txtNLivro
            // 
            txtNLivro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNLivro.Location = new Point(250, 48);
            txtNLivro.Name = "txtNLivro";
            txtNLivro.Size = new Size(200, 25);
            txtNLivro.TabIndex = 4;
            txtNLivro.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(492, 85);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 3;
            label6.Text = "Publicação";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(492, 48);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 2;
            label5.Text = "Editora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(196, 85);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 1;
            label4.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 48);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 0;
            label3.Text = "Livro";
            // 
            // VerLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(997, 535);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(BtnRefresh);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "VerLivros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerLivros";
            Load += VerLivros_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtBookName;
        private Button BtnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox txtNLivro;
        private Button btnCnl;
        private Button btnDlt;
        private Button btnAtt;
        private TextBox txtNEditora;
        private TextBox txtNAutor;
        private TextBox txtNPublicação;
    }
}