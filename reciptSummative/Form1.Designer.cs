namespace reciptSummative
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.itemOneLabel = new System.Windows.Forms.Label();
            this.itemTwoLabel = new System.Windows.Forms.Label();
            this.itemThreeLabel = new System.Windows.Forms.Label();
            this.itemOneBox = new System.Windows.Forms.TextBox();
            this.itemTwoBox = new System.Windows.Forms.TextBox();
            this.itemThreebox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subTotalAmount = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.changeAmount = new System.Windows.Forms.Button();
            this.reciptButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeAmountLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemOneLabel
            // 
            this.itemOneLabel.AutoSize = true;
            this.itemOneLabel.Location = new System.Drawing.Point(43, 23);
            this.itemOneLabel.Name = "itemOneLabel";
            this.itemOneLabel.Size = new System.Drawing.Size(74, 13);
            this.itemOneLabel.TabIndex = 0;
            this.itemOneLabel.Text = "Burger ($2.49)";
            // 
            // itemTwoLabel
            // 
            this.itemTwoLabel.AutoSize = true;
            this.itemTwoLabel.Location = new System.Drawing.Point(43, 65);
            this.itemTwoLabel.Name = "itemTwoLabel";
            this.itemTwoLabel.Size = new System.Drawing.Size(65, 13);
            this.itemTwoLabel.TabIndex = 1;
            this.itemTwoLabel.Text = "Fries ($1.89)";
            // 
            // itemThreeLabel
            // 
            this.itemThreeLabel.AutoSize = true;
            this.itemThreeLabel.Location = new System.Drawing.Point(43, 106);
            this.itemThreeLabel.Name = "itemThreeLabel";
            this.itemThreeLabel.Size = new System.Drawing.Size(73, 13);
            this.itemThreeLabel.TabIndex = 2;
            this.itemThreeLabel.Text = "Drinks ($0.99)";
            // 
            // itemOneBox
            // 
            this.itemOneBox.Location = new System.Drawing.Point(136, 20);
            this.itemOneBox.Name = "itemOneBox";
            this.itemOneBox.Size = new System.Drawing.Size(100, 20);
            this.itemOneBox.TabIndex = 3;
            // 
            // itemTwoBox
            // 
            this.itemTwoBox.Location = new System.Drawing.Point(136, 65);
            this.itemTwoBox.Name = "itemTwoBox";
            this.itemTwoBox.Size = new System.Drawing.Size(100, 20);
            this.itemTwoBox.TabIndex = 4;
            // 
            // itemThreebox
            // 
            this.itemThreebox.Location = new System.Drawing.Point(136, 103);
            this.itemThreebox.Name = "itemThreebox";
            this.itemThreebox.Size = new System.Drawing.Size(100, 20);
            this.itemThreebox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(96, 145);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Location = new System.Drawing.Point(43, 197);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(53, 13);
            this.subLabel.TabIndex = 7;
            this.subLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(43, 230);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(43, 259);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // subTotalAmount
            // 
            this.subTotalAmount.AutoSize = true;
            this.subTotalAmount.Location = new System.Drawing.Point(136, 197);
            this.subTotalAmount.Name = "subTotalAmount";
            this.subTotalAmount.Size = new System.Drawing.Size(65, 13);
            this.subTotalAmount.TabIndex = 10;
            this.subTotalAmount.Text = "place holder";
            this.subTotalAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.AutoSize = true;
            this.taxAmountLabel.Location = new System.Drawing.Point(136, 230);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(65, 13);
            this.taxAmountLabel.TabIndex = 11;
            this.taxAmountLabel.Text = "place holder";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Location = new System.Drawing.Point(136, 259);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(65, 13);
            this.totalAmountLabel.TabIndex = 12;
            this.totalAmountLabel.Text = "place holder";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(43, 305);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(136, 302);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(100, 20);
            this.tenderedBox.TabIndex = 14;
            // 
            // changeAmount
            // 
            this.changeAmount.Location = new System.Drawing.Point(96, 341);
            this.changeAmount.Name = "changeAmount";
            this.changeAmount.Size = new System.Drawing.Size(75, 23);
            this.changeAmount.TabIndex = 15;
            this.changeAmount.Text = "Change";
            this.changeAmount.UseVisualStyleBackColor = true;
            this.changeAmount.Click += new System.EventHandler(this.changeAmount_Click);
            // 
            // reciptButton
            // 
            this.reciptButton.Location = new System.Drawing.Point(96, 418);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(75, 23);
            this.reciptButton.TabIndex = 16;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseMnemonic = false;
            this.reciptButton.UseVisualStyleBackColor = true;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(43, 386);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change";
            // 
            // changeAmountLabel
            // 
            this.changeAmountLabel.AutoSize = true;
            this.changeAmountLabel.Location = new System.Drawing.Point(133, 386);
            this.changeAmountLabel.Name = "changeAmountLabel";
            this.changeAmountLabel.Size = new System.Drawing.Size(65, 13);
            this.changeAmountLabel.TabIndex = 18;
            this.changeAmountLabel.Text = "place holder";
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(303, 408);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(134, 33);
            this.newOrderButton.TabIndex = 19;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 453);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.changeAmountLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.changeAmount);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.taxAmountLabel);
            this.Controls.Add(this.subTotalAmount);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.itemThreebox);
            this.Controls.Add(this.itemTwoBox);
            this.Controls.Add(this.itemOneBox);
            this.Controls.Add(this.itemThreeLabel);
            this.Controls.Add(this.itemTwoLabel);
            this.Controls.Add(this.itemOneLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Food Place";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemOneLabel;
        private System.Windows.Forms.Label itemTwoLabel;
        private System.Windows.Forms.Label itemThreeLabel;
        private System.Windows.Forms.TextBox itemOneBox;
        private System.Windows.Forms.TextBox itemTwoBox;
        private System.Windows.Forms.TextBox itemThreebox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subTotalAmount;
        private System.Windows.Forms.Label taxAmountLabel;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button changeAmount;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeAmountLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

