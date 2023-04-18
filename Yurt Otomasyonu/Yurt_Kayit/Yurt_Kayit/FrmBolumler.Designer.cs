namespace Yurt_Kayit
{
    partial class FrmBolumler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcbKaydet = new System.Windows.Forms.PictureBox();
            this.PcbGüncelle = new System.Windows.Forms.PictureBox();
            this.PcbSil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumİD = new System.Windows.Forms.TextBox();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yürtKayitDataSet = new Yurt_Kayit.YürtKayitDataSet();
            this.bolumlerTableAdapter = new Yurt_Kayit.YürtKayitDataSetTableAdapters.BolumlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PcbKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGüncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yürtKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbKaydet
            // 
            this.PcbKaydet.Image = ((System.Drawing.Image)(resources.GetObject("PcbKaydet.Image")));
            this.PcbKaydet.Location = new System.Drawing.Point(12, 12);
            this.PcbKaydet.Name = "PcbKaydet";
            this.PcbKaydet.Size = new System.Drawing.Size(65, 63);
            this.PcbKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbKaydet.TabIndex = 0;
            this.PcbKaydet.TabStop = false;
            this.PcbKaydet.Click += new System.EventHandler(this.PcbKaydet_Click);
            // 
            // PcbGüncelle
            // 
            this.PcbGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("PcbGüncelle.Image")));
            this.PcbGüncelle.Location = new System.Drawing.Point(12, 155);
            this.PcbGüncelle.Name = "PcbGüncelle";
            this.PcbGüncelle.Size = new System.Drawing.Size(65, 66);
            this.PcbGüncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGüncelle.TabIndex = 1;
            this.PcbGüncelle.TabStop = false;
            // 
            // PcbSil
            // 
            this.PcbSil.Image = ((System.Drawing.Image)(resources.GetObject("PcbSil.Image")));
            this.PcbSil.Location = new System.Drawing.Point(12, 81);
            this.PcbSil.Name = "PcbSil";
            this.PcbSil.Size = new System.Drawing.Size(65, 68);
            this.PcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbSil.TabIndex = 2;
            this.PcbSil.TabStop = false;
            this.PcbSil.Click += new System.EventHandler(this.PcbSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm İD:";
            // 
            // TxtBolumİD
            // 
            this.TxtBolumİD.Location = new System.Drawing.Point(244, 72);
            this.TxtBolumİD.Name = "TxtBolumİD";
            this.TxtBolumİD.Size = new System.Drawing.Size(190, 25);
            this.TxtBolumİD.TabIndex = 4;
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Location = new System.Drawing.Point(244, 114);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(190, 25);
            this.TxtBolumAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 289);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yürtKayitDataSet;
            // 
            // yürtKayitDataSet
            // 
            this.yürtKayitDataSet.DataSetName = "YürtKayitDataSet";
            this.yürtKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumİD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbSil);
            this.Controls.Add(this.PcbGüncelle);
            this.Controls.Add(this.PcbKaydet);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGüncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yürtKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbKaydet;
        private System.Windows.Forms.PictureBox PcbGüncelle;
        private System.Windows.Forms.PictureBox PcbSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumİD;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YürtKayitDataSet yürtKayitDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YürtKayitDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
    }
}