namespace AskForLeave
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseStu = new System.Windows.Forms.Button();
            this.btnDeleteStu = new System.Windows.Forms.Button();
            this.btnReloadStu = new System.Windows.Forms.Button();
            this.btnLoadStu = new System.Windows.Forms.Button();
            this.dgvStu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combTea = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnResetStu = new System.Windows.Forms.Button();
            this.btnCreateStu = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLinqStu = new System.Windows.Forms.Button();
            this.txtLinqStu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCreateTea = new System.Windows.Forms.Button();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLinqTea = new System.Windows.Forms.Button();
            this.txtLinqTea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCloseTea = new System.Windows.Forms.Button();
            this.btnDeleteTea = new System.Windows.Forms.Button();
            this.btnReloadTea = new System.Windows.Forms.Button();
            this.btnLoadTea = new System.Windows.Forms.Button();
            this.dgvTea = new System.Windows.Forms.DataGridView();
            this.btnCreateMD5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTea)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateMD5);
            this.groupBox1.Controls.Add(this.btnCloseStu);
            this.groupBox1.Controls.Add(this.btnDeleteStu);
            this.groupBox1.Controls.Add(this.btnReloadStu);
            this.groupBox1.Controls.Add(this.btnLoadStu);
            this.groupBox1.Controls.Add(this.dgvStu);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生表";
            // 
            // btnCloseStu
            // 
            this.btnCloseStu.Location = new System.Drawing.Point(300, 301);
            this.btnCloseStu.Name = "btnCloseStu";
            this.btnCloseStu.Size = new System.Drawing.Size(75, 30);
            this.btnCloseStu.TabIndex = 4;
            this.btnCloseStu.Text = "关闭";
            this.btnCloseStu.UseVisualStyleBackColor = true;
            this.btnCloseStu.Click += new System.EventHandler(this.btnCloseStu_Click);
            // 
            // btnDeleteStu
            // 
            this.btnDeleteStu.Location = new System.Drawing.Point(206, 301);
            this.btnDeleteStu.Name = "btnDeleteStu";
            this.btnDeleteStu.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteStu.TabIndex = 3;
            this.btnDeleteStu.Text = "删除";
            this.btnDeleteStu.UseVisualStyleBackColor = true;
            this.btnDeleteStu.Click += new System.EventHandler(this.btnDeleteStu_Click);
            // 
            // btnReloadStu
            // 
            this.btnReloadStu.Location = new System.Drawing.Point(112, 301);
            this.btnReloadStu.Name = "btnReloadStu";
            this.btnReloadStu.Size = new System.Drawing.Size(75, 30);
            this.btnReloadStu.TabIndex = 2;
            this.btnReloadStu.Text = "更新";
            this.btnReloadStu.UseVisualStyleBackColor = true;
            this.btnReloadStu.Click += new System.EventHandler(this.btnReloadStu_Click);
            // 
            // btnLoadStu
            // 
            this.btnLoadStu.Location = new System.Drawing.Point(20, 301);
            this.btnLoadStu.Name = "btnLoadStu";
            this.btnLoadStu.Size = new System.Drawing.Size(75, 30);
            this.btnLoadStu.TabIndex = 1;
            this.btnLoadStu.Text = "加载";
            this.btnLoadStu.UseVisualStyleBackColor = true;
            this.btnLoadStu.Click += new System.EventHandler(this.btnLoadStu_Click);
            // 
            // dgvStu
            // 
            this.dgvStu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStu.Location = new System.Drawing.Point(3, 21);
            this.dgvStu.Name = "dgvStu";
            this.dgvStu.RowTemplate.Height = 27;
            this.dgvStu.Size = new System.Drawing.Size(676, 261);
            this.dgvStu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combTea);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnResetStu);
            this.groupBox2.Controls.Add(this.btnCreateStu);
            this.groupBox2.Controls.Add(this.txtClass);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新增学生";
            // 
            // combTea
            // 
            this.combTea.FormattingEnabled = true;
            this.combTea.Location = new System.Drawing.Point(131, 113);
            this.combTea.Name = "combTea";
            this.combTea.Size = new System.Drawing.Size(357, 23);
            this.combTea.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "辅导员";
            // 
            // btnResetStu
            // 
            this.btnResetStu.Location = new System.Drawing.Point(541, 106);
            this.btnResetStu.Name = "btnResetStu";
            this.btnResetStu.Size = new System.Drawing.Size(75, 30);
            this.btnResetStu.TabIndex = 9;
            this.btnResetStu.Text = "重置";
            this.btnResetStu.UseVisualStyleBackColor = true;
            this.btnResetStu.Click += new System.EventHandler(this.btnResetStu_Click);
            // 
            // btnCreateStu
            // 
            this.btnCreateStu.Location = new System.Drawing.Point(541, 36);
            this.btnCreateStu.Name = "btnCreateStu";
            this.btnCreateStu.Size = new System.Drawing.Size(75, 30);
            this.btnCreateStu.TabIndex = 8;
            this.btnCreateStu.Text = "插入";
            this.btnCreateStu.UseVisualStyleBackColor = true;
            this.btnCreateStu.Click += new System.EventHandler(this.btnCreateStu_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(131, 82);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(357, 25);
            this.txtClass.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(131, 17);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(357, 25);
            this.txtNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "班级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLinqStu);
            this.groupBox3.Controls.Add(this.txtLinqStu);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(4, 536);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(682, 68);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询";
            // 
            // btnLinqStu
            // 
            this.btnLinqStu.Location = new System.Drawing.Point(541, 21);
            this.btnLinqStu.Name = "btnLinqStu";
            this.btnLinqStu.Size = new System.Drawing.Size(75, 30);
            this.btnLinqStu.TabIndex = 2;
            this.btnLinqStu.Text = "查询";
            this.btnLinqStu.UseVisualStyleBackColor = true;
            this.btnLinqStu.Click += new System.EventHandler(this.btnLinqStu_Click);
            // 
            // txtLinqStu
            // 
            this.txtLinqStu.Location = new System.Drawing.Point(131, 24);
            this.txtLinqStu.Name = "txtLinqStu";
            this.txtLinqStu.Size = new System.Drawing.Size(357, 25);
            this.txtLinqStu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMessage
            // 
            this.tsMessage.Name = "tsMessage";
            this.tsMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCreateTea);
            this.groupBox4.Controls.Add(this.txtTeacher);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(4, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(682, 85);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "新增教师";
            // 
            // btnCreateTea
            // 
            this.btnCreateTea.Location = new System.Drawing.Point(541, 30);
            this.btnCreateTea.Name = "btnCreateTea";
            this.btnCreateTea.Size = new System.Drawing.Size(75, 30);
            this.btnCreateTea.TabIndex = 2;
            this.btnCreateTea.Text = "插入";
            this.btnCreateTea.UseVisualStyleBackColor = true;
            this.btnCreateTea.Click += new System.EventHandler(this.btnCreateTea_Click);
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(131, 35);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(357, 25);
            this.txtTeacher.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "姓名";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 649);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "学生信息表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教师信息表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLinqTea);
            this.groupBox6.Controls.Add(this.txtLinqTea);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(4, 456);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(682, 100);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "查询";
            // 
            // btnLinqTea
            // 
            this.btnLinqTea.Location = new System.Drawing.Point(541, 43);
            this.btnLinqTea.Name = "btnLinqTea";
            this.btnLinqTea.Size = new System.Drawing.Size(75, 30);
            this.btnLinqTea.TabIndex = 5;
            this.btnLinqTea.Text = "查询";
            this.btnLinqTea.UseVisualStyleBackColor = true;
            this.btnLinqTea.Click += new System.EventHandler(this.btnLinqTea_Click);
            // 
            // txtLinqTea
            // 
            this.txtLinqTea.Location = new System.Drawing.Point(131, 48);
            this.txtLinqTea.Name = "txtLinqTea";
            this.txtLinqTea.Size = new System.Drawing.Size(357, 25);
            this.txtLinqTea.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "姓名";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCloseTea);
            this.groupBox5.Controls.Add(this.btnDeleteTea);
            this.groupBox5.Controls.Add(this.btnReloadTea);
            this.groupBox5.Controls.Add(this.btnLoadTea);
            this.groupBox5.Controls.Add(this.dgvTea);
            this.groupBox5.Location = new System.Drawing.Point(4, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(682, 353);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "教师表";
            // 
            // btnCloseTea
            // 
            this.btnCloseTea.Location = new System.Drawing.Point(263, 301);
            this.btnCloseTea.Name = "btnCloseTea";
            this.btnCloseTea.Size = new System.Drawing.Size(75, 30);
            this.btnCloseTea.TabIndex = 7;
            this.btnCloseTea.Text = "关闭";
            this.btnCloseTea.UseVisualStyleBackColor = true;
            this.btnCloseTea.Click += new System.EventHandler(this.btnCloseTea_Click);
            // 
            // btnDeleteTea
            // 
            this.btnDeleteTea.Location = new System.Drawing.Point(182, 301);
            this.btnDeleteTea.Name = "btnDeleteTea";
            this.btnDeleteTea.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteTea.TabIndex = 7;
            this.btnDeleteTea.Text = "删除";
            this.btnDeleteTea.UseVisualStyleBackColor = true;
            this.btnDeleteTea.Click += new System.EventHandler(this.btnDeleteTea_Click);
            // 
            // btnReloadTea
            // 
            this.btnReloadTea.Location = new System.Drawing.Point(101, 301);
            this.btnReloadTea.Name = "btnReloadTea";
            this.btnReloadTea.Size = new System.Drawing.Size(75, 30);
            this.btnReloadTea.TabIndex = 7;
            this.btnReloadTea.Text = "更新";
            this.btnReloadTea.UseVisualStyleBackColor = true;
            this.btnReloadTea.Click += new System.EventHandler(this.btnReloadTea_Click);
            // 
            // btnLoadTea
            // 
            this.btnLoadTea.Location = new System.Drawing.Point(20, 301);
            this.btnLoadTea.Name = "btnLoadTea";
            this.btnLoadTea.Size = new System.Drawing.Size(75, 30);
            this.btnLoadTea.TabIndex = 7;
            this.btnLoadTea.Text = "加载";
            this.btnLoadTea.UseVisualStyleBackColor = true;
            this.btnLoadTea.Click += new System.EventHandler(this.btnLoadTea_Click);
            // 
            // dgvTea
            // 
            this.dgvTea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTea.Location = new System.Drawing.Point(3, 21);
            this.dgvTea.Name = "dgvTea";
            this.dgvTea.RowTemplate.Height = 27;
            this.dgvTea.Size = new System.Drawing.Size(676, 261);
            this.dgvTea.TabIndex = 6;
            // 
            // btnCreateMD5
            // 
            this.btnCreateMD5.Location = new System.Drawing.Point(585, 301);
            this.btnCreateMD5.Name = "btnCreateMD5";
            this.btnCreateMD5.Size = new System.Drawing.Size(75, 30);
            this.btnCreateMD5.TabIndex = 13;
            this.btnCreateMD5.Text = "MD5";
            this.btnCreateMD5.UseVisualStyleBackColor = true;
            this.btnCreateMD5.Click += new System.EventHandler(this.btnCreateMD5_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 684);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "管理员界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCloseStu;
        private System.Windows.Forms.Button btnDeleteStu;
        private System.Windows.Forms.Button btnReloadStu;
        private System.Windows.Forms.Button btnLoadStu;
        private System.Windows.Forms.DataGridView dgvStu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnResetStu;
        private System.Windows.Forms.Button btnCreateStu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLinqStu;
        private System.Windows.Forms.TextBox txtLinqStu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCreateTea;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLinqTea;
        private System.Windows.Forms.TextBox txtLinqTea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCloseTea;
        private System.Windows.Forms.Button btnDeleteTea;
        private System.Windows.Forms.Button btnReloadTea;
        private System.Windows.Forms.Button btnLoadTea;
        private System.Windows.Forms.DataGridView dgvTea;
        private System.Windows.Forms.ToolStripStatusLabel tsMessage;
        private System.Windows.Forms.ComboBox combTea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateMD5;
    }
}