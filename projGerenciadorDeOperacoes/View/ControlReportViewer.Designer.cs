namespace projGerenciadorDeOperacoes.View
{
    partial class ControlReportViewer
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.checkBoxUseDate = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.textBoxOpe = new System.Windows.Forms.TextBox();
            this.labelTaxaTotal = new System.Windows.Forms.Label();
            this.labelOpeTotal = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 454);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(491, 3);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRestore);
            this.panel1.Controls.Add(this.textBoxTax);
            this.panel1.Controls.Add(this.checkBoxUseDate);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.textBoxSearchName);
            this.panel1.Controls.Add(this.textBoxOpe);
            this.panel1.Controls.Add(this.labelTaxaTotal);
            this.panel1.Controls.Add(this.labelOpeTotal);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 454);
            this.panel1.TabIndex = 1;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.AutoSize = true;
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonRestore.Location = new System.Drawing.Point(369, 120);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(107, 36);
            this.buttonRestore.TabIndex = 29;
            this.buttonRestore.Text = "Restaurar";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // textBoxTax
            // 
            this.textBoxTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTax.Enabled = false;
            this.textBoxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxTax.Location = new System.Drawing.Point(352, 417);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(117, 28);
            this.textBoxTax.TabIndex = 28;
            // 
            // checkBoxUseDate
            // 
            this.checkBoxUseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUseDate.AutoSize = true;
            this.checkBoxUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBoxUseDate.Location = new System.Drawing.Point(182, 125);
            this.checkBoxUseDate.Name = "checkBoxUseDate";
            this.checkBoxUseDate.Size = new System.Drawing.Size(118, 28);
            this.checkBoxUseDate.TabIndex = 27;
            this.checkBoxUseDate.Text = "Filtrar data";
            this.checkBoxUseDate.UseVisualStyleBackColor = true;
            this.checkBoxUseDate.CheckedChanged += new System.EventHandler(this.CheckBoxUseDate_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonSearch.Location = new System.Drawing.Point(369, 78);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 36);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "Pesquisar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(27, 122);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(134, 28);
            this.dateTimePicker.TabIndex = 25;
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSearchName.Location = new System.Drawing.Point(27, 81);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(324, 28);
            this.textBoxSearchName.TabIndex = 24;
            // 
            // textBoxOpe
            // 
            this.textBoxOpe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpe.Enabled = false;
            this.textBoxOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxOpe.Location = new System.Drawing.Point(326, 382);
            this.textBoxOpe.Name = "textBoxOpe";
            this.textBoxOpe.Size = new System.Drawing.Size(144, 28);
            this.textBoxOpe.TabIndex = 22;
            // 
            // labelTaxaTotal
            // 
            this.labelTaxaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTaxaTotal.AutoSize = true;
            this.labelTaxaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelTaxaTotal.Location = new System.Drawing.Point(74, 418);
            this.labelTaxaTotal.Name = "labelTaxaTotal";
            this.labelTaxaTotal.Size = new System.Drawing.Size(263, 24);
            this.labelTaxaTotal.TabIndex = 21;
            this.labelTaxaTotal.Text = "Valor total das taxas cobradas:";
            // 
            // labelOpeTotal
            // 
            this.labelOpeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOpeTotal.AutoSize = true;
            this.labelOpeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelOpeTotal.Location = new System.Drawing.Point(73, 383);
            this.labelOpeTotal.Name = "labelOpeTotal";
            this.labelOpeTotal.Size = new System.Drawing.Size(227, 24);
            this.labelOpeTotal.TabIndex = 20;
            this.labelOpeTotal.Text = "Valor total das operações:";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(27, 173);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(443, 189);
            this.dataGridView.TabIndex = 19;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(20, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(224, 38);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Ver Relatórios";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 454);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // ControlReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Location = new System.Drawing.Point(7, 4);
            this.Name = "ControlReportViewer";
            this.Size = new System.Drawing.Size(491, 457);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelOpeTotal;
        private System.Windows.Forms.TextBox textBoxOpe;
        private System.Windows.Forms.Label labelTaxaTotal;
        private System.Windows.Forms.CheckBox checkBoxUseDate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Button buttonRestore;
    }
}
