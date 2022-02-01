namespace Ukol2_metody_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cisla = new System.Windows.Forms.TextBox();
            this.generovat = new System.Windows.Forms.Button();
            this.prvocisla = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vstup_N = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cisla
            // 
            this.cisla.Location = new System.Drawing.Point(12, 54);
            this.cisla.Multiline = true;
            this.cisla.Name = "cisla";
            this.cisla.ReadOnly = true;
            this.cisla.Size = new System.Drawing.Size(113, 95);
            this.cisla.TabIndex = 0;
            // 
            // generovat
            // 
            this.generovat.Location = new System.Drawing.Point(172, 10);
            this.generovat.Name = "generovat";
            this.generovat.Size = new System.Drawing.Size(75, 23);
            this.generovat.TabIndex = 1;
            this.generovat.Text = "Generovat";
            this.generovat.UseVisualStyleBackColor = true;
            this.generovat.Click += new System.EventHandler(this.generovat_Click);
            // 
            // prvocisla
            // 
            this.prvocisla.FormattingEnabled = true;
            this.prvocisla.Location = new System.Drawing.Point(131, 54);
            this.prvocisla.Name = "prvocisla";
            this.prvocisla.Size = new System.Drawing.Size(116, 95);
            this.prvocisla.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vygenerovaná čísla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prvočísla";
            // 
            // vstup_N
            // 
            this.vstup_N.Location = new System.Drawing.Point(66, 12);
            this.vstup_N.Name = "vstup_N";
            this.vstup_N.Size = new System.Drawing.Size(100, 20);
            this.vstup_N.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zadej N:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 163);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vstup_N);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prvocisla);
            this.Controls.Add(this.generovat);
            this.Controls.Add(this.cisla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Úkol 2 metody C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cisla;
        private System.Windows.Forms.Button generovat;
        private System.Windows.Forms.ListBox prvocisla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vstup_N;
        private System.Windows.Forms.Label label3;
    }
}

