namespace UAS_OOP_1204003_New
{
    partial class UpdateProdi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgUpdateProdi = new System.Windows.Forms.DataGridView();
            this.UpdatePrd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Update Data Program Studi";
            // 
            // dgUpdateProdi
            // 
            this.dgUpdateProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUpdateProdi.Location = new System.Drawing.Point(83, 82);
            this.dgUpdateProdi.Name = "dgUpdateProdi";
            this.dgUpdateProdi.Size = new System.Drawing.Size(443, 151);
            this.dgUpdateProdi.TabIndex = 5;
            // 
            // UpdatePrd
            // 
            this.UpdatePrd.Location = new System.Drawing.Point(266, 272);
            this.UpdatePrd.Name = "UpdatePrd";
            this.UpdatePrd.Size = new System.Drawing.Size(75, 23);
            this.UpdatePrd.TabIndex = 7;
            this.UpdatePrd.Text = "Update";
            this.UpdatePrd.UseVisualStyleBackColor = true;
            this.UpdatePrd.Click += new System.EventHandler(this.UpdatePrd_Click);
            // 
            // UpdateProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 312);
            this.Controls.Add(this.UpdatePrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUpdateProdi);
            this.Name = "UpdateProdi";
            this.Text = "Update Prodi";
            this.Load += new System.EventHandler(this.UpdateProdi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgUpdateProdi;
        private System.Windows.Forms.Button UpdatePrd;
    }
}