namespace projGerenciadorDeOperacoes.View
{
    partial class ControlAddClient
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
            this.addClientSplitter = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelConvertedValue = new System.Windows.Forms.Label();
            this.textBoxFinalValue = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.labelCoin = new System.Windows.Forms.Label();
            this.comboBoxCoin = new System.Windows.Forms.ComboBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.checkBoxToday = new System.Windows.Forms.CheckBox();
            this.textBoxFirstValue = new System.Windows.Forms.TextBox();
            this.labelFirstValue = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addClientSplitter
            // 
            this.addClientSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addClientSplitter.Location = new System.Drawing.Point(0, 454);
            this.addClientSplitter.Name = "addClientSplitter";
            this.addClientSplitter.Size = new System.Drawing.Size(491, 3);
            this.addClientSplitter.TabIndex = 0;
            this.addClientSplitter.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.labelTax);
            this.panel1.Controls.Add(this.labelConvertedValue);
            this.panel1.Controls.Add(this.textBoxFinalValue);
            this.panel1.Controls.Add(this.textBoxTax);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.comboBoxDestination);
            this.panel1.Controls.Add(this.labelCoin);
            this.panel1.Controls.Add(this.comboBoxCoin);
            this.panel1.Controls.Add(this.labelDestination);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.checkBoxToday);
            this.panel1.Controls.Add(this.textBoxFirstValue);
            this.panel1.Controls.Add(this.labelFirstValue);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 454);
            this.panel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.AutoSize = true;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonSave.Location = new System.Drawing.Point(387, 407);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(82, 34);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelTax
            // 
            this.labelTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelTax.Location = new System.Drawing.Point(23, 417);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(177, 24);
            this.labelTax.TabIndex = 34;
            this.labelTax.Text = "Taxa à ser cobrada:";
            // 
            // labelConvertedValue
            // 
            this.labelConvertedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConvertedValue.AutoSize = true;
            this.labelConvertedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelConvertedValue.Location = new System.Drawing.Point(23, 381);
            this.labelConvertedValue.Name = "labelConvertedValue";
            this.labelConvertedValue.Size = new System.Drawing.Size(152, 24);
            this.labelConvertedValue.TabIndex = 33;
            this.labelConvertedValue.Text = "Valor convertido:";
            // 
            // textBoxFinalValue
            // 
            this.textBoxFinalValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinalValue.Enabled = false;
            this.textBoxFinalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxFinalValue.Location = new System.Drawing.Point(192, 377);
            this.textBoxFinalValue.Name = "textBoxFinalValue";
            this.textBoxFinalValue.Size = new System.Drawing.Size(135, 28);
            this.textBoxFinalValue.TabIndex = 35;
            // 
            // textBoxTax
            // 
            this.textBoxTax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTax.Enabled = false;
            this.textBoxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxTax.Location = new System.Drawing.Point(218, 411);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(109, 28);
            this.textBoxTax.TabIndex = 36;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(20, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(271, 38);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Cadastrar Cliente";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(196, 183);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(138, 28);
            this.dateTimePicker.TabIndex = 32;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelName.Location = new System.Drawing.Point(23, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 24);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Nome:";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(196, 147);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(138, 30);
            this.comboBoxDestination.TabIndex = 31;
            this.comboBoxDestination.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDestination_SelectedIndexChanged);
            // 
            // labelCoin
            // 
            this.labelCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCoin.AutoSize = true;
            this.labelCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCoin.Location = new System.Drawing.Point(24, 115);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(170, 24);
            this.labelCoin.TabIndex = 19;
            this.labelCoin.Text = "Moeda de origem: ";
            // 
            // comboBoxCoin
            // 
            this.comboBoxCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxCoin.FormattingEnabled = true;
            this.comboBoxCoin.Location = new System.Drawing.Point(196, 112);
            this.comboBoxCoin.Name = "comboBoxCoin";
            this.comboBoxCoin.Size = new System.Drawing.Size(138, 30);
            this.comboBoxCoin.TabIndex = 30;
            this.comboBoxCoin.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCoin_SelectedIndexChanged);
            // 
            // labelDestination
            // 
            this.labelDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDestination.Location = new System.Drawing.Point(24, 150);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(172, 24);
            this.labelDestination.TabIndex = 20;
            this.labelDestination.Text = "Moeda de destino: ";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDate.Location = new System.Drawing.Point(23, 188);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(164, 24);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Data de operação:";
            // 
            // checkBoxToday
            // 
            this.checkBoxToday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxToday.AutoSize = true;
            this.checkBoxToday.Checked = true;
            this.checkBoxToday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBoxToday.Location = new System.Drawing.Point(28, 218);
            this.checkBoxToday.Name = "checkBoxToday";
            this.checkBoxToday.Size = new System.Drawing.Size(154, 28);
            this.checkBoxToday.TabIndex = 22;
            this.checkBoxToday.Text = "Usar data atual";
            this.checkBoxToday.UseVisualStyleBackColor = true;
            this.checkBoxToday.CheckedChanged += new System.EventHandler(this.CheckBoxToday_CheckedChanged);
            // 
            // textBoxFirstValue
            // 
            this.textBoxFirstValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxFirstValue.Location = new System.Drawing.Point(166, 249);
            this.textBoxFirstValue.Name = "textBoxFirstValue";
            this.textBoxFirstValue.Size = new System.Drawing.Size(168, 28);
            this.textBoxFirstValue.TabIndex = 27;
            this.textBoxFirstValue.TextChanged += new System.EventHandler(this.TextBoxFirstValue_TextChanged);
            // 
            // labelFirstValue
            // 
            this.labelFirstValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirstValue.AutoSize = true;
            this.labelFirstValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelFirstValue.Location = new System.Drawing.Point(23, 249);
            this.labelFirstValue.Name = "labelFirstValue";
            this.labelFirstValue.Size = new System.Drawing.Size(125, 24);
            this.labelFirstValue.TabIndex = 23;
            this.labelFirstValue.Text = "Valor original:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxName.Location = new System.Drawing.Point(114, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 28);
            this.textBoxName.TabIndex = 26;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 454);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // ControlAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addClientSplitter);
            this.Location = new System.Drawing.Point(7, 4);
            this.Name = "ControlAddClient";
            this.Size = new System.Drawing.Size(491, 457);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter addClientSplitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.ComboBox comboBoxCoin;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.CheckBox checkBoxToday;
        private System.Windows.Forms.TextBox textBoxFirstValue;
        private System.Windows.Forms.Label labelFirstValue;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelConvertedValue;
        private System.Windows.Forms.TextBox textBoxFinalValue;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Button buttonSave;
    }
}
