namespace Login
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            livrosToolStripMenuItem = new ToolStripMenuItem();
            adicionarLivroToolStripMenuItem = new ToolStripMenuItem();
            verLivroToolStripMenuItem = new ToolStripMenuItem();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            adicionarNovoAlunoToolStripMenuItem = new ToolStripMenuItem();
            verAlunosToolStripMenuItem = new ToolStripMenuItem();
            emitirLivrosToolStripMenuItem = new ToolStripMenuItem();
            devolverLivrosToolStripMenuItem = new ToolStripMenuItem();
            informaçõesDosLivrosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Items.AddRange(new ToolStripItem[] { livrosToolStripMenuItem, alunosToolStripMenuItem, emitirLivrosToolStripMenuItem, devolverLivrosToolStripMenuItem, informaçõesDosLivrosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1063, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // livrosToolStripMenuItem
            // 
            livrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarLivroToolStripMenuItem, verLivroToolStripMenuItem });
            livrosToolStripMenuItem.Image = (Image)resources.GetObject("livrosToolStripMenuItem.Image");
            livrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            livrosToolStripMenuItem.Size = new Size(100, 54);
            livrosToolStripMenuItem.Text = "Livros";
            // 
            // adicionarLivroToolStripMenuItem
            // 
            adicionarLivroToolStripMenuItem.Image = (Image)resources.GetObject("adicionarLivroToolStripMenuItem.Image");
            adicionarLivroToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            adicionarLivroToolStripMenuItem.Name = "adicionarLivroToolStripMenuItem";
            adicionarLivroToolStripMenuItem.Size = new Size(185, 56);
            adicionarLivroToolStripMenuItem.Text = "Adiconar Livro";
            adicionarLivroToolStripMenuItem.Click += adicionarLivroToolStripMenuItem_Click;
            // 
            // verLivroToolStripMenuItem
            // 
            verLivroToolStripMenuItem.Image = (Image)resources.GetObject("verLivroToolStripMenuItem.Image");
            verLivroToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            verLivroToolStripMenuItem.Name = "verLivroToolStripMenuItem";
            verLivroToolStripMenuItem.Size = new Size(185, 56);
            verLivroToolStripMenuItem.Text = "Ver Livros";
            verLivroToolStripMenuItem.Click += verLivroToolStripMenuItem_Click;
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.BackColor = Color.OldLace;
            alunosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarNovoAlunoToolStripMenuItem, verAlunosToolStripMenuItem });
            alunosToolStripMenuItem.Image = (Image)resources.GetObject("alunosToolStripMenuItem.Image");
            alunosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(106, 54);
            alunosToolStripMenuItem.Text = "Alunos";
            // 
            // adicionarNovoAlunoToolStripMenuItem
            // 
            adicionarNovoAlunoToolStripMenuItem.Image = (Image)resources.GetObject("adicionarNovoAlunoToolStripMenuItem.Image");
            adicionarNovoAlunoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            adicionarNovoAlunoToolStripMenuItem.Name = "adicionarNovoAlunoToolStripMenuItem";
            adicionarNovoAlunoToolStripMenuItem.Size = new Size(226, 56);
            adicionarNovoAlunoToolStripMenuItem.Text = "Adicionar Novo Aluno";
            adicionarNovoAlunoToolStripMenuItem.Click += adicionarNovoAlunoToolStripMenuItem_Click;
            // 
            // verAlunosToolStripMenuItem
            // 
            verAlunosToolStripMenuItem.Image = (Image)resources.GetObject("verAlunosToolStripMenuItem.Image");
            verAlunosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            verAlunosToolStripMenuItem.Name = "verAlunosToolStripMenuItem";
            verAlunosToolStripMenuItem.Size = new Size(226, 56);
            verAlunosToolStripMenuItem.Text = "Ver Alunos";
            verAlunosToolStripMenuItem.Click += verAlunosToolStripMenuItem_Click;
            // 
            // emitirLivrosToolStripMenuItem
            // 
            emitirLivrosToolStripMenuItem.Image = (Image)resources.GetObject("emitirLivrosToolStripMenuItem.Image");
            emitirLivrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            emitirLivrosToolStripMenuItem.Name = "emitirLivrosToolStripMenuItem";
            emitirLivrosToolStripMenuItem.Size = new Size(134, 54);
            emitirLivrosToolStripMenuItem.Text = "Emitir Livros";
            // 
            // devolverLivrosToolStripMenuItem
            // 
            devolverLivrosToolStripMenuItem.BackColor = Color.OldLace;
            devolverLivrosToolStripMenuItem.Image = (Image)resources.GetObject("devolverLivrosToolStripMenuItem.Image");
            devolverLivrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            devolverLivrosToolStripMenuItem.Name = "devolverLivrosToolStripMenuItem";
            devolverLivrosToolStripMenuItem.Size = new Size(149, 54);
            devolverLivrosToolStripMenuItem.Text = "Devolver Livros";
            // 
            // informaçõesDosLivrosToolStripMenuItem
            // 
            informaçõesDosLivrosToolStripMenuItem.Image = (Image)resources.GetObject("informaçõesDosLivrosToolStripMenuItem.Image");
            informaçõesDosLivrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            informaçõesDosLivrosToolStripMenuItem.Name = "informaçõesDosLivrosToolStripMenuItem";
            informaçõesDosLivrosToolStripMenuItem.Size = new Size(191, 54);
            informaçõesDosLivrosToolStripMenuItem.Text = "Informações dos Livros";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.OldLace;
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(88, 54);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1063, 534);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem livrosToolStripMenuItem;
        private ToolStripMenuItem adicionarLivroToolStripMenuItem;
        private ToolStripMenuItem verLivroToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem adicionarNovoAlunoToolStripMenuItem;
        private ToolStripMenuItem verAlunosToolStripMenuItem;
        private ToolStripMenuItem emitirLivrosToolStripMenuItem;
        private ToolStripMenuItem devolverLivrosToolStripMenuItem;
        private ToolStripMenuItem informaçõesDosLivrosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}