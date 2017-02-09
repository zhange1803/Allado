namespace From1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.labCount = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_TestDemoDataSet = new From1.db_TestDemoDataSet();
            this.userInfoTableAdapter = new From1.db_TestDemoDataSetTableAdapters.UserInfoTableAdapter();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_TestDemoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(581, 97);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(73, 33);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "删除";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(477, 97);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(73, 33);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "增加";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(191, 97);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(73, 33);
            this.Btn1.TabIndex = 10;
            this.Btn1.Text = "查询";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(101, 97);
            this.TxtBox.Multiline = true;
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(84, 33);
            this.TxtBox.TabIndex = 7;
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCount.Location = new System.Drawing.Point(309, 97);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(0, 33);
            this.labCount.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(6, 97);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(111, 33);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "姓名：";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab1.Location = new System.Drawing.Point(231, 23);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(143, 33);
            this.lab1.TabIndex = 6;
            this.lab1.Text = "账户管理";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.userName,
            this.createDate,
            this.userPassword,
            this.userBirthday,
            this.userAge});
            this.dgv.Location = new System.Drawing.Point(12, 147);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(642, 355);
            this.dgv.TabIndex = 11;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "UserId";
            this.userId.HeaderText = "序列";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "UserName";
            this.userName.HeaderText = "姓名";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // createDate
            // 
            this.createDate.DataPropertyName = "CreateDate";
            this.createDate.HeaderText = "注册时间";
            this.createDate.Name = "createDate";
            this.createDate.ReadOnly = true;
            // 
            // userPassword
            // 
            this.userPassword.DataPropertyName = "UserPassword";
            this.userPassword.HeaderText = "密码";
            this.userPassword.Name = "userPassword";
            this.userPassword.ReadOnly = true;
            // 
            // userBirthday
            // 
            this.userBirthday.DataPropertyName = "UserBirthday";
            this.userBirthday.HeaderText = "出生日期";
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.ReadOnly = true;
            // 
            // userAge
            // 
            this.userAge.DataPropertyName = "UserAge";
            this.userAge.HeaderText = "年龄";
            this.userAge.Name = "userAge";
            this.userAge.ReadOnly = true;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataMember = "UserInfo";
            this.userInfoBindingSource.DataSource = this.db_TestDemoDataSet;
            // 
            // db_TestDemoDataSet
            // 
            this.db_TestDemoDataSet.DataSetName = "db_TestDemoDataSet";
            this.db_TestDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInfoTableAdapter
            // 
            this.userInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(727, 268);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(136, 21);
            this.dtp.TabIndex = 19;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(727, 230);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(136, 21);
            this.txtPwd.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(727, 186);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 21);
            this.txtName.TabIndex = 17;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(727, 147);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 21);
            this.txtId.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "出生日期：";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(680, 233);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(41, 12);
            this.password.TabIndex = 13;
            this.password.Text = "密码：";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(680, 189);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 12);
            this.name.TabIndex = 14;
            this.name.Text = "姓名：";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(680, 150);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(29, 12);
            this.id.TabIndex = 15;
            this.id.Text = "id：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 532);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_TestDemoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Btn1;
        internal System.Windows.Forms.TextBox TxtBox;
        internal System.Windows.Forms.Label labCount;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lab1;
        private System.Windows.Forms.DataGridView dgv;
        private db_TestDemoDataSet db_TestDemoDataSet;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private db_TestDemoDataSetTableAdapters.UserInfoTableAdapter userInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAge;
        public System.Windows.Forms.DateTimePicker dtp;
        public System.Windows.Forms.TextBox txtPwd;
        public System.Windows.Forms.TextBox txtName;
        protected internal System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
    }
}

