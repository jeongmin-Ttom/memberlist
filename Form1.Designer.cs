namespace memberlist
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Check_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Modify_B = new System.Windows.Forms.Button();
            this.Add_B = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhoneText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NameText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정보";
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(71, 65);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(164, 28);
            this.PhoneText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "번호";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(71, 27);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(164, 28);
            this.NameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.Check_B);
            this.groupBox2.Controls.Add(this.Delete_B);
            this.groupBox2.Controls.Add(this.Modify_B);
            this.groupBox2.Controls.Add(this.Add_B);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(13, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "조회 및 제어";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(417, 325);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Number";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.Width = 298;
            // 
            // Check_B
            // 
            this.Check_B.Location = new System.Drawing.Point(324, 27);
            this.Check_B.Name = "Check_B";
            this.Check_B.Size = new System.Drawing.Size(100, 50);
            this.Check_B.TabIndex = 0;
            this.Check_B.Text = "조회";
            this.Check_B.UseVisualStyleBackColor = true;
            this.Check_B.Click += new System.EventHandler(this.Check_B_Click);
            // 
            // Delete_B
            // 
            this.Delete_B.Location = new System.Drawing.Point(218, 27);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(100, 50);
            this.Delete_B.TabIndex = 0;
            this.Delete_B.Text = "삭제";
            this.Delete_B.UseVisualStyleBackColor = true;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // Modify_B
            // 
            this.Modify_B.Location = new System.Drawing.Point(112, 27);
            this.Modify_B.Name = "Modify_B";
            this.Modify_B.Size = new System.Drawing.Size(100, 50);
            this.Modify_B.TabIndex = 0;
            this.Modify_B.Text = "수정";
            this.Modify_B.UseVisualStyleBackColor = true;
            this.Modify_B.Click += new System.EventHandler(this.Modify_B_Click);
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(6, 27);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(100, 50);
            this.Add_B.TabIndex = 0;
            this.Add_B.Text = "추가";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(171, 9);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(54, 18);
            this.Time.TabIndex = 1;
            this.Time.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(461, 592);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Check_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button Modify_B;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

