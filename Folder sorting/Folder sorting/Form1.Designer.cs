namespace Folder_sorting
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openfolder = new System.Windows.Forms.Button();
            this.folder_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chen_modify = new System.Windows.Forms.Button();
            this.execute = new System.Windows.Forms.Button();
            this.Current_folder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openfolder
            // 
            this.openfolder.Location = new System.Drawing.Point(6, 20);
            this.openfolder.Name = "openfolder";
            this.openfolder.Size = new System.Drawing.Size(75, 23);
            this.openfolder.TabIndex = 0;
            this.openfolder.Text = "打开文件夹";
            this.openfolder.UseVisualStyleBackColor = true;
            this.openfolder.Click += new System.EventHandler(this.openfolder_Click);
            // 
            // folder_listView
            // 
            this.folder_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.folder_listView.FullRowSelect = true;
            this.folder_listView.HideSelection = false;
            this.folder_listView.Location = new System.Drawing.Point(12, 188);
            this.folder_listView.Name = "folder_listView";
            this.folder_listView.Size = new System.Drawing.Size(491, 409);
            this.folder_listView.TabIndex = 1;
            this.folder_listView.UseCompatibleStateImageBehavior = false;
            this.folder_listView.View = System.Windows.Forms.View.Details;
            this.folder_listView.Click += new System.EventHandler(this.folder_listView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 242;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "预览";
            this.columnHeader2.Width = 242;
            // 
            // Chen_modify
            // 
            this.Chen_modify.Location = new System.Drawing.Point(6, 20);
            this.Chen_modify.Name = "Chen_modify";
            this.Chen_modify.Size = new System.Drawing.Size(75, 23);
            this.Chen_modify.TabIndex = 2;
            this.Chen_modify.Text = "陈氏修改";
            this.Chen_modify.UseVisualStyleBackColor = true;
            this.Chen_modify.Click += new System.EventHandler(this.Chen_modify_Click);
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(6, 20);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(75, 23);
            this.execute.TabIndex = 3;
            this.execute.Text = "执行修改";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // Current_folder
            // 
            this.Current_folder.Location = new System.Drawing.Point(111, 20);
            this.Current_folder.Name = "Current_folder";
            this.Current_folder.Size = new System.Drawing.Size(75, 23);
            this.Current_folder.TabIndex = 4;
            this.Current_folder.Text = "当前文件夹";
            this.Current_folder.UseVisualStyleBackColor = true;
            this.Current_folder.Click += new System.EventHandler(this.Current_folder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openfolder);
            this.groupBox1.Controls.Add(this.Current_folder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第一步：打开文件夹";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Chen_modify);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第二步：预览修改";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.execute);
            this.groupBox3.Location = new System.Drawing.Point(12, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 49);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "第三步：执行修改";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.folder_listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "文件夹整理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openfolder;
        private System.Windows.Forms.ListView folder_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Chen_modify;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button Current_folder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

