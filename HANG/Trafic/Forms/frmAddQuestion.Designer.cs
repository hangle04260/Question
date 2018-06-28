namespace Trafic.Forms
{
    partial class frmAddQuestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuestionNumber = new DevExpress.XtraEditors.CalcEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.cboDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.chkImage = new System.Windows.Forms.CheckBox();
            this.cboQuestionNumber = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.txtResult1 = new DevExpress.XtraEditors.MemoEdit();
            this.txtResult2 = new DevExpress.XtraEditors.MemoEdit();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.txtResult4 = new DevExpress.XtraEditors.MemoEdit();
            this.lblResult4 = new System.Windows.Forms.Label();
            this.txtResult3 = new DevExpress.XtraEditors.MemoEdit();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.chkResult1 = new System.Windows.Forms.CheckBox();
            this.chkResult2 = new System.Windows.Forms.CheckBox();
            this.chkResult3 = new System.Windows.Forms.CheckBox();
            this.chkResult4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuestionNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Câu hỏi số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung câu hỏi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng ban";
            // 
            // txtQuestionNumber
            // 
            this.txtQuestionNumber.Location = new System.Drawing.Point(320, 34);
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.Size = new System.Drawing.Size(242, 40);
            this.txtQuestionNumber.TabIndex = 3;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(320, 95);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(1352, 233);
            this.memoEdit1.TabIndex = 4;
            // 
            // cboDepartment
            // 
            this.cboDepartment.Location = new System.Drawing.Point(320, 354);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.Properties.Appearance.Options.UseFont = true;
            this.cboDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDepartment.Properties.NullText = "";
            this.cboDepartment.Size = new System.Drawing.Size(575, 54);
            this.cboDepartment.TabIndex = 6;
            // 
            // chkImage
            // 
            this.chkImage.AutoSize = true;
            this.chkImage.Location = new System.Drawing.Point(320, 442);
            this.chkImage.Name = "chkImage";
            this.chkImage.Size = new System.Drawing.Size(250, 36);
            this.chkImage.TabIndex = 7;
            this.chkImage.Text = "Câu hỏi có hình";
            this.chkImage.UseVisualStyleBackColor = true;
            // 
            // cboQuestionNumber
            // 
            this.cboQuestionNumber.Location = new System.Drawing.Point(1150, 358);
            this.cboQuestionNumber.Name = "cboQuestionNumber";
            this.cboQuestionNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuestionNumber.Properties.Appearance.Options.UseFont = true;
            this.cboQuestionNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQuestionNumber.Properties.NullText = "";
            this.cboQuestionNumber.Size = new System.Drawing.Size(288, 54);
            this.cboQuestionNumber.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(941, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số câu trả lời";
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(50, 512);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(129, 32);
            this.lblResult1.TabIndex = 10;
            this.lblResult1.Text = "Đáp án 1";
            // 
            // txtResult1
            // 
            this.txtResult1.Location = new System.Drawing.Point(320, 508);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.Size = new System.Drawing.Size(1118, 103);
            this.txtResult1.TabIndex = 11;
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(320, 630);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(1118, 106);
            this.txtResult2.TabIndex = 13;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(50, 641);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(129, 32);
            this.lblResult2.TabIndex = 12;
            this.lblResult2.Text = "Đáp án 2";
            // 
            // txtResult4
            // 
            this.txtResult4.Location = new System.Drawing.Point(320, 882);
            this.txtResult4.Name = "txtResult4";
            this.txtResult4.Size = new System.Drawing.Size(1118, 106);
            this.txtResult4.TabIndex = 17;
            // 
            // lblResult4
            // 
            this.lblResult4.AutoSize = true;
            this.lblResult4.Location = new System.Drawing.Point(50, 915);
            this.lblResult4.Name = "lblResult4";
            this.lblResult4.Size = new System.Drawing.Size(129, 32);
            this.lblResult4.TabIndex = 16;
            this.lblResult4.Text = "Đáp án 4";
            // 
            // txtResult3
            // 
            this.txtResult3.Location = new System.Drawing.Point(320, 760);
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.Size = new System.Drawing.Size(1118, 103);
            this.txtResult3.TabIndex = 15;
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.Location = new System.Drawing.Point(50, 771);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(129, 32);
            this.lblResult3.TabIndex = 14;
            this.lblResult3.Text = "Đáp án 3";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(320, 1011);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 64);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "&Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(526, 1011);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 64);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "&Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkResult1
            // 
            this.chkResult1.AutoSize = true;
            this.chkResult1.Location = new System.Drawing.Point(1457, 508);
            this.chkResult1.Name = "chkResult1";
            this.chkResult1.Size = new System.Drawing.Size(215, 36);
            this.chkResult1.TabIndex = 20;
            this.chkResult1.Text = "Đáp án đúng";
            this.chkResult1.UseVisualStyleBackColor = true;
            // 
            // chkResult2
            // 
            this.chkResult2.AutoSize = true;
            this.chkResult2.Location = new System.Drawing.Point(1457, 631);
            this.chkResult2.Name = "chkResult2";
            this.chkResult2.Size = new System.Drawing.Size(215, 36);
            this.chkResult2.TabIndex = 21;
            this.chkResult2.Text = "Đáp án đúng";
            this.chkResult2.UseVisualStyleBackColor = true;
            // 
            // chkResult3
            // 
            this.chkResult3.AutoSize = true;
            this.chkResult3.Location = new System.Drawing.Point(1457, 761);
            this.chkResult3.Name = "chkResult3";
            this.chkResult3.Size = new System.Drawing.Size(215, 36);
            this.chkResult3.TabIndex = 22;
            this.chkResult3.Text = "Đáp án đúng";
            this.chkResult3.UseVisualStyleBackColor = true;
            // 
            // chkResult4
            // 
            this.chkResult4.AutoSize = true;
            this.chkResult4.Location = new System.Drawing.Point(1457, 883);
            this.chkResult4.Name = "chkResult4";
            this.chkResult4.Size = new System.Drawing.Size(215, 36);
            this.chkResult4.TabIndex = 23;
            this.chkResult4.Text = "Đáp án đúng";
            this.chkResult4.UseVisualStyleBackColor = true;
            // 
            // frmAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 1113);
            this.Controls.Add(this.chkResult4);
            this.Controls.Add(this.chkResult3);
            this.Controls.Add(this.chkResult2);
            this.Controls.Add(this.chkResult1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtResult4);
            this.Controls.Add(this.lblResult4);
            this.Controls.Add(this.txtResult3);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.txtResult1);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.cboQuestionNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkImage);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.txtQuestionNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddQuestion";
            this.Text = "THÊM CÂU HỎI";
            this.Load += new System.EventHandler(this.frmAddQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuestionNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CalcEdit txtQuestionNumber;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LookUpEdit cboDepartment;
        private System.Windows.Forms.CheckBox chkImage;
        private DevExpress.XtraEditors.LookUpEdit cboQuestionNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult1;
        private DevExpress.XtraEditors.MemoEdit txtResult1;
        private DevExpress.XtraEditors.MemoEdit txtResult2;
        private System.Windows.Forms.Label lblResult2;
        private DevExpress.XtraEditors.MemoEdit txtResult4;
        private System.Windows.Forms.Label lblResult4;
        private DevExpress.XtraEditors.MemoEdit txtResult3;
        private System.Windows.Forms.Label lblResult3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.CheckBox chkResult1;
        private System.Windows.Forms.CheckBox chkResult2;
        private System.Windows.Forms.CheckBox chkResult3;
        private System.Windows.Forms.CheckBox chkResult4;
    }
}