namespace IE.Programare1.GestiuneAlbume
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.uxComboBoxAlbume = new System.Windows.Forms.ComboBox();
            this.uxButtonNou = new System.Windows.Forms.Button();
            this.uxButtonDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uxTextBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxDateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.uxTextBoxDenumire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pret = new System.Windows.Forms.Label();
            this.uxTextBoxPret = new System.Windows.Forms.TextBox();
            this.uxComboBoxSuport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxButtonSalveaza = new System.Windows.Forms.Button();
            this.uxTextBoxArtist = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 385);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.uxComboBoxAlbume);
            this.flowLayoutPanel1.Controls.Add(this.uxButtonNou);
            this.flowLayoutPanel1.Controls.Add(this.uxButtonDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(875, 82);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Albume";
            // 
            // uxComboBoxAlbume
            // 
            this.uxComboBoxAlbume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxComboBoxAlbume.DisplayMember = "Denumire";
            this.uxComboBoxAlbume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxComboBoxAlbume.FormattingEnabled = true;
            this.uxComboBoxAlbume.Location = new System.Drawing.Point(83, 10);
            this.uxComboBoxAlbume.Margin = new System.Windows.Forms.Padding(4);
            this.uxComboBoxAlbume.Name = "uxComboBoxAlbume";
            this.uxComboBoxAlbume.Size = new System.Drawing.Size(268, 28);
            this.uxComboBoxAlbume.TabIndex = 1;
            this.uxComboBoxAlbume.ValueMember = "ID";
            this.uxComboBoxAlbume.SelectedIndexChanged += new System.EventHandler(this.uxComboBoxAlbume_SelectedIndexChanged);
            // 
            // uxButtonNou
            // 
            this.uxButtonNou.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxButtonNou.AutoSize = true;
            this.uxButtonNou.Location = new System.Drawing.Point(359, 4);
            this.uxButtonNou.Margin = new System.Windows.Forms.Padding(4);
            this.uxButtonNou.Name = "uxButtonNou";
            this.uxButtonNou.Size = new System.Drawing.Size(100, 37);
            this.uxButtonNou.TabIndex = 2;
            this.uxButtonNou.Text = "Nou";
            this.uxButtonNou.UseVisualStyleBackColor = true;
            this.uxButtonNou.Click += new System.EventHandler(this.uxButtonNou_Click);
            // 
            // uxButtonDelete
            // 
            this.uxButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxButtonDelete.AutoSize = true;
            this.uxButtonDelete.Location = new System.Drawing.Point(467, 4);
            this.uxButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.uxButtonDelete.Name = "uxButtonDelete";
            this.uxButtonDelete.Size = new System.Drawing.Size(100, 37);
            this.uxButtonDelete.TabIndex = 3;
            this.uxButtonDelete.Text = "Delete";
            this.uxButtonDelete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.uxDateTimePickerData, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxDenumire, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Pret, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxPret, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.uxComboBoxSuport, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.uxButtonSalveaza, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxArtist, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 94);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(875, 288);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // uxTextBoxId
            // 
            this.uxTextBoxId.Enabled = false;
            this.uxTextBoxId.Location = new System.Drawing.Point(153, 4);
            this.uxTextBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.uxTextBoxId.Name = "uxTextBoxId";
            this.uxTextBoxId.Size = new System.Drawing.Size(132, 27);
            this.uxTextBoxId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(55, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Denumire";
            // 
            // uxDateTimePickerData
            // 
            this.uxDateTimePickerData.Location = new System.Drawing.Point(153, 41);
            this.uxDateTimePickerData.Margin = new System.Windows.Forms.Padding(4);
            this.uxDateTimePickerData.Name = "uxDateTimePickerData";
            this.uxDateTimePickerData.Size = new System.Drawing.Size(333, 27);
            this.uxDateTimePickerData.TabIndex = 1;
            // 
            // uxTextBoxDenumire
            // 
            this.uxTextBoxDenumire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxDenumire.Location = new System.Drawing.Point(153, 79);
            this.uxTextBoxDenumire.Margin = new System.Windows.Forms.Padding(4);
            this.uxTextBoxDenumire.Name = "uxTextBoxDenumire";
            this.uxTextBoxDenumire.Size = new System.Drawing.Size(718, 27);
            this.uxTextBoxDenumire.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(96, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(90, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Artist";
            // 
            // Pret
            // 
            this.Pret.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Pret.AutoSize = true;
            this.Pret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pret.Location = new System.Drawing.Point(101, 156);
            this.Pret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pret.Name = "Pret";
            this.Pret.Size = new System.Drawing.Size(44, 20);
            this.Pret.TabIndex = 7;
            this.Pret.Text = "Pret";
            // 
            // uxTextBoxPret
            // 
            this.uxTextBoxPret.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxTextBoxPret.Location = new System.Drawing.Point(153, 153);
            this.uxTextBoxPret.Margin = new System.Windows.Forms.Padding(4);
            this.uxTextBoxPret.Name = "uxTextBoxPret";
            this.uxTextBoxPret.Size = new System.Drawing.Size(117, 27);
            this.uxTextBoxPret.TabIndex = 8;
            // 
            // uxComboBoxSuport
            // 
            this.uxComboBoxSuport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxComboBoxSuport.FormattingEnabled = true;
            this.uxComboBoxSuport.Items.AddRange(new object[] {
            "DVD",
            "CD",
            "Blu-Ray",
            "Caseta",
            "Vinil"});
            this.uxComboBoxSuport.Location = new System.Drawing.Point(153, 191);
            this.uxComboBoxSuport.Margin = new System.Windows.Forms.Padding(4);
            this.uxComboBoxSuport.Name = "uxComboBoxSuport";
            this.uxComboBoxSuport.Size = new System.Drawing.Size(160, 28);
            this.uxComboBoxSuport.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(81, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Suport";
            // 
            // uxButtonSalveaza
            // 
            this.uxButtonSalveaza.AutoSize = true;
            this.uxButtonSalveaza.Location = new System.Drawing.Point(153, 226);
            this.uxButtonSalveaza.Margin = new System.Windows.Forms.Padding(4);
            this.uxButtonSalveaza.Name = "uxButtonSalveaza";
            this.uxButtonSalveaza.Size = new System.Drawing.Size(127, 42);
            this.uxButtonSalveaza.TabIndex = 11;
            this.uxButtonSalveaza.Text = "Salveaza";
            this.uxButtonSalveaza.UseVisualStyleBackColor = true;
            this.uxButtonSalveaza.Click += new System.EventHandler(this.uxButtonSalveaza_Click);
            // 
            // uxTextBoxArtist
            // 
            this.uxTextBoxArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxArtist.Location = new System.Drawing.Point(153, 116);
            this.uxTextBoxArtist.Margin = new System.Windows.Forms.Padding(4);
            this.uxTextBoxArtist.Name = "uxTextBoxArtist";
            this.uxTextBoxArtist.Size = new System.Drawing.Size(718, 27);
            this.uxTextBoxArtist.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nr. inv. (ID)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gestiune Albume";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uxComboBoxAlbume;
        private System.Windows.Forms.Button uxButtonNou;
        private System.Windows.Forms.Button uxButtonDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox uxTextBoxId;
        private System.Windows.Forms.DateTimePicker uxDateTimePickerData;
        private System.Windows.Forms.TextBox uxTextBoxDenumire;
        private System.Windows.Forms.TextBox uxTextBoxArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Pret;
        private System.Windows.Forms.ComboBox uxComboBoxSuport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uxButtonSalveaza;
        private System.Windows.Forms.TextBox uxTextBoxPret;
        private System.Windows.Forms.Label label6;
    }
}

