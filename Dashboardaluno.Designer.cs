namespace Login
{
    partial class Dashboardaluno
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
            menuStrip1 = new MenuStrip();
            verLivrosToolStripMenuItem = new ToolStripMenuItem();
            emitirLivrosToolStripMenuItem = new ToolStripMenuItem();
            devoverLivrosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Items.AddRange(new ToolStripItem[] { verLivrosToolStripMenuItem, emitirLivrosToolStripMenuItem, devoverLivrosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // verLivrosToolStripMenuItem
            // 
            verLivrosToolStripMenuItem.Image = Properties.Resources.icons8_view_50;
            verLivrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            verLivrosToolStripMenuItem.Name = "verLivrosToolStripMenuItem";
            verLivrosToolStripMenuItem.Size = new Size(119, 54);
            verLivrosToolStripMenuItem.Text = "Ver Livros";
            verLivrosToolStripMenuItem.Click += verLivrosToolStripMenuItem_Click;
            // 
            // emitirLivrosToolStripMenuItem
            // 
            emitirLivrosToolStripMenuItem.BackColor = Color.OldLace;
            emitirLivrosToolStripMenuItem.Image = Properties.Resources.icons8_book_philosophy_50;
            emitirLivrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            emitirLivrosToolStripMenuItem.Name = "emitirLivrosToolStripMenuItem";
            emitirLivrosToolStripMenuItem.Size = new Size(134, 54);
            emitirLivrosToolStripMenuItem.Text = "Emitir Livros";
            emitirLivrosToolStripMenuItem.Click += emitirLivrosToolStripMenuItem_Click;
            // 
            // devoverLivrosToolStripMenuItem
            // 
            devoverLivrosToolStripMenuItem.Image = Properties.Resources.icons8_return_book_50;
            devoverLivrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            devoverLivrosToolStripMenuItem.Name = "devoverLivrosToolStripMenuItem";
            devoverLivrosToolStripMenuItem.Size = new Size(146, 54);
            devoverLivrosToolStripMenuItem.Text = "Devover Livros";
            devoverLivrosToolStripMenuItem.Click += devoverLivrosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.OldLace;
            sairToolStripMenuItem.Image = Properties.Resources.icons8_exit_sign_50;
            sairToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(88, 54);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Dashboardaluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.books_library_shelves_138556_1920x1080;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboardaluno";
            Text = "Dashboardaluno";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem verLivrosToolStripMenuItem;
        private ToolStripMenuItem emitirLivrosToolStripMenuItem;
        private ToolStripMenuItem devoverLivrosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}