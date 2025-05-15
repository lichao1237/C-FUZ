namespace Demo
{
    partial class Form22
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.各科平均成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩排名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生成绩评语ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生成绩评语ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(981, 452);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "学号";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "课程";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "成绩";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 250F;
            this.Column4.HeaderText = "寄语";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.学生成绩统计ToolStripMenuItem,
            this.学生成绩管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 32);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 学生成绩统计ToolStripMenuItem
            // 
            this.学生成绩统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.各科平均成绩ToolStripMenuItem,
            this.学生成绩排名ToolStripMenuItem});
            this.学生成绩统计ToolStripMenuItem.Name = "学生成绩统计ToolStripMenuItem";
            this.学生成绩统计ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.学生成绩统计ToolStripMenuItem.Text = "学生成绩统计";
            // 
            // 各科平均成绩ToolStripMenuItem
            // 
            this.各科平均成绩ToolStripMenuItem.Name = "各科平均成绩ToolStripMenuItem";
            this.各科平均成绩ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.各科平均成绩ToolStripMenuItem.Text = "各科平均成绩";
            this.各科平均成绩ToolStripMenuItem.Click += new System.EventHandler(this.各科平均成绩ToolStripMenuItem_Click);
            // 
            // 学生成绩排名ToolStripMenuItem
            // 
            this.学生成绩排名ToolStripMenuItem.Name = "学生成绩排名ToolStripMenuItem";
            this.学生成绩排名ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.学生成绩排名ToolStripMenuItem.Text = "学生成绩排名";
            this.学生成绩排名ToolStripMenuItem.Click += new System.EventHandler(this.学生成绩排名ToolStripMenuItem_Click);
            // 
            // 学生成绩管理ToolStripMenuItem
            // 
            this.学生成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生成绩评语ToolStripMenuItem,
            this.修改学生成绩评语ToolStripMenuItem});
            this.学生成绩管理ToolStripMenuItem.Name = "学生成绩管理ToolStripMenuItem";
            this.学生成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.学生成绩管理ToolStripMenuItem.Text = "学生成绩管理";
            // 
            // 添加学生成绩评语ToolStripMenuItem
            // 
            this.添加学生成绩评语ToolStripMenuItem.Name = "添加学生成绩评语ToolStripMenuItem";
            this.添加学生成绩评语ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.添加学生成绩评语ToolStripMenuItem.Text = "添加学生成绩评语";
            this.添加学生成绩评语ToolStripMenuItem.Click += new System.EventHandler(this.添加学生成绩评语ToolStripMenuItem_Click);
            // 
            // 修改学生成绩评语ToolStripMenuItem
            // 
            this.修改学生成绩评语ToolStripMenuItem.Name = "修改学生成绩评语ToolStripMenuItem";
            this.修改学生成绩评语ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.修改学生成绩评语ToolStripMenuItem.Text = "修改学生成绩评语";
            this.修改学生成绩评语ToolStripMenuItem.Click += new System.EventHandler(this.修改学生成绩评语ToolStripMenuItem_Click);
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 487);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form22";
            this.Text = "学生成绩管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 系统ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 学生成绩统计ToolStripMenuItem;
        private ToolStripMenuItem 各科平均成绩ToolStripMenuItem;
        private ToolStripMenuItem 学生成绩排名ToolStripMenuItem;
        private ToolStripMenuItem 学生成绩管理ToolStripMenuItem;
        private ToolStripMenuItem 添加学生成绩评语ToolStripMenuItem;
        private ToolStripMenuItem 修改学生成绩评语ToolStripMenuItem;
    }
}