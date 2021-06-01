namespace v1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Modify_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.ShowAll_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "전번 :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(56, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 21);
            this.tbName.TabIndex = 2;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(56, 105);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(150, 21);
            this.tbPhoneNumber.TabIndex = 3;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(14, 150);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(192, 46);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "추가";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modify_button
            // 
            this.Modify_button.Location = new System.Drawing.Point(14, 212);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(75, 23);
            this.Modify_button.TabIndex = 5;
            this.Modify_button.Text = "수정";
            this.Modify_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(131, 212);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 6;
            this.Delete_button.Text = "삭제";
            this.Delete_button.UseVisualStyleBackColor = true;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(14, 265);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 7;
            this.Search_button.Text = "검색";
            this.Search_button.UseVisualStyleBackColor = true;
            // 
            // ShowAll_button
            // 
            this.ShowAll_button.Location = new System.Drawing.Point(131, 265);
            this.ShowAll_button.Name = "ShowAll_button";
            this.ShowAll_button.Size = new System.Drawing.Size(75, 23);
            this.ShowAll_button.TabIndex = 8;
            this.ShowAll_button.Text = "전체출력";
            this.ShowAll_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 330);
            this.Controls.Add(this.ShowAll_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Modify_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Modify_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button ShowAll_button;
    }
}

