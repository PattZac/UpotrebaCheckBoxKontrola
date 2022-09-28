namespace UpotrebaCheckBoxKontrola
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
            this.chkDorucak = new System.Windows.Forms.CheckBox();
            this.chkRucak = new System.Windows.Forms.CheckBox();
            this.chkVecera = new System.Windows.Forms.CheckBox();
            this.chkSakrij = new System.Windows.Forms.CheckBox();
            this.bntPoslaj = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkDorucak
            // 
            this.chkDorucak.AutoSize = true;
            this.chkDorucak.Location = new System.Drawing.Point(13, 13);
            this.chkDorucak.Name = "chkDorucak";
            this.chkDorucak.Size = new System.Drawing.Size(67, 17);
            this.chkDorucak.TabIndex = 0;
            this.chkDorucak.Text = "Dorucak";
            this.chkDorucak.UseVisualStyleBackColor = true;
            // 
            // chkRucak
            // 
            this.chkRucak.AutoSize = true;
            this.chkRucak.Location = new System.Drawing.Point(13, 48);
            this.chkRucak.Name = "chkRucak";
            this.chkRucak.Size = new System.Drawing.Size(58, 17);
            this.chkRucak.TabIndex = 1;
            this.chkRucak.Text = "Rucak";
            this.chkRucak.UseVisualStyleBackColor = true;
            // 
            // chkVecera
            // 
            this.chkVecera.AutoSize = true;
            this.chkVecera.Location = new System.Drawing.Point(13, 83);
            this.chkVecera.Name = "chkVecera";
            this.chkVecera.Size = new System.Drawing.Size(60, 17);
            this.chkVecera.TabIndex = 2;
            this.chkVecera.Text = "Vecera";
            this.chkVecera.UseVisualStyleBackColor = true;
            // 
            // chkSakrij
            // 
            this.chkSakrij.AutoSize = true;
            this.chkSakrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkSakrij.Location = new System.Drawing.Point(137, 131);
            this.chkSakrij.Name = "chkSakrij";
            this.chkSakrij.Size = new System.Drawing.Size(99, 17);
            this.chkSakrij.TabIndex = 3;
            this.chkSakrij.Text = "Sakrij narudžbu";
            this.chkSakrij.UseVisualStyleBackColor = true;
            this.chkSakrij.CheckedChanged += new System.EventHandler(this.chkSakrij_CheckedChanged);
            // 
            // bntPoslaj
            // 
            this.bntPoslaj.Location = new System.Drawing.Point(13, 127);
            this.bntPoslaj.Name = "bntPoslaj";
            this.bntPoslaj.Size = new System.Drawing.Size(97, 23);
            this.bntPoslaj.TabIndex = 4;
            this.bntPoslaj.Text = "Poslaj";
            this.bntPoslaj.UseVisualStyleBackColor = true;
            this.bntPoslaj.Click += new System.EventHandler(this.bntPoslaj_Click);
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(137, 13);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(178, 87);
            this.txtMain.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 171);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.bntPoslaj);
            this.Controls.Add(this.chkSakrij);
            this.Controls.Add(this.chkVecera);
            this.Controls.Add(this.chkRucak);
            this.Controls.Add(this.chkDorucak);
            this.Name = "Form1";
            this.Text = "Upotreba CheckBox kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDorucak;
        private System.Windows.Forms.CheckBox chkRucak;
        private System.Windows.Forms.CheckBox chkVecera;
        private System.Windows.Forms.CheckBox chkSakrij;
        private System.Windows.Forms.Button bntPoslaj;
        private System.Windows.Forms.TextBox txtMain;
    }
}

