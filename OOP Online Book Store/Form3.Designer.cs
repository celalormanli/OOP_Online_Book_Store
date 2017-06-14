namespace OOP_Online_Book_Store
{
    partial class Form3
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.grpbxShopping = new System.Windows.Forms.GroupBox();
            this.grpbxdetails = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantitypro = new System.Windows.Forms.TextBox();
            this.txtnamepro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdatocart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShoppingcart = new System.Windows.Forms.Button();
            this.btnListmagazine = new System.Windows.Forms.Button();
            this.btnListbook = new System.Windows.Forms.Button();
            this.btnListMusicCD = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.grpbxShoppingcart = new System.Windows.Forms.GroupBox();
            this.btnConfirmcart = new System.Windows.Forms.Button();
            this.btndeleteitem = new System.Windows.Forms.Button();
            this.btnAddnewitem = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.grpbxConfirmcart = new System.Windows.Forms.GroupBox();
            this.btnConfirmcancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtConfirmtotalprice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtConfirmadress = new System.Windows.Forms.TextBox();
            this.txtConfirmemail = new System.Windows.Forms.TextBox();
            this.txtConfirmname = new System.Windows.Forms.TextBox();
            this.txtConfirmcustomerid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpbxShopping.SuspendLayout();
            this.grpbxdetails.SuspendLayout();
            this.grpbxShoppingcart.SuspendLayout();
            this.grpbxConfirmcart.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(306, 293);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // grpbxShopping
            // 
            this.grpbxShopping.Controls.Add(this.grpbxdetails);
            this.grpbxShopping.Controls.Add(this.btnShoppingcart);
            this.grpbxShopping.Controls.Add(this.listView1);
            this.grpbxShopping.Controls.Add(this.btnListmagazine);
            this.grpbxShopping.Controls.Add(this.btnListbook);
            this.grpbxShopping.Controls.Add(this.btnListMusicCD);
            this.grpbxShopping.Location = new System.Drawing.Point(12, 313);
            this.grpbxShopping.Name = "grpbxShopping";
            this.grpbxShopping.Size = new System.Drawing.Size(821, 402);
            this.grpbxShopping.TabIndex = 4;
            this.grpbxShopping.TabStop = false;
            // 
            // grpbxdetails
            // 
            this.grpbxdetails.Controls.Add(this.label9);
            this.grpbxdetails.Controls.Add(this.label8);
            this.grpbxdetails.Controls.Add(this.txtQuantitypro);
            this.grpbxdetails.Controls.Add(this.txtnamepro);
            this.grpbxdetails.Controls.Add(this.label7);
            this.grpbxdetails.Controls.Add(this.btnAdatocart);
            this.grpbxdetails.Controls.Add(this.label6);
            this.grpbxdetails.Controls.Add(this.label5);
            this.grpbxdetails.Controls.Add(this.label4);
            this.grpbxdetails.Controls.Add(this.label3);
            this.grpbxdetails.Controls.Add(this.label2);
            this.grpbxdetails.Controls.Add(this.label1);
            this.grpbxdetails.Location = new System.Drawing.Point(330, 100);
            this.grpbxdetails.Name = "grpbxdetails";
            this.grpbxdetails.Size = new System.Drawing.Size(290, 234);
            this.grpbxdetails.TabIndex = 6;
            this.grpbxdetails.TabStop = false;
            this.grpbxdetails.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Name";
            // 
            // txtQuantitypro
            // 
            this.txtQuantitypro.Location = new System.Drawing.Point(91, 201);
            this.txtQuantitypro.Name = "txtQuantitypro";
            this.txtQuantitypro.Size = new System.Drawing.Size(137, 20);
            this.txtQuantitypro.TabIndex = 8;
            // 
            // txtnamepro
            // 
            this.txtnamepro.Location = new System.Drawing.Point(91, 176);
            this.txtnamepro.Name = "txtnamepro";
            this.txtnamepro.ReadOnly = true;
            this.txtnamepro.Size = new System.Drawing.Size(137, 20);
            this.txtnamepro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // btnAdatocart
            // 
            this.btnAdatocart.BackgroundImage = global::OOP_Online_Book_Store.Properties.Resources._1497188653_shopping_basket_add;
            this.btnAdatocart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdatocart.Location = new System.Drawing.Point(233, 176);
            this.btnAdatocart.Name = "btnAdatocart";
            this.btnAdatocart.Size = new System.Drawing.Size(51, 45);
            this.btnAdatocart.TabIndex = 5;
            this.btnAdatocart.UseVisualStyleBackColor = true;
            this.btnAdatocart.Click += new System.EventHandler(this.btnAdatocart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnShoppingcart
            // 
            this.btnShoppingcart.BackgroundImage = global::OOP_Online_Book_Store.Properties.Resources._1497223942_cart;
            this.btnShoppingcart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShoppingcart.Location = new System.Drawing.Point(739, 19);
            this.btnShoppingcart.Name = "btnShoppingcart";
            this.btnShoppingcart.Size = new System.Drawing.Size(75, 75);
            this.btnShoppingcart.TabIndex = 4;
            this.btnShoppingcart.UseVisualStyleBackColor = true;
            this.btnShoppingcart.Click += new System.EventHandler(this.btnShoppingcart_Click);
            // 
            // btnListmagazine
            // 
            this.btnListmagazine.BackgroundImage = global::OOP_Online_Book_Store.Properties.Resources._1497187870_magazine;
            this.btnListmagazine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListmagazine.Location = new System.Drawing.Point(222, 19);
            this.btnListmagazine.Name = "btnListmagazine";
            this.btnListmagazine.Size = new System.Drawing.Size(90, 75);
            this.btnListmagazine.TabIndex = 2;
            this.btnListmagazine.UseVisualStyleBackColor = true;
            this.btnListmagazine.Click += new System.EventHandler(this.btnListmagazine_Click);
            // 
            // btnListbook
            // 
            this.btnListbook.BackgroundImage = global::OOP_Online_Book_Store.Properties.Resources._1497187875_icon_30_book;
            this.btnListbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListbook.Location = new System.Drawing.Point(6, 19);
            this.btnListbook.Name = "btnListbook";
            this.btnListbook.Size = new System.Drawing.Size(90, 75);
            this.btnListbook.TabIndex = 0;
            this.btnListbook.UseVisualStyleBackColor = true;
            this.btnListbook.Click += new System.EventHandler(this.btnListbook_Click);
            // 
            // btnListMusicCD
            // 
            this.btnListMusicCD.BackgroundImage = global::OOP_Online_Book_Store.Properties.Resources._1497187865_folder_music;
            this.btnListMusicCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListMusicCD.Location = new System.Drawing.Point(114, 19);
            this.btnListMusicCD.Name = "btnListMusicCD";
            this.btnListMusicCD.Size = new System.Drawing.Size(90, 75);
            this.btnListMusicCD.TabIndex = 1;
            this.btnListMusicCD.UseVisualStyleBackColor = true;
            this.btnListMusicCD.Click += new System.EventHandler(this.btnListMusicCD_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // grpbxShoppingcart
            // 
            this.grpbxShoppingcart.Controls.Add(this.btnConfirmcart);
            this.grpbxShoppingcart.Controls.Add(this.btndeleteitem);
            this.grpbxShoppingcart.Controls.Add(this.btnAddnewitem);
            this.grpbxShoppingcart.Controls.Add(this.listView2);
            this.grpbxShoppingcart.Location = new System.Drawing.Point(12, 27);
            this.grpbxShoppingcart.Name = "grpbxShoppingcart";
            this.grpbxShoppingcart.Size = new System.Drawing.Size(458, 280);
            this.grpbxShoppingcart.TabIndex = 6;
            this.grpbxShoppingcart.TabStop = false;
            this.grpbxShoppingcart.Visible = false;
            // 
            // btnConfirmcart
            // 
            this.btnConfirmcart.Location = new System.Drawing.Point(321, 238);
            this.btnConfirmcart.Name = "btnConfirmcart";
            this.btnConfirmcart.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmcart.TabIndex = 3;
            this.btnConfirmcart.Text = "Confirm Cart";
            this.btnConfirmcart.UseVisualStyleBackColor = true;
            this.btnConfirmcart.Click += new System.EventHandler(this.btnConfirmcart_Click);
            // 
            // btndeleteitem
            // 
            this.btndeleteitem.Location = new System.Drawing.Point(155, 238);
            this.btndeleteitem.Name = "btndeleteitem";
            this.btndeleteitem.Size = new System.Drawing.Size(121, 23);
            this.btndeleteitem.TabIndex = 2;
            this.btndeleteitem.Text = "Delete This Item";
            this.btndeleteitem.UseVisualStyleBackColor = true;
            this.btndeleteitem.Click += new System.EventHandler(this.btndeleteitem_Click);
            // 
            // btnAddnewitem
            // 
            this.btnAddnewitem.Location = new System.Drawing.Point(6, 238);
            this.btnAddnewitem.Name = "btnAddnewitem";
            this.btnAddnewitem.Size = new System.Drawing.Size(121, 23);
            this.btnAddnewitem.TabIndex = 1;
            this.btnAddnewitem.Text = "Add New Item";
            this.btnAddnewitem.UseVisualStyleBackColor = true;
            this.btnAddnewitem.Click += new System.EventHandler(this.btnAddnewitem_Click);
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(6, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(436, 213);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // grpbxConfirmcart
            // 
            this.grpbxConfirmcart.Controls.Add(this.btnConfirmcancel);
            this.grpbxConfirmcart.Controls.Add(this.btnConfirm);
            this.grpbxConfirmcart.Controls.Add(this.groupBox2);
            this.grpbxConfirmcart.Controls.Add(this.txtConfirmtotalprice);
            this.grpbxConfirmcart.Controls.Add(this.label15);
            this.grpbxConfirmcart.Controls.Add(this.txtConfirmadress);
            this.grpbxConfirmcart.Controls.Add(this.txtConfirmemail);
            this.grpbxConfirmcart.Controls.Add(this.txtConfirmname);
            this.grpbxConfirmcart.Controls.Add(this.txtConfirmcustomerid);
            this.grpbxConfirmcart.Controls.Add(this.label14);
            this.grpbxConfirmcart.Controls.Add(this.label13);
            this.grpbxConfirmcart.Controls.Add(this.label12);
            this.grpbxConfirmcart.Controls.Add(this.label11);
            this.grpbxConfirmcart.Location = new System.Drawing.Point(476, 27);
            this.grpbxConfirmcart.Name = "grpbxConfirmcart";
            this.grpbxConfirmcart.Size = new System.Drawing.Size(357, 280);
            this.grpbxConfirmcart.TabIndex = 7;
            this.grpbxConfirmcart.TabStop = false;
            this.grpbxConfirmcart.Visible = false;
            // 
            // btnConfirmcancel
            // 
            this.btnConfirmcancel.Location = new System.Drawing.Point(170, 251);
            this.btnConfirmcancel.Name = "btnConfirmcancel";
            this.btnConfirmcancel.Size = new System.Drawing.Size(87, 23);
            this.btnConfirmcancel.TabIndex = 17;
            this.btnConfirmcancel.Text = "Cancel";
            this.btnConfirmcancel.UseVisualStyleBackColor = true;
            this.btnConfirmcancel.Click += new System.EventHandler(this.btnConfirmcancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(263, 251);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(87, 23);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(83, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 50);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(144, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Check";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(89, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cash";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Credit Card";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtConfirmtotalprice
            // 
            this.txtConfirmtotalprice.Location = new System.Drawing.Point(257, 106);
            this.txtConfirmtotalprice.Name = "txtConfirmtotalprice";
            this.txtConfirmtotalprice.ReadOnly = true;
            this.txtConfirmtotalprice.Size = new System.Drawing.Size(93, 20);
            this.txtConfirmtotalprice.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Totsl Price:";
            // 
            // txtConfirmadress
            // 
            this.txtConfirmadress.Location = new System.Drawing.Point(83, 82);
            this.txtConfirmadress.Name = "txtConfirmadress";
            this.txtConfirmadress.ReadOnly = true;
            this.txtConfirmadress.Size = new System.Drawing.Size(267, 20);
            this.txtConfirmadress.TabIndex = 7;
            // 
            // txtConfirmemail
            // 
            this.txtConfirmemail.Location = new System.Drawing.Point(83, 61);
            this.txtConfirmemail.Name = "txtConfirmemail";
            this.txtConfirmemail.ReadOnly = true;
            this.txtConfirmemail.Size = new System.Drawing.Size(267, 20);
            this.txtConfirmemail.TabIndex = 6;
            // 
            // txtConfirmname
            // 
            this.txtConfirmname.Location = new System.Drawing.Point(83, 40);
            this.txtConfirmname.Name = "txtConfirmname";
            this.txtConfirmname.ReadOnly = true;
            this.txtConfirmname.Size = new System.Drawing.Size(267, 20);
            this.txtConfirmname.TabIndex = 5;
            // 
            // txtConfirmcustomerid
            // 
            this.txtConfirmcustomerid.Location = new System.Drawing.Point(83, 19);
            this.txtConfirmcustomerid.Name = "txtConfirmcustomerid";
            this.txtConfirmcustomerid.ReadOnly = true;
            this.txtConfirmcustomerid.Size = new System.Drawing.Size(267, 20);
            this.txtConfirmcustomerid.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Adress:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Customer Id:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 741);
            this.Controls.Add(this.grpbxConfirmcart);
            this.Controls.Add(this.grpbxShoppingcart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpbxShopping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpbxShopping.ResumeLayout(false);
            this.grpbxdetails.ResumeLayout(false);
            this.grpbxdetails.PerformLayout();
            this.grpbxShoppingcart.ResumeLayout(false);
            this.grpbxConfirmcart.ResumeLayout(false);
            this.grpbxConfirmcart.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListbook;
        private System.Windows.Forms.Button btnListMusicCD;
        private System.Windows.Forms.Button btnListmagazine;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox grpbxShopping;
        private System.Windows.Forms.Button btnShoppingcart;
        private System.Windows.Forms.Button btnAdatocart;
        private System.Windows.Forms.GroupBox grpbxdetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantitypro;
        private System.Windows.Forms.TextBox txtnamepro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpbxShoppingcart;
        private System.Windows.Forms.Button btnConfirmcart;
        private System.Windows.Forms.Button btndeleteitem;
        private System.Windows.Forms.Button btnAddnewitem;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.GroupBox grpbxConfirmcart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtConfirmtotalprice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtConfirmadress;
        private System.Windows.Forms.TextBox txtConfirmemail;
        private System.Windows.Forms.TextBox txtConfirmname;
        private System.Windows.Forms.TextBox txtConfirmcustomerid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnConfirmcancel;
    }
}