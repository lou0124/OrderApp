namespace OrderServer
{
    partial class HomeForm
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
            this.orderModeButton = new System.Windows.Forms.Button();
            this.modifyModeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderModeButton
            // 
            this.orderModeButton.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderModeButton.Location = new System.Drawing.Point(12, 12);
            this.orderModeButton.Name = "orderModeButton";
            this.orderModeButton.Size = new System.Drawing.Size(374, 277);
            this.orderModeButton.TabIndex = 0;
            this.orderModeButton.Text = "주문모드";
            this.orderModeButton.UseVisualStyleBackColor = true;
            this.orderModeButton.Click += new System.EventHandler(this.orderModeButton_Click);
            // 
            // modifyModeButton
            // 
            this.modifyModeButton.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modifyModeButton.Location = new System.Drawing.Point(414, 12);
            this.modifyModeButton.Name = "modifyModeButton";
            this.modifyModeButton.Size = new System.Drawing.Size(374, 277);
            this.modifyModeButton.TabIndex = 1;
            this.modifyModeButton.Text = "수정모드";
            this.modifyModeButton.UseVisualStyleBackColor = true;
            this.modifyModeButton.Click += new System.EventHandler(this.modifyModeButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifyModeButton);
            this.Controls.Add(this.orderModeButton);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orderModeButton;
        private System.Windows.Forms.Button modifyModeButton;
    }
}

