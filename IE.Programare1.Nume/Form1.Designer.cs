namespace IE.Programare1.Nume
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
            if(disposing && (components != null))
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uxTextBoxNume = new System.Windows.Forms.TextBox();
            this.uxButtonAdauga = new System.Windows.Forms.Button();
            this.uxListBoxNume = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxButtonSorteaza = new System.Windows.Forms.Button();
            this.uxCheckBoxDescr = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uxTextBoxCauta = new System.Windows.Forms.TextBox();
            this.uxButtonCauta = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uxListBoxNume, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxNume, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.uxButtonAdauga, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 34);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(596, 28);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // uxTextBoxNume
            // 
            this.uxTextBoxNume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxNume.Location = new System.Drawing.Point(2, 4);
            this.uxTextBoxNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxTextBoxNume.Name = "uxTextBoxNume";
            this.uxTextBoxNume.Size = new System.Drawing.Size(532, 20);
            this.uxTextBoxNume.TabIndex = 0;
            this.uxTextBoxNume.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uxTextBoxNume_KeyUp);
            // 
            // uxButtonAdauga
            // 
            this.uxButtonAdauga.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxButtonAdauga.AutoSize = true;
            this.uxButtonAdauga.Location = new System.Drawing.Point(538, 2);
            this.uxButtonAdauga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxButtonAdauga.Name = "uxButtonAdauga";
            this.uxButtonAdauga.Size = new System.Drawing.Size(56, 23);
            this.uxButtonAdauga.TabIndex = 1;
            this.uxButtonAdauga.Text = "Adauga";
            this.uxButtonAdauga.UseVisualStyleBackColor = true;
            this.uxButtonAdauga.Click += new System.EventHandler(this.uxButtonAdauga_Click);
            // 
            // uxListBoxNume
            // 
            this.uxListBoxNume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxListBoxNume.FormattingEnabled = true;
            this.uxListBoxNume.Location = new System.Drawing.Point(2, 66);
            this.uxListBoxNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxListBoxNume.Name = "uxListBoxNume";
            this.uxListBoxNume.Size = new System.Drawing.Size(596, 234);
            this.uxListBoxNume.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.uxButtonSorteaza);
            this.flowLayoutPanel1.Controls.Add(this.uxCheckBoxDescr);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 304);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(596, 28);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // uxButtonSorteaza
            // 
            this.uxButtonSorteaza.AutoSize = true;
            this.uxButtonSorteaza.Location = new System.Drawing.Point(2, 2);
            this.uxButtonSorteaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxButtonSorteaza.Name = "uxButtonSorteaza";
            this.uxButtonSorteaza.Size = new System.Drawing.Size(59, 23);
            this.uxButtonSorteaza.TabIndex = 1;
            this.uxButtonSorteaza.Text = "Sorteaza";
            this.uxButtonSorteaza.UseVisualStyleBackColor = true;
            this.uxButtonSorteaza.Click += new System.EventHandler(this.uxButtonSorteaza_Click);
            // 
            // uxCheckBoxDescr
            // 
            this.uxCheckBoxDescr.AutoSize = true;
            this.uxCheckBoxDescr.Location = new System.Drawing.Point(65, 2);
            this.uxCheckBoxDescr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxCheckBoxDescr.Name = "uxCheckBoxDescr";
            this.uxCheckBoxDescr.Size = new System.Drawing.Size(87, 17);
            this.uxCheckBoxDescr.TabIndex = 0;
            this.uxCheckBoxDescr.Text = "descrescator";
            this.uxCheckBoxDescr.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.uxTextBoxCauta, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.uxButtonCauta, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 336);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(596, 28);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // uxTextBoxCauta
            // 
            this.uxTextBoxCauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxCauta.Location = new System.Drawing.Point(2, 4);
            this.uxTextBoxCauta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxTextBoxCauta.Name = "uxTextBoxCauta";
            this.uxTextBoxCauta.Size = new System.Drawing.Size(532, 20);
            this.uxTextBoxCauta.TabIndex = 0;
            // 
            // uxButtonCauta
            // 
            this.uxButtonCauta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxButtonCauta.AutoSize = true;
            this.uxButtonCauta.Location = new System.Drawing.Point(538, 2);
            this.uxButtonCauta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxButtonCauta.Name = "uxButtonCauta";
            this.uxButtonCauta.Size = new System.Drawing.Size(56, 23);
            this.uxButtonCauta.TabIndex = 1;
            this.uxButtonCauta.Text = "Cauta";
            this.uxButtonCauta.UseVisualStyleBackColor = true;
            this.uxButtonCauta.Click += new System.EventHandler(this.uxButtonCauta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox uxTextBoxNume;
        private System.Windows.Forms.Button uxButtonAdauga;
        private System.Windows.Forms.ListBox uxListBoxNume;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button uxButtonSorteaza;
        private System.Windows.Forms.CheckBox uxCheckBoxDescr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox uxTextBoxCauta;
        private System.Windows.Forms.Button uxButtonCauta;
    }
}

