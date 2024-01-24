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
            this.dataGrid_List.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_List_CellEndEdit);
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
            // frm_OgretmenNotGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1239, 450);
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
    }
}