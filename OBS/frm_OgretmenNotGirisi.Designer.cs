namespace OBS
{
    partial class frm_OgretmenNotGirisi
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
            this.dataGrid_List = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Brans = new System.Windows.Forms.ComboBox();
            this.cmb_Sinif = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OgrListele = new System.Windows.Forms.Button();
            this.btn_OgrKaydet = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_List
            // 
            this.dataGrid_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_List.Location = new System.Drawing.Point(12, 66);
            this.dataGrid_List.Name = "dataGrid_List";
            this.dataGrid_List.Size = new System.Drawing.Size(1215, 372);
            this.dataGrid_List.TabIndex = 0;
            this.dataGrid_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_List_CellClick);
            this.dataGrid_List.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_List_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders Seçiniz: ";
            // 
            // cmb_Brans
            // 
            this.cmb_Brans.FormattingEnabled = true;
            this.cmb_Brans.Location = new System.Drawing.Point(93, 39);
            this.cmb_Brans.Name = "cmb_Brans";
            this.cmb_Brans.Size = new System.Drawing.Size(121, 21);
            this.cmb_Brans.TabIndex = 2;
            this.cmb_Brans.SelectedIndexChanged += new System.EventHandler(this.cmb_Brans_SelectedIndexChanged);
            // 
            // cmb_Sinif
            // 
            this.cmb_Sinif.AutoCompleteCustomSource.AddRange(new string[] {
            "9",
            "10",
            "11",
            "12"});
            this.cmb_Sinif.FormattingEnabled = true;
            this.cmb_Sinif.Location = new System.Drawing.Point(93, 12);
            this.cmb_Sinif.Name = "cmb_Sinif";
            this.cmb_Sinif.Size = new System.Drawing.Size(121, 21);
            this.cmb_Sinif.TabIndex = 4;
            this.cmb_Sinif.SelectedIndexChanged += new System.EventHandler(this.cmb_Sinif_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sınıf Seçiniz:";
            // 
            // btn_OgrListele
            // 
            this.btn_OgrListele.Location = new System.Drawing.Point(12, 444);
            this.btn_OgrListele.Name = "btn_OgrListele";
            this.btn_OgrListele.Size = new System.Drawing.Size(120, 23);
            this.btn_OgrListele.TabIndex = 5;
            this.btn_OgrListele.Text = "Öğrencileri Listele";
            this.btn_OgrListele.UseVisualStyleBackColor = true;
            this.btn_OgrListele.Click += new System.EventHandler(this.btn_OgrListele_Click);
            // 
            // btn_OgrKaydet
            // 
            this.btn_OgrKaydet.Location = new System.Drawing.Point(138, 444);
            this.btn_OgrKaydet.Name = "btn_OgrKaydet";
            this.btn_OgrKaydet.Size = new System.Drawing.Size(120, 23);
            this.btn_OgrKaydet.TabIndex = 6;
            this.btn_OgrKaydet.Text = "Öğrencileri Kaydet";
            this.btn_OgrKaydet.UseVisualStyleBackColor = true;
            this.btn_OgrKaydet.Click += new System.EventHandler(this.btn_OgrKaydet_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 473);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sınıf Seçiniz:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 500);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ders Seçiniz: ";
            // 
            // frm_OgretmenNotGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1239, 618);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_OgrKaydet);
            this.Controls.Add(this.btn_OgrListele);
            this.Controls.Add(this.cmb_Sinif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Brans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_List);
            this.Name = "frm_OgretmenNotGirisi";
            this.Text = "Öğretmen Not Girişi";
            this.Load += new System.EventHandler(this.frm_OgretmenNotGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Brans;
        private System.Windows.Forms.ComboBox cmb_Sinif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OgrListele;
        private System.Windows.Forms.Button btn_OgrKaydet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
    }
}