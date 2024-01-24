namespace OBS
{
    partial class frm_OgrenciBilgiEkrani
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_List
            // 
            this.dataGrid_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_List.Location = new System.Drawing.Point(12, 12);
            this.dataGrid_List.Name = "dataGrid_List";
            this.dataGrid_List.Size = new System.Drawing.Size(1211, 372);
            this.dataGrid_List.TabIndex = 5;
            // 
            // frm_OgrenciBilgiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 403);
            this.Controls.Add(this.dataGrid_List);
            this.Name = "frm_OgrenciBilgiEkrani";
            this.Text = "frm_OgrenciBilgiEkrani";
            this.Load += new System.EventHandler(this.frm_OgrenciBilgiEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_List;
    }
}