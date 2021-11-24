using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Addressbook
{
    public partial class Form1 : Form
    {
        FileManager manager = new FileManager();
        List<Contact> myContacts = new List<Contact>();
        string fileName;
        bool myNewBook = false;
        public Form1()
        {
            InitializeComponent();        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            lblTitle.Text = "Welcome! Create A New Or Open An Existing Adress Book";
            BtnDisable();
        }

        private void tsmNew_Click(object sender, EventArgs e)
        {
            myNewBook = true;
            lbxContactsInfo.Items.Clear();
            myContacts.Clear();
            lblTitle.Text = "Add An New Contact Or Search Among Contacts";
            BtnStartUp();
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == dlgOpen.ShowDialog())
            {
                myContacts.Clear();
                lbxContactsInfo.Items.Clear();
                myContacts = manager.Load(dlgOpen.FileName);
                fileName = dlgOpen.FileName;
            }
            ForEachContact();
            lblTitle.Text = "Add An New Contact Or Search Among Contacts";
            lblContactList.Text = "Contacts: " + myContacts.Count;
            BtnStartUp();
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            if (myNewBook)
            {
                if (DialogResult.OK == dlgSaveFile.ShowDialog())
                {
                    manager.UpdateAll(myContacts, dlgSaveFile.FileName);
                    fileName = dlgOpen.FileName;
                }
            }
            else
            {
                manager.UpdateAll(myContacts, fileName);
            }
        }

        private void tsmSaveAs_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == dlgSaveFile.ShowDialog())
            {
                manager.UpdateAll(myContacts, dlgSaveFile.FileName);
                fileName = dlgOpen.FileName;
            }
        }

        private void tsmReset_Click(object sender, EventArgs e)
        {
            ClearTbx();
            cbxSortBy.SelectedIndex = -1;
            cbxSearch.SelectedIndex = -1;
            lbxContactsInfo.SelectedIndex = -1;
            btnAdd.Enabled = true;

            if (myNewBook)
            {

                lbxContactsInfo.Items.Clear();
                ForEachContact();
            }
            else
            {
                myContacts.Clear();
                lbxContactsInfo.Items.Clear();
                myContacts = manager.Load(fileName);
                ForEachContact();
            }
        }
        
        private void RemoveContact()
        {
            try
            {
                myContacts.RemoveAt(lbxContactsInfo.SelectedIndex); 
                lbxContactsInfo.Items.Remove(lbxContactsInfo.SelectedItem); 
            }
            catch(Exception)
            {
                MessageBox.Show("Some internal error ecurre");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contact addC = new Contact(tbxName.Text, tbxAdress.Text, tbxZipCode.Text, tbxCity.Text, tbxPhoneNr.Text, tbxEmail.Text);
            myContacts.Add(addC);
            lbxContactsInfo.Items.Add(addC.Name);            
            lblContactList.Text = "Contacts: " + myContacts.Count;
            ClearTbx();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveContact();
            ClearTbx();            
            lblContactList.Text = " My Contacts: " + myContacts.Count;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbxContactsInfo.SelectedIndex == -1) return;
            myContacts[lbxContactsInfo.SelectedIndex].Name = tbxName.Text;
            myContacts[lbxContactsInfo.SelectedIndex].Adress = tbxAdress.Text;
            myContacts[lbxContactsInfo.SelectedIndex].ZipCode = tbxZipCode.Text;
            myContacts[lbxContactsInfo.SelectedIndex].City = tbxCity.Text;
            myContacts[lbxContactsInfo.SelectedIndex].PhoneNr = tbxPhoneNr.Text;
            myContacts[lbxContactsInfo.SelectedIndex].Email = tbxEmail.Text;
            lbxContactsInfo.Items.Clear();
            ForEachContact();
            MyListSortedBy(cbxSortBy);
            ClearTbx();
        }

        private void lbxContactsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxContactsInfo.SelectedIndex == -1) return;
            tbxName.Text = myContacts[lbxContactsInfo.SelectedIndex].Name;
            tbxAdress.Text = myContacts[lbxContactsInfo.SelectedIndex].Adress;
            tbxZipCode.Text = myContacts[lbxContactsInfo.SelectedIndex].ZipCode;
            tbxCity.Text = myContacts[lbxContactsInfo.SelectedIndex].City;
            tbxPhoneNr.Text = myContacts[lbxContactsInfo.SelectedIndex].PhoneNr;
            tbxEmail.Text = myContacts[lbxContactsInfo.SelectedIndex].Email;

            lblTitle.Text = "Search, Edit Or Remove Contact";
            grpContact.Text = "Edit Contact";
            lblContactList.Text = " My Contacts: " + myContacts.Count;
            BtnLbxIndex();         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {   
            cbxSortBy.SelectedIndex = -1;
            if (cbxSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Choose an index to search");
            }
            else
            {
                MyListSortedBy(cbxSearch);
                for (int i = lbxContactsInfo.Items.Count - 1; i >= 0; i--)
                {
                    if (lbxContactsInfo.Items[i].ToString().ToLower().Contains(tbxSearch.Text))
                    {
                        lbxContactsInfo.SetSelected(i, true);
                    }
                }
                if (lbxContactsInfo.SelectedItems.Count == 0)
                {
                    MessageBox.Show("\t" + "Value: " + tbxSearch.Text + "\r\n\r\n Does Not Exist! In Your Contacts");
                }
            }
        }
        private void cbxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyListSortedBy(cbxSortBy);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
            cbxSearch.SelectedIndex = -1;
        }
        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSortBy.SelectedIndex = -1;
        }
        private void MyListSortedBy(ComboBox control)
        {
            switch (control.SelectedIndex)
            {
                case 0:
                    myContacts.Sort((x, y) => x.Name.CompareTo(y.Name));
                    lbxContactsInfo.Items.Clear();
                    myContacts.ForEach(x => lbxContactsInfo.Items.Add(x.Name));
                    break;
                case 1:
                    myContacts.Sort((x, y) => x.Adress.CompareTo(y.Adress));
                    lbxContactsInfo.Items.Clear();
                    myContacts.ForEach(x => lbxContactsInfo.Items.Add(x.Adress));
                    break;
                case 2:
                    myContacts.Sort((x, y) => x.ZipCode.CompareTo(y.ZipCode));
                    lbxContactsInfo.Items.Clear();
                    myContacts.ForEach(x => lbxContactsInfo.Items.Add(x.ZipCode));
                    break;
                case 3:
                    myContacts.Sort((x, y) => x.City.CompareTo(y.City));
                    lbxContactsInfo.Items.Clear();
                    myContacts.ForEach(x => lbxContactsInfo.Items.Add(x.City));
                    break;
                case 4:
                    myContacts.Sort((x, y) => x.PhoneNr.CompareTo(y.PhoneNr));
                    lbxContactsInfo.Items.Clear();
                    myContacts.ForEach(x => lbxContactsInfo.Items.Add(x.PhoneNr));
                    break;
                case 5:
                    myContacts.Sort((x, y) => x.Email.CompareTo(y.Email));
                    lbxContactsInfo.Items.Clear();
                    myContacts.ForEach(x => lbxContactsInfo.Items.Add(x.Email));
                    break;
            }
        }
        private void tsmClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ForEachContact()
        {
            foreach (Contact c in myContacts)
            {
                lbxContactsInfo.Items.Add(c.Name);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTbx();
            btnAdd.Enabled = true;
            lblTitle.Text = "Add, Search, Edit Or Remove Contact";
            grpContact.Text = "New Contact";
        }
        public void ClearTbx()
        {
            foreach (Control item in grpContact.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            lbxContactsInfo.SelectedIndex = -1;
        }
        private void BtnDisable()
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
            btnSearch.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void BtnStartUp()
        {
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
            btnSearch.Enabled = true;
            btnCancel.Enabled = false;
        }
        private void BtnLbxIndex()
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = true;
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
            btnSearch.Enabled = true;
            btnCancel.Enabled = true;
        }
    }
}
