namespace projGerenciadorDeOperacoes
{
    partial class mainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBoxMenuBar = new System.Windows.Forms.ListBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelConteiner = new System.Windows.Forms.Panel();this.panel1.SuspendLayout();
            this.panelConteiner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBoxMenuBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 475);
            this.panel1.TabIndex = 2;
            // 
            // ListBoxMenuBar
            // 
            this.ListBoxMenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxMenuBar.FormattingEnabled = true;
            this.ListBoxMenuBar.ItemHeight = 16;
            this.ListBoxMenuBar.Items.AddRange(new object[] {
            "Cadastrar Cliente",
            "Ver Relátorios",
            "Adicionar Moeda"});
            this.ListBoxMenuBar.Location = new System.Drawing.Point(12, 12);
            this.ListBoxMenuBar.Name = "ListBoxMenuBar";
            this.ListBoxMenuBar.Size = new System.Drawing.Size(205, 452);
            this.ListBoxMenuBar.TabIndex = 3;
            this.ListBoxMenuBar.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(234, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 475);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // panelConteiner
            //
            this.panelConteiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteiner.Location = new System.Drawing.Point(237, 0);
            this.panelConteiner.Name = "panelConteiner";
            this.panelConteiner.Size = new System.Drawing.Size(494, 475);
            this.panelConteiner.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 475);
            this.Controls.Add(this.panelConteiner);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "Gerenciador de Operações";
            this.panel1.ResumeLayout(false);
            this.panelConteiner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListBoxMenuBar;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panelConteiner;
    }
}