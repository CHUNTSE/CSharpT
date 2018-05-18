namespace wk8
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TatomPen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Truler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TliWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerfertName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtomPen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfectone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PerfertName,
            this.AtomPen,
            this.Pen,
            this.Eraser,
            this.Ruler,
            this.LiWhite,
            this.Perfectone});
            this.dataGridView1.Location = new System.Drawing.Point(75, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TatomPen,
            this.Tpen,
            this.Teraser,
            this.Truler,
            this.TliWhite});
            this.dataGridView2.Location = new System.Drawing.Point(75, 177);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(748, 144);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "最佳業務員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "最佳產品";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "顯示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TatomPen
            // 
            this.TatomPen.DataPropertyName = "AtomPen";
            this.TatomPen.HeaderText = "原子筆";
            this.TatomPen.Name = "TatomPen";
            this.TatomPen.ReadOnly = true;
            // 
            // Tpen
            // 
            this.Tpen.DataPropertyName = "Pen";
            this.Tpen.HeaderText = "鉛筆";
            this.Tpen.Name = "Tpen";
            this.Tpen.ReadOnly = true;
            // 
            // Teraser
            // 
            this.Teraser.DataPropertyName = "Eraser";
            this.Teraser.HeaderText = "橡皮擦";
            this.Teraser.Name = "Teraser";
            this.Teraser.ReadOnly = true;
            // 
            // Truler
            // 
            this.Truler.DataPropertyName = "Ruler";
            this.Truler.HeaderText = "直尺";
            this.Truler.Name = "Truler";
            this.Truler.ReadOnly = true;
            // 
            // TliWhite
            // 
            this.TliWhite.DataPropertyName = "LiWhite";
            this.TliWhite.HeaderText = "立可白";
            this.TliWhite.Name = "TliWhite";
            this.TliWhite.ReadOnly = true;
            // 
            // PerfertName
            // 
            this.PerfertName.DataPropertyName = "PerfectName";
            this.PerfertName.HeaderText = "業務員";
            this.PerfertName.Name = "PerfertName";
            this.PerfertName.ReadOnly = true;
            // 
            // AtomPen
            // 
            this.AtomPen.DataPropertyName = "AtomPen";
            this.AtomPen.HeaderText = "原子筆";
            this.AtomPen.Name = "AtomPen";
            this.AtomPen.ReadOnly = true;
            // 
            // Pen
            // 
            this.Pen.DataPropertyName = "Pen";
            this.Pen.HeaderText = "鉛筆";
            this.Pen.Name = "Pen";
            this.Pen.ReadOnly = true;
            // 
            // Eraser
            // 
            this.Eraser.DataPropertyName = "Eraser";
            this.Eraser.HeaderText = "橡皮擦";
            this.Eraser.Name = "Eraser";
            this.Eraser.ReadOnly = true;
            // 
            // Ruler
            // 
            this.Ruler.DataPropertyName = "Ruler";
            this.Ruler.HeaderText = "直尺";
            this.Ruler.Name = "Ruler";
            this.Ruler.ReadOnly = true;
            // 
            // LiWhite
            // 
            this.LiWhite.DataPropertyName = "LiWhite";
            this.LiWhite.HeaderText = "立可白";
            this.LiWhite.Name = "LiWhite";
            this.LiWhite.ReadOnly = true;
            // 
            // Perfectone
            // 
            this.Perfectone.DataPropertyName = "Perfectone";
            this.Perfectone.HeaderText = "總銷售";
            this.Perfectone.Name = "Perfectone";
            this.Perfectone.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TatomPen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truler;
        private System.Windows.Forms.DataGridViewTextBoxColumn TliWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerfertName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtomPen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruler;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfectone;
    }
}

