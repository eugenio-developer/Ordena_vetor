namespace Pratica5
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.decrescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem,
            this.seleçãoToolStripMenuItem,
            this.inserçãoToolStripMenuItem,
            this.shellSortToolStripMenuItem,
            this.quickSortToolStripMenuItem,
            this.heapSortToolStripMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.algoritmoToolStripMenuItem.Text = "Animações";
            this.algoritmoToolStripMenuItem.Click += new System.EventHandler(this.algoritmoToolStripMenuItem_Click);
            // 
            // bolhaToolStripMenuItem
            // 
            this.bolhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatorioToolStripMenuItem,
            this.crescenteToolStripMenuItem,
            this.decrescenteToolStripMenuItem});
            this.bolhaToolStripMenuItem.Name = "bolhaToolStripMenuItem";
            this.bolhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bolhaToolStripMenuItem.Text = "Bolha";
            this.bolhaToolStripMenuItem.Click += new System.EventHandler(this.bolhaToolStripMenuItem_Click);
            // 
            // aleatorioToolStripMenuItem
            // 
            this.aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            this.aleatorioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aleatorioToolStripMenuItem.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem.Click += new System.EventHandler(this.aleatorioToolStripMenuItem_Click);
            // 
            // crescenteToolStripMenuItem
            // 
            this.crescenteToolStripMenuItem.Name = "crescenteToolStripMenuItem";
            this.crescenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crescenteToolStripMenuItem.Text = "Crescente";
            this.crescenteToolStripMenuItem.Click += new System.EventHandler(this.crescenteToolStripMenuItem_Click);
            // 
            // decrescenteToolStripMenuItem
            // 
            this.decrescenteToolStripMenuItem.Name = "decrescenteToolStripMenuItem";
            this.decrescenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decrescenteToolStripMenuItem.Text = "Decrescente";
            this.decrescenteToolStripMenuItem.Click += new System.EventHandler(this.decrescenteToolStripMenuItem_Click);
            // 
            // seleçãoToolStripMenuItem
            // 
            this.seleçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatorioToolStripMenuItem1,
            this.crescenteToolStripMenuItem1,
            this.decrescenteToolStripMenuItem1});
            this.seleçãoToolStripMenuItem.Name = "seleçãoToolStripMenuItem";
            this.seleçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seleçãoToolStripMenuItem.Text = "Seleção";
            // 
            // aleatorioToolStripMenuItem1
            // 
            this.aleatorioToolStripMenuItem1.Name = "aleatorioToolStripMenuItem1";
            this.aleatorioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aleatorioToolStripMenuItem1.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem1.Click += new System.EventHandler(this.aleatorioToolStripMenuItem1_Click);
            // 
            // crescenteToolStripMenuItem1
            // 
            this.crescenteToolStripMenuItem1.Name = "crescenteToolStripMenuItem1";
            this.crescenteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.crescenteToolStripMenuItem1.Text = "Crescente";
            this.crescenteToolStripMenuItem1.Click += new System.EventHandler(this.crescenteToolStripMenuItem1_Click);
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatorioToolStripMenuItem2,
            this.crescenteToolStripMenuItem2,
            this.decrescenteToolStripMenuItem2});
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            // 
            // aleatorioToolStripMenuItem2
            // 
            this.aleatorioToolStripMenuItem2.Name = "aleatorioToolStripMenuItem2";
            this.aleatorioToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.aleatorioToolStripMenuItem2.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem2.Click += new System.EventHandler(this.aleatorioToolStripMenuItem2_Click);
            // 
            // crescenteToolStripMenuItem2
            // 
            this.crescenteToolStripMenuItem2.Name = "crescenteToolStripMenuItem2";
            this.crescenteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.crescenteToolStripMenuItem2.Text = "Crescente";
            this.crescenteToolStripMenuItem2.Click += new System.EventHandler(this.crescenteToolStripMenuItem2_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatorioToolStripMenuItem3,
            this.crescenteToolStripMenuItem3,
            this.decrescenteToolStripMenuItem3});
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shellSortToolStripMenuItem.Text = "Shell Sort";
            // 
            // aleatorioToolStripMenuItem3
            // 
            this.aleatorioToolStripMenuItem3.Name = "aleatorioToolStripMenuItem3";
            this.aleatorioToolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
            this.aleatorioToolStripMenuItem3.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem3.Click += new System.EventHandler(this.aleatorioToolStripMenuItem3_Click);
            // 
            // crescenteToolStripMenuItem3
            // 
            this.crescenteToolStripMenuItem3.Name = "crescenteToolStripMenuItem3";
            this.crescenteToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.crescenteToolStripMenuItem3.Text = "Crescente";
            this.crescenteToolStripMenuItem3.Click += new System.EventHandler(this.crescenteToolStripMenuItem3_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatorioToolStripMenuItem4,
            this.crescenteToolStripMenuItem4,
            this.decrescenteToolStripMenuItem4});
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quickSortToolStripMenuItem.Text = "Quick Sort";
            // 
            // aleatorioToolStripMenuItem4
            // 
            this.aleatorioToolStripMenuItem4.Name = "aleatorioToolStripMenuItem4";
            this.aleatorioToolStripMenuItem4.Size = new System.Drawing.Size(126, 22);
            this.aleatorioToolStripMenuItem4.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem4.Click += new System.EventHandler(this.aleatorioToolStripMenuItem4_Click);
            // 
            // crescenteToolStripMenuItem4
            // 
            this.crescenteToolStripMenuItem4.Name = "crescenteToolStripMenuItem4";
            this.crescenteToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.crescenteToolStripMenuItem4.Text = "Crescente";
            this.crescenteToolStripMenuItem4.Click += new System.EventHandler(this.crescenteToolStripMenuItem4_Click);
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aleatorioToolStripMenuItem5,
            this.crescenteToolStripMenuItem5,
            this.decrescenteToolStripMenuItem5});
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            this.heapSortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heapSortToolStripMenuItem.Text = "Heap Sort";
            // 
            // aleatorioToolStripMenuItem5
            // 
            this.aleatorioToolStripMenuItem5.Name = "aleatorioToolStripMenuItem5";
            this.aleatorioToolStripMenuItem5.Size = new System.Drawing.Size(126, 22);
            this.aleatorioToolStripMenuItem5.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem5.Click += new System.EventHandler(this.aleatorioToolStripMenuItem5_Click);
            // 
            // crescenteToolStripMenuItem5
            // 
            this.crescenteToolStripMenuItem5.Name = "crescenteToolStripMenuItem5";
            this.crescenteToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.crescenteToolStripMenuItem5.Text = "Crescente";
            this.crescenteToolStripMenuItem5.Click += new System.EventHandler(this.crescenteToolStripMenuItem5_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem1});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // decrescenteToolStripMenuItem1
            // 
            this.decrescenteToolStripMenuItem1.Name = "decrescenteToolStripMenuItem1";
            this.decrescenteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.decrescenteToolStripMenuItem1.Text = "Decrescente";
            this.decrescenteToolStripMenuItem1.Click += new System.EventHandler(this.decrescenteToolStripMenuItem1_Click);
            // 
            // decrescenteToolStripMenuItem2
            // 
            this.decrescenteToolStripMenuItem2.Name = "decrescenteToolStripMenuItem2";
            this.decrescenteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.decrescenteToolStripMenuItem2.Text = "Decrescente";
            this.decrescenteToolStripMenuItem2.Click += new System.EventHandler(this.decrescenteToolStripMenuItem2_Click);
            // 
            // decrescenteToolStripMenuItem3
            // 
            this.decrescenteToolStripMenuItem3.Name = "decrescenteToolStripMenuItem3";
            this.decrescenteToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.decrescenteToolStripMenuItem3.Text = "Decrescente";
            this.decrescenteToolStripMenuItem3.Click += new System.EventHandler(this.decrescenteToolStripMenuItem3_Click);
            // 
            // decrescenteToolStripMenuItem4
            // 
            this.decrescenteToolStripMenuItem4.Name = "decrescenteToolStripMenuItem4";
            this.decrescenteToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.decrescenteToolStripMenuItem4.Text = "Decrescente";
            this.decrescenteToolStripMenuItem4.Click += new System.EventHandler(this.decrescenteToolStripMenuItem4_Click);
            // 
            // decrescenteToolStripMenuItem5
            // 
            this.decrescenteToolStripMenuItem5.Name = "decrescenteToolStripMenuItem5";
            this.decrescenteToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.decrescenteToolStripMenuItem5.Text = "Decrescente";
            this.decrescenteToolStripMenuItem5.Click += new System.EventHandler(this.decrescenteToolStripMenuItem5_Click);
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 2022/2 - Métodos de Ordenação";
            this.Load += new System.EventHandler(this.FormOrdenacao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem5;
    }
}

