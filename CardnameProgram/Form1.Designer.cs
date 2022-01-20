namespace CardnameProgram
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxComp = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.checkBoxDelShow = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 86);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(376, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "명함 데이터";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "명함관리 프로그램";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelName.Location = new System.Drawing.Point(15, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "이름";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxName.Location = new System.Drawing.Point(70, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(87, 26);
            this.textBoxName.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.checkBoxDelShow);
            this.panel2.Controls.Add(this.labelAddress);
            this.panel2.Controls.Add(this.textBoxAddress);
            this.panel2.Controls.Add(this.labelTask);
            this.panel2.Controls.Add(this.textBoxTask);
            this.panel2.Controls.Add(this.labelTel);
            this.panel2.Controls.Add(this.textBoxTel);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelComp);
            this.panel2.Controls.Add(this.labelJob);
            this.panel2.Controls.Add(this.textBoxJob);
            this.panel2.Controls.Add(this.labelAge);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.textBoxAge);
            this.panel2.Controls.Add(this.textBoxComp);
            this.panel2.Location = new System.Drawing.Point(32, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 319);
            this.panel2.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAddress.Location = new System.Drawing.Point(15, 214);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(42, 21);
            this.labelAddress.TabIndex = 14;
            this.labelAddress.Text = "주소";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxAddress.Location = new System.Drawing.Point(70, 214);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(341, 26);
            this.textBoxAddress.TabIndex = 15;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTask.Location = new System.Drawing.Point(15, 163);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(42, 21);
            this.labelTask.TabIndex = 12;
            this.labelTask.Text = "업무";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxTask.Location = new System.Drawing.Point(70, 163);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(341, 26);
            this.textBoxTask.TabIndex = 13;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTel.Location = new System.Drawing.Point(186, 113);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(58, 21);
            this.labelTel.TabIndex = 10;
            this.labelTel.Text = "연락처";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxTel.Location = new System.Drawing.Point(261, 113);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(150, 26);
            this.textBoxTel.TabIndex = 11;
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelComp.Location = new System.Drawing.Point(15, 49);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(42, 21);
            this.labelComp.TabIndex = 3;
            this.labelComp.Text = "회사";
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelJob.Location = new System.Drawing.Point(15, 113);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(42, 21);
            this.labelJob.TabIndex = 7;
            this.labelJob.Text = "직책";
            // 
            // textBoxJob
            // 
            this.textBoxJob.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxJob.Location = new System.Drawing.Point(70, 113);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(87, 26);
            this.textBoxJob.TabIndex = 8;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAge.Location = new System.Drawing.Point(15, 81);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(42, 21);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "나이";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxAge.Location = new System.Drawing.Point(70, 81);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(87, 26);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxComp
            // 
            this.textBoxComp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxComp.Location = new System.Drawing.Point(70, 49);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(87, 26);
            this.textBoxComp.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonUpdate);
            this.panel3.Controls.Add(this.buttonDelete);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Location = new System.Drawing.Point(93, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 97);
            this.panel3.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(218, 16);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(83, 68);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "수정";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(115, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 68);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(9, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 68);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "저장";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(510, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(760, 364);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "이름",
            "회사",
            "나이",
            "직책",
            "연락처",
            "업무",
            "주소"});
            this.comboBoxSearch.Location = new System.Drawing.Point(988, 106);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(87, 24);
            this.comboBoxSearch.TabIndex = 6;
            this.comboBoxSearch.Text = "이름";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1174, 106);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 27);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxSearch.Location = new System.Drawing.Point(1081, 106);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(87, 26);
            this.textBoxSearch.TabIndex = 16;
            // 
            // checkBoxDelShow
            // 
            this.checkBoxDelShow.AutoSize = true;
            this.checkBoxDelShow.Location = new System.Drawing.Point(335, 288);
            this.checkBoxDelShow.Name = "checkBoxDelShow";
            this.checkBoxDelShow.Size = new System.Drawing.Size(76, 16);
            this.checkBoxDelShow.TabIndex = 16;
            this.checkBoxDelShow.Text = "삭제 보기";
            this.checkBoxDelShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 542);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "명함 데이터 명함관리프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.TextBox textBoxComp;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxDelShow;
    }
}

