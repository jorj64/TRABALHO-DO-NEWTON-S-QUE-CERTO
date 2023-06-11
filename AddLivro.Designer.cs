namespace Login
{
    partial class AddLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLivro));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txtData = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtCategoria = new TextBox();
            txtEditora = new TextBox();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 431);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(273, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 80);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 29);
            label1.TabIndex = 1;
            label1.Text = "Adicionar Livro";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(txtData);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtCategoria);
            panel2.Controls.Add(txtEditora);
            panel2.Controls.Add(txtAutor);
            panel2.Controls.Add(txtTitulo);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(273, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 351);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Location = new Point(163, 160);
            txtData.Name = "txtData";
            txtData.Size = new Size(222, 27);
            txtData.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(310, 287);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 31);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(229, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 31);
            btnSave.TabIndex = 11;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoria.Location = new Point(164, 202);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(221, 27);
            txtCategoria.TabIndex = 9;
            // 
            // txtEditora
            // 
            txtEditora.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEditora.Location = new Point(164, 114);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(221, 27);
            txtEditora.TabIndex = 7;
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutor.Location = new Point(164, 73);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(221, 27);
            txtAutor.TabIndex = 6;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(164, 36);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(221, 27);
            txtTitulo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 205);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 4;
            label6.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 161);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 3;
            label5.Text = "Ano de Publicação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 117);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 2;
            label4.Text = "Editora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 1;
            label3.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 0;
            label2.Text = "Título";
            // 
            // AddLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 428);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddLivro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddLivro";
            Load += AddLivro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCategoria;
        private TextBox txtEditora;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtData;
    }
}