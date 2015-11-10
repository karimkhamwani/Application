namespace FlamingoWF
{
    partial class EditDetails
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
            this.label4 = new System.Windows.Forms.Label();
            this.EditDetails_Categoryname = new System.Windows.Forms.ComboBox();
            this.EditDetails_ItemName = new System.Windows.Forms.ComboBox();
            this.EditDetails_Orderid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EditDetails_Quantity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoryname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // EditDetails_Categoryname
            // 
            this.EditDetails_Categoryname.FormattingEnabled = true;
            this.EditDetails_Categoryname.Location = new System.Drawing.Point(131, 78);
            this.EditDetails_Categoryname.Name = "EditDetails_Categoryname";
            this.EditDetails_Categoryname.Size = new System.Drawing.Size(121, 21);
            this.EditDetails_Categoryname.TabIndex = 4;
            this.EditDetails_Categoryname.SelectedIndexChanged += new System.EventHandler(this.EditDetails_Categoryname_SelectedIndexChanged);
            // 
            // EditDetails_ItemName
            // 
            this.EditDetails_ItemName.FormattingEnabled = true;
            this.EditDetails_ItemName.Location = new System.Drawing.Point(131, 123);
            this.EditDetails_ItemName.Name = "EditDetails_ItemName";
            this.EditDetails_ItemName.Size = new System.Drawing.Size(121, 21);
            this.EditDetails_ItemName.TabIndex = 5;
            // 
            // EditDetails_Orderid
            // 
            this.EditDetails_Orderid.Enabled = false;
            this.EditDetails_Orderid.Location = new System.Drawing.Point(131, 28);
            this.EditDetails_Orderid.Name = "EditDetails_Orderid";
            this.EditDetails_Orderid.Size = new System.Drawing.Size(121, 20);
            this.EditDetails_Orderid.TabIndex = 7;
            this.EditDetails_Orderid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Note: Enter New Quantity";
            // 
            // EditDetails_Quantity
            // 
            this.EditDetails_Quantity.FormattingEnabled = true;
            this.EditDetails_Quantity.Location = new System.Drawing.Point(131, 164);
            this.EditDetails_Quantity.Name = "EditDetails_Quantity";
            this.EditDetails_Quantity.Size = new System.Drawing.Size(121, 21);
            this.EditDetails_Quantity.TabIndex = 12;
            // 
            // EditDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 359);
            this.Controls.Add(this.EditDetails_Quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditDetails_Orderid);
            this.Controls.Add(this.EditDetails_ItemName);
            this.Controls.Add(this.EditDetails_Categoryname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditDetails";
            this.Text = "EditDetails";
            this.Load += new System.EventHandler(this.EditDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EditDetails_Categoryname;
        private System.Windows.Forms.ComboBox EditDetails_ItemName;
        private System.Windows.Forms.TextBox EditDetails_Orderid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EditDetails_Quantity;
    }
}