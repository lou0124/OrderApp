namespace OrderServer
{
    partial class ModifyForm
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
            this.menuList = new System.Windows.Forms.ListView();
            this.menu_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.menuTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuList
            // 
            this.menuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu_num,
            this.menu,
            this.price});
            this.menuList.FullRowSelect = true;
            this.menuList.HideSelection = false;
            this.menuList.Location = new System.Drawing.Point(61, 29);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(432, 235);
            this.menuList.TabIndex = 0;
            this.menuList.UseCompatibleStateImageBehavior = false;
            this.menuList.View = System.Windows.Forms.View.Details;
            this.menuList.SelectedIndexChanged += new System.EventHandler(this.menuList_SelectedIndexChanged);
            // 
            // menu_num
            // 
            this.menu_num.Text = "메뉴번호";
            this.menu_num.Width = 70;
            // 
            // menu
            // 
            this.menu.Text = "메뉴";
            this.menu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menu.Width = 200;
            // 
            // price
            // 
            this.price.Text = "가격";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 100;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addButton.Location = new System.Drawing.Point(224, 346);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(81, 34);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.deleteButton.Location = new System.Drawing.Point(311, 347);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(81, 33);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updateButton.Location = new System.Drawing.Point(398, 347);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(81, 33);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "수정";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(62, 295);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(37, 15);
            this.menuLabel.TabIndex = 4;
            this.menuLabel.Text = "메뉴";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(340, 295);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 15);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "가격";
            // 
            // menuTextBox
            // 
            this.menuTextBox.Location = new System.Drawing.Point(105, 295);
            this.menuTextBox.Name = "menuTextBox";
            this.menuTextBox.Size = new System.Drawing.Size(229, 25);
            this.menuTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(383, 295);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(110, 25);
            this.priceTextBox.TabIndex = 7;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 378);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 28);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "뒤로가기";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 419);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.menuTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuList);
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifyForm_FormClosed);
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView menuList;
        private System.Windows.Forms.ColumnHeader menu_num;
        private System.Windows.Forms.ColumnHeader menu;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox menuTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button backButton;
    }
}