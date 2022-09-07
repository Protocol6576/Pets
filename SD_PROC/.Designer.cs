namespace SD_PROC
{
    partial class Sd_procedure
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sd_procedure));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deleteProcToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.submitProcButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.allToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yellowFilterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redFilterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exelImportToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 90;
            this.dataGridView1.Size = new System.Drawing.Size(1809, 733);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteProcToolStripButton,
            this.submitProcButton,
            this.toolStripSeparator1,
            this.allToolStripButton,
            this.yellowFilterToolStripButton,
            this.redFilterToolStripButton,
            this.toolStripSeparator2,
            this.exelImportToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1809, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // deleteProcToolStripButton
            // 
            this.deleteProcToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteProcToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteProcToolStripButton.Image")));
            this.deleteProcToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteProcToolStripButton.Name = "deleteProcToolStripButton";
            this.deleteProcToolStripButton.Size = new System.Drawing.Size(117, 22);
            this.deleteProcToolStripButton.Text = "Удалить процедуру";
            this.deleteProcToolStripButton.Click += new System.EventHandler(this.deleteProcToolStripButton_Click);
            // 
            // submitProcButton
            // 
            this.submitProcButton.AutoSize = false;
            this.submitProcButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.submitProcButton.Image = ((System.Drawing.Image)(resources.GetObject("submitProcButton.Image")));
            this.submitProcButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.submitProcButton.Name = "submitProcButton";
            this.submitProcButton.Size = new System.Drawing.Size(150, 22);
            this.submitProcButton.Text = "Подать на согласование";
            this.submitProcButton.Click += new System.EventHandler(this.submitProcButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // allToolStripButton
            // 
            this.allToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.allToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("allToolStripButton.Image")));
            this.allToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.allToolStripButton.Name = "allToolStripButton";
            this.allToolStripButton.Size = new System.Drawing.Size(32, 22);
            this.allToolStripButton.Text = "ВСЕ";
            this.allToolStripButton.Click += new System.EventHandler(this.allToolStripButton_Click);
            // 
            // yellowFilterToolStripButton
            // 
            this.yellowFilterToolStripButton.AutoSize = false;
            this.yellowFilterToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yellowFilterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.yellowFilterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("yellowFilterToolStripButton.Image")));
            this.yellowFilterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yellowFilterToolStripButton.Name = "yellowFilterToolStripButton";
            this.yellowFilterToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.yellowFilterToolStripButton.Text = "На согл.";
            this.yellowFilterToolStripButton.Click += new System.EventHandler(this.yellowFilterToolStripButton_Click);
            // 
            // redFilterToolStripButton
            // 
            this.redFilterToolStripButton.AutoSize = false;
            this.redFilterToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.redFilterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.redFilterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redFilterToolStripButton.Image")));
            this.redFilterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redFilterToolStripButton.Name = "redFilterToolStripButton";
            this.redFilterToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.redFilterToolStripButton.Text = "В отделе";
            this.redFilterToolStripButton.Click += new System.EventHandler(this.redFilterToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // exelImportToolStripButton
            // 
            this.exelImportToolStripButton.AutoSize = false;
            this.exelImportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exelImportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exelImportToolStripButton.Image")));
            this.exelImportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exelImportToolStripButton.Name = "exelImportToolStripButton";
            this.exelImportToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.exelImportToolStripButton.Text = "В excel";
            this.exelImportToolStripButton.Click += new System.EventHandler(this.exelImportToolStripButton_Click);
            // 
            // Sd_procedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 761);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sd_procedure";
            this.Text = "Процедуры согласования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sd_procedure_FormClosing);
            this.Load += new System.EventHandler(this.Sd_procedure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton submitProcButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton yellowFilterToolStripButton;
        private System.Windows.Forms.ToolStripButton redFilterToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exelImportToolStripButton;
        private System.Windows.Forms.ToolStripButton allToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteProcToolStripButton;
    }
}

