namespace notepad
{
    partial class frmPrincipal
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
            this.txttexto = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuquebraDeLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.font = new System.Windows.Forms.FontDialog();
            this.load = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttexto
            // 
            this.txttexto.AcceptsTab = true;
            this.txttexto.BackColor = System.Drawing.SystemColors.Window;
            this.txttexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttexto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttexto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txttexto.Location = new System.Drawing.Point(1, 24);
            this.txttexto.Margin = new System.Windows.Forms.Padding(0);
            this.txttexto.Name = "txttexto";
            this.txttexto.ShowSelectionMargin = true;
            this.txttexto.Size = new System.Drawing.Size(621, 307);
            this.txttexto.TabIndex = 2;
            this.txttexto.TabStop = false;
            this.txttexto.Text = "";
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(1, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(621, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.menuquebraDeLinha,
            this.carregarFonteToolStripMenuItem,
            this.salvarFonteToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.fonteToolStripMenuItem.Text = "Fonte...";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // menuquebraDeLinha
            // 
            this.menuquebraDeLinha.Checked = true;
            this.menuquebraDeLinha.CheckOnClick = true;
            this.menuquebraDeLinha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuquebraDeLinha.Name = "menuquebraDeLinha";
            this.menuquebraDeLinha.Size = new System.Drawing.Size(163, 22);
            this.menuquebraDeLinha.Text = "Quebra de linha";
            this.menuquebraDeLinha.Click += new System.EventHandler(this.quebraDeLinhaToolStripMenuItem_Click);
            // 
            // carregarFonteToolStripMenuItem
            // 
            this.carregarFonteToolStripMenuItem.Name = "carregarFonteToolStripMenuItem";
            this.carregarFonteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.carregarFonteToolStripMenuItem.Text = "Carregar fonte...";
            this.carregarFonteToolStripMenuItem.Click += new System.EventHandler(this.carregarFonteToolStripMenuItem_Click);
            // 
            // salvarFonteToolStripMenuItem
            // 
            this.salvarFonteToolStripMenuItem.Name = "salvarFonteToolStripMenuItem";
            this.salvarFonteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.salvarFonteToolStripMenuItem.Text = "Salvar fonte...";
            this.salvarFonteToolStripMenuItem.Click += new System.EventHandler(this.salvarFonteToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // font
            // 
            this.font.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.font.ShowColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 332);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(700, 250);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloco de notas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.FontDialog font;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuquebraDeLinha;
        private System.Windows.Forms.OpenFileDialog load;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarFonteToolStripMenuItem;
        public System.Windows.Forms.RichTextBox txttexto;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

