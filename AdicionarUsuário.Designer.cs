namespace Login
{
    partial class AdicionarUsuário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarUsuário));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnLimp = new Button();
            txtMatrícula = new TextBox();
            txtEndereço = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            NTelefone = new Label();
            NEndereço = new Label();
            NMatricula = new Label();
            NAluno = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 84);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(344, 30);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 1;
            label1.Text = "Adicionar Aluno";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(264, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnLimp);
            panel2.Controls.Add(txtMatrícula);
            panel2.Controls.Add(txtEndereço);
            panel2.Controls.Add(txtTelefone);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(NTelefone);
            panel2.Controls.Add(NEndereço);
            panel2.Controls.Add(NMatricula);
            panel2.Controls.Add(NAluno);
            panel2.Location = new Point(264, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 347);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(333, 260);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Sair";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(252, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLimp
            // 
            btnLimp.FlatStyle = FlatStyle.Popup;
            btnLimp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimp.Location = new Point(171, 260);
            btnLimp.Name = "btnLimp";
            btnLimp.Size = new Size(75, 23);
            btnLimp.TabIndex = 8;
            btnLimp.Text = "Limpar";
            btnLimp.UseVisualStyleBackColor = true;
            btnLimp.Click += btnLimp_Click;
            // 
            // txtMatrícula
            // 
            txtMatrícula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatrícula.Location = new Point(134, 86);
            txtMatrícula.Name = "txtMatrícula";
            txtMatrícula.Size = new Size(221, 25);
            txtMatrícula.TabIndex = 7;
            // 
            // txtEndereço
            // 
            txtEndereço.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereço.Location = new Point(134, 124);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(221, 25);
            txtEndereço.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(134, 168);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(221, 25);
            txtTelefone.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(134, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(221, 25);
            txtNome.TabIndex = 4;
            // 
            // NTelefone
            // 
            NTelefone.AutoSize = true;
            NTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NTelefone.Location = new Point(37, 170);
            NTelefone.Name = "NTelefone";
            NTelefone.Size = new Size(76, 21);
            NTelefone.TabIndex = 3;
            NTelefone.Text = "Telefone";
            // 
            // NEndereço
            // 
            NEndereço.AutoSize = true;
            NEndereço.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NEndereço.Location = new Point(37, 126);
            NEndereço.Name = "NEndereço";
            NEndereço.Size = new Size(81, 21);
            NEndereço.TabIndex = 2;
            NEndereço.Text = "Endereço";
            // 
            // NMatricula
            // 
            NMatricula.AutoSize = true;
            NMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NMatricula.Location = new Point(37, 88);
            NMatricula.Name = "NMatricula";
            NMatricula.Size = new Size(83, 21);
            NMatricula.TabIndex = 1;
            NMatricula.Text = "Matrícula";
            // 
            // NAluno
            // 
            NAluno.AutoSize = true;
            NAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NAluno.Location = new Point(37, 46);
            NAluno.Name = "NAluno";
            NAluno.Size = new Size(57, 21);
            NAluno.TabIndex = 0;
            NAluno.Text = "Nome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 429);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AdicionarUsuário
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 428);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdicionarUsuário";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdicionarUsuário";
            Load += AdicionarUsuário_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnSave;
        private Button btnLimp;
        private TextBox txtMatrícula;
        private TextBox txtEndereço;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private Label NTelefone;
        private Label NEndereço;
        private Label NMatricula;
        private Label NAluno;
    }
}