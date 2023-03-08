namespace OrderClient
{
    partial class OrderClientForm
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
            this.containButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.menuList = new System.Windows.Forms.ListView();
            this.menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderList = new System.Windows.Forms.ListView();
            this.orderMenu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myOrderLabel = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.priceTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // containButton
            // 
            this.containButton.Location = new System.Drawing.Point(38, 263);
            this.containButton.Name = "containButton";
            this.containButton.Size = new System.Drawing.Size(212, 40);
            this.containButton.TabIndex = 0;
            this.containButton.Text = "담기";
            this.containButton.UseVisualStyleBackColor = true;
            this.containButton.Click += new System.EventHandler(this.containButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(391, 245);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(180, 58);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "주문";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // menuList
            // 
            this.menuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu,
            this.price});
            this.menuList.FullRowSelect = true;
            this.menuList.HideSelection = false;
            this.menuList.Location = new System.Drawing.Point(38, 27);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(212, 230);
            this.menuList.TabIndex = 2;
            this.menuList.UseCompatibleStateImageBehavior = false;
            this.menuList.View = System.Windows.Forms.View.Details;
            this.menuList.SelectedIndexChanged += new System.EventHandler(this.menuList_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.Text = "메뉴";
            this.menu.Width = 140;
            // 
            // price
            // 
            this.price.Text = "가격";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderList
            // 
            this.orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderMenu,
            this.count,
            this.totalPrice});
            this.orderList.FullRowSelect = true;
            this.orderList.HideSelection = false;
            this.orderList.Location = new System.Drawing.Point(300, 46);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(271, 167);
            this.orderList.TabIndex = 3;
            this.orderList.UseCompatibleStateImageBehavior = false;
            this.orderList.View = System.Windows.Forms.View.Details;
            this.orderList.SelectedIndexChanged += new System.EventHandler(this.orderList_SelectedIndexChanged);
            // 
            // orderMenu
            // 
            this.orderMenu.Text = "메뉴";
            this.orderMenu.Width = 142;
            // 
            // count
            // 
            this.count.Text = "수량";
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "총 가격";
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myOrderLabel
            // 
            this.myOrderLabel.AutoSize = true;
            this.myOrderLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myOrderLabel.Location = new System.Drawing.Point(297, 27);
            this.myOrderLabel.Name = "myOrderLabel";
            this.myOrderLabel.Size = new System.Drawing.Size(76, 16);
            this.myOrderLabel.TabIndex = 4;
            this.myOrderLabel.Text = "주문 목록";
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusButton.Location = new System.Drawing.Point(300, 245);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(73, 25);
            this.plusButton.TabIndex = 5;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusButton.Location = new System.Drawing.Point(300, 276);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(73, 27);
            this.minusButton.TabIndex = 6;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(452, 230);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(11, 12);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "0";
            // 
            // priceTitleLabel
            // 
            this.priceTitleLabel.AutoSize = true;
            this.priceTitleLabel.Location = new System.Drawing.Point(389, 230);
            this.priceTitleLabel.Name = "priceTitleLabel";
            this.priceTitleLabel.Size = new System.Drawing.Size(57, 12);
            this.priceTitleLabel.TabIndex = 8;
            this.priceTitleLabel.Text = "결제금액:";
            // 
            // OrderClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 315);
            this.Controls.Add(this.priceTitleLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.myOrderLabel);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.menuList);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.containButton);
            this.Name = "OrderClientForm";
            this.Text = "OrderClient";
            this.Load += new System.EventHandler(this.OrderClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button containButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ListView menuList;
        private System.Windows.Forms.ColumnHeader menu;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ListView orderList;
        private System.Windows.Forms.ColumnHeader orderMenu;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader totalPrice;
        private System.Windows.Forms.Label myOrderLabel;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label priceTitleLabel;
    }
}

