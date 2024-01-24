namespace OBS
{
    partial class frm_Menu
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
            this.btn_OgrenciGirisi = new System.Windows.Forms.Button();
            this.btn_OgretmenGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Bilgi Sistemi";
            // 
            // btn_OgrenciGirisi
            // 
            this.btn_OgrenciGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OgrenciGirisi.Location = new System.Drawing.Point(19, 84);
            this.btn_OgrenciGirisi.Name = "btn_OgrenciGirisi";
            this.btn_OgrenciGirisi.Size = new System.Drawing.Size(230, 149);
            this.btn_OgrenciGirisi.TabIndex = 1;
            this.btn_OgrenciGirisi.Text = "Öğrenci Girişi";
            this.btn_OgrenciGirisi.UseVisualStyleBackColor = true;
            this.btn_OgrenciGirisi.Click += new System.EventHandler(this.btn_OgrenciGirisi_Click);
            // 
            // btn_OgretmenGirisi
            // 
            this.btn_OgretmenGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OgretmenGirisi.Location = new System.Drawing.Point(263, 84);
            this.btn_OgretmenGirisi.Name = "btn_OgretmenGirisi";
            this.btn_OgretmenGirisi.Size = new System.Drawing.Size(230, 149);
            this.btn_OgretmenGirisi.TabIndex = 2;
            this.btn_OgretmenGirisi.Text = "Öğretmen Girişi";
            this.btn_OgretmenGirisi.UseVisualStyleBackColor = true;
            this.btn_OgretmenGirisi.Click += new System.EventHandler(this.btn_OgretmenGirisi_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 244);
            this.Controls.Add(this.btn_OgretmenGirisi);
            this.Controls.Add(this.btn_OgrenciGirisi);
            this.Controls.Add(this.label1);
            this.Name = "frm_Menu";
            this.Text = "Ana Menü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OgrenciGirisi;
        private System.Windows.Forms.Button btn_OgretmenGirisi;
    }
}

