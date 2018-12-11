namespace IE.Programare1.EqGrad2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxTextBoxA = new System.Windows.Forms.TextBox();
            this.uxTextBoxB = new System.Windows.Forms.TextBox();
            this.uxTextBoxC = new System.Windows.Forms.TextBox();
            this.uxButtonRezolva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ecutia de gradul 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            // 
            // uxTextBoxA
            // 
            this.uxTextBoxA.Location = new System.Drawing.Point(120, 109);
            this.uxTextBoxA.Name = "uxTextBoxA";
            this.uxTextBoxA.Size = new System.Drawing.Size(100, 26);
            this.uxTextBoxA.TabIndex = 4;
            // 
            // uxTextBoxB
            // 
            this.uxTextBoxB.Location = new System.Drawing.Point(120, 177);
            this.uxTextBoxB.Name = "uxTextBoxB";
            this.uxTextBoxB.Size = new System.Drawing.Size(100, 26);
            this.uxTextBoxB.TabIndex = 5;
            // 
            // uxTextBoxC
            // 
            this.uxTextBoxC.Location = new System.Drawing.Point(120, 245);
            this.uxTextBoxC.Name = "uxTextBoxC";
            this.uxTextBoxC.Size = new System.Drawing.Size(100, 26);
            this.uxTextBoxC.TabIndex = 6;
            // 
            // uxButtonRezolva
            // 
            this.uxButtonRezolva.Location = new System.Drawing.Point(40, 313);
            this.uxButtonRezolva.Name = "uxButtonRezolva";
            this.uxButtonRezolva.Size = new System.Drawing.Size(183, 41);
            this.uxButtonRezolva.TabIndex = 7;
            this.uxButtonRezolva.Text = "Rezolva";
            this.uxButtonRezolva.UseVisualStyleBackColor = true;
            this.uxButtonRezolva.Click += new System.EventHandler(this.uxButtonRezolva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxButtonRezolva);
            this.Controls.Add(this.uxTextBoxC);
            this.Controls.Add(this.uxTextBoxB);
            this.Controls.Add(this.uxTextBoxA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ecuatia de gradul 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxTextBoxA;
        private System.Windows.Forms.TextBox uxTextBoxB;
        private System.Windows.Forms.TextBox uxTextBoxC;
        private System.Windows.Forms.Button uxButtonRezolva;
    }
}

