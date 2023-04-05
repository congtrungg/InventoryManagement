namespace Inventory_Management
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(40, 75);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(225, 22);
            this.IDTextBox.TabIndex = 1;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.Color.White;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(12, 225);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.RowHeadersWidth = 51;
            this.inventoryGridView.RowTemplate.Height = 24;
            this.inventoryGridView.Size = new System.Drawing.Size(1052, 280);
            this.inventoryGridView.TabIndex = 2;
            this.inventoryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellDoubleClick);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(37, 178);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(225, 41);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New ";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(392, 178);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(225, 41);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(743, 178);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(225, 41);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(37, 134);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(225, 22);
            this.priceTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(392, 134);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(225, 22);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(392, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(225, 22);
            this.nameTextBox.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(743, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(225, 22);
            this.textBox5.TabIndex = 9;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Hardware",
            "Grocery",
            "Pharmacy",
            "Electronic"});
            this.categoryBox.Location = new System.Drawing.Point(743, 75);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(225, 24);
            this.categoryBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giá:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mô tả:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tên:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mục:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(743, 108);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(225, 23);
            this.quantityTextBox.TabIndex = 16;
            this.quantityTextBox.Text = "Số lượng:";
            this.quantityTextBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1081, 517);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label quantityTextBox;
    }
}

