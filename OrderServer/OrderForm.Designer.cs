namespace OrderServer
{
    partial class OrderForm
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
            System.Windows.Forms.Button backButton;
            this.orderList = new System.Windows.Forms.ListView();
            this.order_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guest_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.order_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cookedButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new System.Drawing.Point(11, 398);
            backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new System.Drawing.Size(121, 41);
            backButton.TabIndex = 0;
            backButton.Text = "뒤로가기";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // orderList
            // 
            this.orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_num,
            this.guest_num,
            this.menu,
            this.count,
            this.order_time});
            this.orderList.FullRowSelect = true;
            this.orderList.HideSelection = false;
            this.orderList.Location = new System.Drawing.Point(11, 61);
            this.orderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(625, 319);
            this.orderList.TabIndex = 1;
            this.orderList.UseCompatibleStateImageBehavior = false;
            this.orderList.View = System.Windows.Forms.View.Details;
            this.orderList.SelectedIndexChanged += new System.EventHandler(this.orderList_SelectedIndexChanged);
            // 
            // order_num
            // 
            this.order_num.Text = "주문번호";
            // 
            // guest_num
            // 
            this.guest_num.Text = "손님번호";
            this.guest_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menu
            // 
            this.menu.Text = "메뉴";
            this.menu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menu.Width = 180;
            // 
            // count
            // 
            this.count.Text = "수량";
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // order_time
            // 
            this.order_time.Text = "주문시간";
            this.order_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.order_time.Width = 170;
            // 
            // cookedButton
            // 
            this.cookedButton.Location = new System.Drawing.Point(661, 61);
            this.cookedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cookedButton.Name = "cookedButton";
            this.cookedButton.Size = new System.Drawing.Size(117, 78);
            this.cookedButton.TabIndex = 2;
            this.cookedButton.Text = "조리완료";
            this.cookedButton.UseVisualStyleBackColor = true;
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.Location = new System.Drawing.Point(661, 170);
            this.cancelOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(117, 78);
            this.cancelOrderButton.TabIndex = 3;
            this.cancelOrderButton.Text = "주문취소";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "임시추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.cookedButton);
            this.Controls.Add(this.orderList);
            this.Controls.Add(backButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Order_FormClosed);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView orderList;
        private System.Windows.Forms.ColumnHeader order_num;
        private System.Windows.Forms.ColumnHeader menu;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader order_time;
        private System.Windows.Forms.Button cookedButton;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.ColumnHeader guest_num;
        private System.Windows.Forms.Button button1;
    }
}