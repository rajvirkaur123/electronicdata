namespace Project2
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
            this.Label10 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.idnumber = new System.Windows.Forms.TextBox();
            this.firstnametextbox = new System.Windows.Forms.TextBox();
            this.lastnametextbox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.itemtextbox = new System.Windows.Forms.TextBox();
            this.categorycombobox = new System.Windows.Forms.ComboBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.buyingsellingcombobox = new System.Windows.Forms.ComboBox();
            this.phonenumbertextbox = new System.Windows.Forms.TextBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyingorseller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phonenumner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(268, 9);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(347, 39);
            this.Label10.TabIndex = 25;
            this.Label10.Text = "Electronic Database";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 88);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(21, 13);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "ID:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 133);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 13);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "First Name";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(28, 187);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 13);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Last Name";
            // 
            // idnumber
            // 
            this.idnumber.Location = new System.Drawing.Point(107, 81);
            this.idnumber.MaxLength = 5;
            this.idnumber.Name = "idnumber";
            this.idnumber.Size = new System.Drawing.Size(176, 20);
            this.idnumber.TabIndex = 29;
            this.idnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idnumber_KeyPress);
            // 
            // firstnametextbox
            // 
            this.firstnametextbox.Location = new System.Drawing.Point(107, 130);
            this.firstnametextbox.MaxLength = 20;
            this.firstnametextbox.Name = "firstnametextbox";
            this.firstnametextbox.Size = new System.Drawing.Size(176, 20);
            this.firstnametextbox.TabIndex = 30;
            // 
            // lastnametextbox
            // 
            this.lastnametextbox.Location = new System.Drawing.Point(107, 180);
            this.lastnametextbox.MaxLength = 20;
            this.lastnametextbox.Name = "lastnametextbox";
            this.lastnametextbox.Size = new System.Drawing.Size(176, 20);
            this.lastnametextbox.TabIndex = 31;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(369, 88);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(27, 13);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "Item";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(351, 137);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 13);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "Category";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(365, 187);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(43, 13);
            this.Label6.TabIndex = 34;
            this.Label6.Text = "Price: $";
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.firstname,
            this.lastname,
            this.item,
            this.category,
            this.price,
            this.buyingorseller,
            this.phonenumner,
            this.email});
            this.ListView1.Location = new System.Drawing.Point(31, 282);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(951, 351);
            this.ListView1.TabIndex = 35;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // itemtextbox
            // 
            this.itemtextbox.Location = new System.Drawing.Point(417, 85);
            this.itemtextbox.MaxLength = 30;
            this.itemtextbox.Name = "itemtextbox";
            this.itemtextbox.Size = new System.Drawing.Size(176, 20);
            this.itemtextbox.TabIndex = 36;
            // 
            // categorycombobox
            // 
            this.categorycombobox.FormattingEnabled = true;
            this.categorycombobox.Items.AddRange(new object[] {
            "Appliances",
            "Audio",
            "Cameras & Camcorders",
            "Car Electronics & GPS",
            "Cell Phones",
            "Computers & Tablets",
            "Movies & Music ",
            "TV & Home Theater",
            "Wearable Technology "});
            this.categorycombobox.Location = new System.Drawing.Point(417, 133);
            this.categorycombobox.Name = "categorycombobox";
            this.categorycombobox.Size = new System.Drawing.Size(176, 21);
            this.categorycombobox.TabIndex = 37;
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(417, 184);
            this.pricetextbox.MaxLength = 20;
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(176, 20);
            this.pricetextbox.TabIndex = 38;
            this.pricetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricetextbox_KeyPress);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(638, 85);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(85, 13);
            this.Label7.TabIndex = 39;
            this.Label7.Text = "Buying or Selling";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(638, 136);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(78, 13);
            this.Label8.TabIndex = 40;
            this.Label8.Text = "Phone Number";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(638, 187);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(35, 13);
            this.Label9.TabIndex = 41;
            this.Label9.Text = "E-mail";
            // 
            // buyingsellingcombobox
            // 
            this.buyingsellingcombobox.FormattingEnabled = true;
            this.buyingsellingcombobox.Items.AddRange(new object[] {
            "Buying",
            "Selling"});
            this.buyingsellingcombobox.Location = new System.Drawing.Point(729, 82);
            this.buyingsellingcombobox.Name = "buyingsellingcombobox";
            this.buyingsellingcombobox.Size = new System.Drawing.Size(176, 21);
            this.buyingsellingcombobox.TabIndex = 42;
            // 
            // phonenumbertextbox
            // 
            this.phonenumbertextbox.Location = new System.Drawing.Point(729, 137);
            this.phonenumbertextbox.MaxLength = 10;
            this.phonenumbertextbox.Name = "phonenumbertextbox";
            this.phonenumbertextbox.Size = new System.Drawing.Size(176, 20);
            this.phonenumbertextbox.TabIndex = 43;
            this.phonenumbertextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonenumbertextbox_KeyPress);
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(729, 187);
            this.emailtextbox.MaxLength = 30;
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(176, 20);
            this.emailtextbox.TabIndex = 44;
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(417, 228);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(176, 48);
            this.Enter.TabIndex = 45;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // firstname
            // 
            this.firstname.Text = "First Name";
            // 
            // lastname
            // 
            this.lastname.Text = "Last Name";
            // 
            // item
            // 
            this.item.Text = "Item";
            // 
            // category
            // 
            this.category.Text = "Category";
            // 
            // price
            // 
            this.price.Text = "Price: $";
            this.price.Width = 79;
            // 
            // buyingorseller
            // 
            this.buyingorseller.Text = "Buying or Selling";
            // 
            // phonenumner
            // 
            this.phonenumner.Text = "Phone Number";
            // 
            // email
            // 
            this.email.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 645);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.phonenumbertextbox);
            this.Controls.Add(this.buyingsellingcombobox);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.categorycombobox);
            this.Controls.Add(this.itemtextbox);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lastnametextbox);
            this.Controls.Add(this.firstnametextbox);
            this.Controls.Add(this.idnumber);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox idnumber;
        internal System.Windows.Forms.TextBox firstnametextbox;
        internal System.Windows.Forms.TextBox lastnametextbox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.TextBox itemtextbox;
        internal System.Windows.Forms.ComboBox categorycombobox;
        internal System.Windows.Forms.TextBox pricetextbox;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox buyingsellingcombobox;
        internal System.Windows.Forms.TextBox phonenumbertextbox;
        internal System.Windows.Forms.TextBox emailtextbox;
        internal System.Windows.Forms.Button Enter;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader buyingorseller;
        private System.Windows.Forms.ColumnHeader phonenumner;
        private System.Windows.Forms.ColumnHeader email;
    }
}

