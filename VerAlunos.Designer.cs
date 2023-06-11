namespace Login
{
    partial class VerAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerAlunos));
            panel1 = new Panel();
            txtVer = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtSearchE = new TextBox();
            btnRefresh = new Button();
            panel2 = new Panel();
            txtNtelefone = new TextBox();
            btnCnl = new Button();
            btnDlt = new Button();
            btnAtt = new Button();
            txtNendereço = new TextBox();
            txtNmatrícula = new TextBox();
            txtNnome = new TextBox();
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
            panel1.Controls.Add(txtVer);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 143);
            panel1.TabIndex = 0;
            // 
            // txtVer
            // 
            txtVer.AutoSize = true;
            txtVer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtVer.ForeColor = SystemColors.Highlight;
            txtVer.Location = new Point(540, 31);
            txtVer.Name = "txtVer";
            txtVer.Size = new Size(51, 32);
            txtVer.TabIndex = 2;
            txtVer.Text = "Ver";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(532, 63);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 1;
            label1.Text = " Alunos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(358, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(979, 252);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(253, 149);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Matrícula";
            label2.Click += label2_Click;
            // 
            // txtSearchE
            // 
            txtSearchE.Location = new Point(355, 151);
            txtSearchE.Name = "txtSearchE";
            txtSearchE.Size = new Size(229, 23);
            txtSearchE.TabIndex = 3;
            txtSearchE.TextChanged += txtSearchE_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(608, 151);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Limpar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(txtNtelefone);
            panel2.Controls.Add(btnCnl);
            panel2.Controls.Add(btnDlt);
            panel2.Controls.Add(btnAtt);
            panel2.Controls.Add(txtNendereço);
            panel2.Controls.Add(txtNmatrícula);
            panel2.Controls.Add(txtNnome);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-1, 501);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 353);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // txtNtelefone
            // 
            txtNtelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNtelefone.Location = new Point(596, 116);
            txtNtelefone.Name = "txtNtelefone";
            txtNtelefone.Size = new Size(200, 25);
            txtNtelefone.TabIndex = 22;
            // 
            // btnCnl
            // 
            btnCnl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCnl.Location = new Point(721, 255);
            btnCnl.Name = "btnCnl";
            btnCnl.Size = new Size(75, 31);
            btnCnl.TabIndex = 21;
            btnCnl.Text = "Cancelar";
            btnCnl.UseVisualStyleBackColor = true;
            btnCnl.Click += btnCnl_Click;
            // 
            // btnDlt
            // 
            btnDlt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDlt.Location = new Point(640, 255);
            btnDlt.Name = "btnDlt";
            btnDlt.Size = new Size(75, 31);
            btnDlt.TabIndex = 20;
            btnDlt.Text = "Apagar";
            btnDlt.UseVisualStyleBackColor = true;
            btnDlt.Click += btnDlt_Click;
            // 
            // btnAtt
            // 
            btnAtt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtt.Location = new Point(559, 255);
            btnAtt.Name = "btnAtt";
            btnAtt.Size = new Size(75, 31);
            btnAtt.TabIndex = 19;
            btnAtt.Text = "Atualizar";
            btnAtt.UseVisualStyleBackColor = true;
            btnAtt.Click += btnAtt_Click;
            // 
            // txtNendereço
            // 
            txtNendereço.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNendereço.Location = new Point(596, 79);
            txtNendereço.Name = "txtNendereço";
            txtNendereço.Size = new Size(200, 25);
            txtNendereço.TabIndex = 18;
            // 
            // txtNmatrícula
            // 
            txtNmatrícula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNmatrícula.Location = new Point(254, 116);
            txtNmatrícula.Name = "txtNmatrícula";
            txtNmatrícula.Size = new Size(200, 25);
            txtNmatrícula.TabIndex = 17;
            // 
            // txtNnome
            // 
            txtNnome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNnome.Location = new Point(254, 79);
            txtNnome.Name = "txtNnome";
            txtNnome.Size = new Size(200, 25);
            txtNnome.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(496, 116);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 15;
            label6.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(496, 79);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 14;
            label5.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(165, 120);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 13;
            label4.Text = "Matrícula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(165, 79);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 12;
            label3.Text = "Nome";
            // 
            // VerAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(977, 408);
            Controls.Add(panel2);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchE);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "VerAlunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerAlunos";
            Load += VerAlunos_Load;
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
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtSearchE;
        private Button btnRefresh;
        private Panel panel2;
        private TextBox txtNtelefone;
        private Button btnCnl;
        private Button btnDlt;
        private Button btnAtt;
        private TextBox txtNendereço;
        private TextBox txtNmatrícula;
        private TextBox txtNnome;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label txtVer;
    }
}