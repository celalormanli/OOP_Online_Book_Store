﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Online_Book_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpbxMain.Location = new Point(0, -6);
            this.Size = new Size(420, 260);
            grpbxLogin.Visible = false;
            grpbxSignup.Visible = false;
            grpbxSupplier.Visible = false;
            IdCount Cn = IdCount.Creator();
            CustomerList list = CustomerList.Createtor();
            Customer cs1 = new Customer();
            cs1.CustomerID1 = Cn.CustumerId1;
            Cn.CustumerId1 += 1;
            cs1.Name1 = "Ali Demir";
            cs1.Address1 = "Eskişehir";
            cs1.Email1 = "Ali@gmail.com";
            cs1.Username1 = "Ali.26";
            cs1.Password1 = "123456";
            list.Cstmrlist.Add(cs1);
            Customer cs2 = new Customer();
            cs2.CustomerID1 = Cn.CustumerId1;
            Cn.CustumerId1 += 1;
            cs2.Name1 = "Mustafa Aydın";
            cs2.Address1 = "İstanbul";
            cs2.Email1 = "Maydin@gmail.com";
            cs2.Username1 = "M.34";
            cs2.Password1 = "123456";
            list.Cstmrlist.Add(cs2);
            Customer cs3 = new Customer();
            cs3.CustomerID1 = Cn.CustumerId1;
            Cn.CustumerId1 += 1;
            cs3.Name1 = "Zehra Çevik";
            cs3.Address1 = "Antalya";
            cs3.Email1 = "Zehra.07@gmail.com";
            cs3.Username1 = "Zehra.07";
            cs3.Password1 = "123456";
            list.Cstmrlist.Add(cs3);
            Customer cs4 = new Customer();
            cs4.CustomerID1 = Cn.CustumerId1;
            Cn.CustumerId1 += 1;
            cs4.Name1 = "Ayşe Gök";
            cs4.Address1 = "Zonguldak";
            cs4.Email1 = "Ayse@gmail.com";
            cs4.Username1 = "Ayse_1";
            cs4.Password1 = "123456";
            list.Cstmrlist.Add(cs4);
            Customer cs5 = new Customer();
            cs5.CustomerID1 = Cn.CustumerId1;
            Cn.CustumerId1 += 1;
            cs5.Name1 = "Özge Esen";
            cs5.Address1 = "Ankara";
            cs5.Email1 = "Ozge@gmail.com";
            cs5.Username1 = "Ozge.06";
            cs5.Password1 = "123456";
            list.Cstmrlist.Add(cs5);


            ProductLists Prlist = ProductLists.Createtor();
            Book bk1 = new Book(Cn.ProductId1, "Tutunamayanlar",32.68, 78975470, "Oğuz Atay","İletişim Y.",724);
            Cn.ProductId1 += 1;
            Prlist.Boklist.Add(bk1);
            Book bk2 = new Book(Cn.ProductId1, "Olasılıksız", 15.6, 97897560, "Adam Fawer", "April Y.", 475);
            Cn.ProductId1 += 1;
            Prlist.Boklist.Add(bk2);
            Book bk3 = new Book(Cn.ProductId1, "Ölü Ozanlar Derneği", 9.88, 97860552, "Nancy H. Kleinbaum", "Bilge Kültür Sanat", 136);
            Cn.ProductId1 += 1;
            Prlist.Boklist.Add(bk3);
            MusicCD ms1 = new MusicCD(Cn.ProductId1, "Red", 10, "Taylor Swift", "Pop");
            Cn.ProductId1 += 1;
            Prlist.MusicCDlist.Add(ms1);
            MusicCD ms2 = new MusicCD(Cn.ProductId1, "Rolling Deep", 12, "Adele", "Caz");
            Cn.ProductId1 += 1;
            Prlist.MusicCDlist.Add(ms2);
            MusicCD ms3 = new MusicCD(Cn.ProductId1, "Every Way That I Can", 15, "Sertab Erener", "pop");
            Cn.ProductId1 += 1;
            Prlist.MusicCDlist.Add(ms3);
            Magazine mg1 = new Magazine(Cn.ProductId1, "4-4-2", 4.3, 54657856, "Sport");
            Cn.ProductId1 += 1;
            Prlist.Magazinelist.Add(mg1);
            Magazine mg2 = new Magazine(Cn.ProductId1, "Otomobil", 5.3, 48567896, "Auto");
            Cn.ProductId1 += 1;
            Prlist.Magazinelist.Add(mg2);
            Magazine mg3 = new Magazine(Cn.ProductId1, "PcMagazine", 6, 85623458, "Technology");
            Cn.ProductId1 += 1;
            Prlist.Magazinelist.Add(mg3);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            grpbxLogin.Location = new Point(12, 12);
            grpbxMain.Visible = false;
            grpbxLogin.Visible = true;
            this.Size = new Size(290, 210);
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            grpbxMain.Visible = false;
            grpbxSignup.Visible = true;
            grpbxSupplier.Visible = false;
            grpbxSignup.Location = new Point(0, -6);
            this.Size = new Size(388, 365);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            grpbxMain.Visible = false;
            grpbxSupplier.Visible = true;
            grpbxSupplier.Location = new Point(12, 12);
            this.Size = new Size(285, 225);
        }

        private void btnSignupsignup_Click(object sender, EventArgs e)
        {
            if (txtPasswordsignup.Text.ToString() == txtpasswordconfirmsignup.Text.ToString()&&txtPasswordsignup.Text.ToString()!="")
            {
                CustomerList list = CustomerList.Createtor();
                IdCount Cn = IdCount.Creator();
                for(int i=0;i<list.Cstmrlist.Count;i++)
                {
                    if(txtUsernamesignup.Text==list.Cstmrlist[i].Username1)
                    {
                        MessageBox.Show("There is a this username in system. Please enter different username");
                        break;
                    }

                    else
                    {
                        Customer cs = new Customer();
                        cs.CustomerID1 = Cn.CustumerId1;
                        cs.Name1 = txtName.Text.ToString();
                        cs.Address1 = txtAdress.Text.ToString();
                        cs.Email1 = txtEmail.Text.ToString();
                        cs.Username1 = txtUsernamesignup.Text.ToString();
                        cs.Password1 = txtPasswordsignup.Text.ToString();
                        list.Cstmrlist.Add(cs);
                        txtName.Text = "";
                        txtAdress.Text = "";
                        txtEmail.Text = "";
                        txtUsernamesignup.Text = "";
                        txtPasswordsignup.Text = "";
                        txtpasswordconfirmsignup.Text = "";
                        MessageBox.Show("Sign up is success. Now, you can login. ");
                        grpbxLogin.Location = new Point(12, 12);
                        grpbxMain.Visible = false;
                        grpbxLogin.Visible = true;
                        grpbxSignup.Visible = false;
                        this.Size = new Size(290, 210);
                        Cn.CustumerId1 += 1;
                        break;
                    }
                }
 
            }
            else
            {
                MessageBox.Show("Please enter same password");
                txtpasswordconfirmsignup.Text = "";
                txtPasswordsignup.Text = "";
            }
        }

        private void btnLoginn_Click(object sender, EventArgs e)
        {
            int flag = 0;
            CustomerList cslist = CustomerList.Createtor();
            for (int i = 0; i < cslist.Cstmrlist.Count; i++)
            {
                if (txtUsername.Text == cslist.Cstmrlist[i].Username1)
                {
                    if (txtPassword.Text == cslist.Cstmrlist[i].Password1)
                    {
                        Login lgn = Login.Creator();
                        lgn.LoginCustomer1 = cslist.Cstmrlist[i];
                        Form3 shopping = new Form3();
                        this.Visible = false;
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        shopping.ShowDialog();
                        this.Visible = true;
                        flag = 1;
                        break;
                    }
                  
                }                
            }
            if(flag==0)
            {
                MessageBox.Show("ERROR! Username or Password not true.");
            }
           


        }

        private void btnLoginback_Click(object sender, EventArgs e)
        {
            grpbxMain.Visible = true;
            grpbxLogin.Visible = false;
            this.Size = new Size(420, 260);
        }

        private void btnSignupback_Click(object sender, EventArgs e)
        {
            grpbxMain.Visible = true;
            grpbxSignup.Visible = false;
            this.Size = new Size(420, 260);
        }

        private void btnLoginsupplier_Click(object sender, EventArgs e)
        {
            if(txtUsernamesupplier.Text=="admin"&&txtPasswordsupplier.Text=="123456")
            {
                Form2 supplier = new Form2();
                this.Visible = false;
                supplier.ShowDialog();
                this.Visible = true;
            }
         
        }

        private void btnBacksupplier_Click(object sender, EventArgs e)
        {
            grpbxMain.Visible = true;
            grpbxSupplier.Visible = false;
            this.Size = new Size(420, 260);
        }
    }
}
