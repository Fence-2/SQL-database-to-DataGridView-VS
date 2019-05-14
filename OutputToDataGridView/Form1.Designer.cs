namespace OutputToDataGridView
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fac_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fac_name_full = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fac_name_abbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fac_id,
            this.fac_name_full,
            this.fac_name_abbr});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // fac_id
            // 
            this.fac_id.HeaderText = "fac_id";
            this.fac_id.Name = "fac_id";
            this.fac_id.Width = 50;
            // 
            // fac_name_full
            // 
            this.fac_name_full.HeaderText = "fac_name_full";
            this.fac_name_full.Name = "fac_name_full";
            this.fac_name_full.Width = 250;
            // 
            // fac_name_abbr
            // 
            this.fac_name_abbr.HeaderText = "fac_name_abbr";
            this.fac_name_abbr.Name = "fac_name_abbr";
            this.fac_name_abbr.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 531);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Вывод данных в DataGridView (SQL)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fac_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fac_name_full;
        private System.Windows.Forms.DataGridViewTextBoxColumn fac_name_abbr;
    }
}

