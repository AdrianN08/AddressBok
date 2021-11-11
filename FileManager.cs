using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Adressbok
{
    public class FileManager : Imanager
    {
        public void Save(Contact c, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(c.ToString());
            writer.Close();
        }
        public List<Contact> Load(string fileName)
        {
            List<Contact> myContacts = new List<Contact>();
            StreamReader reader = new StreamReader(fileName);
            string line = "";
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                string[] myArr = line.Split(",");
                myContacts.Add(new Contact(myArr[0], myArr[1], myArr[2], myArr[3], myArr[4], myArr[5]));
            }
            reader.Close();
            return myContacts;
        }
        public void UpdateAll(List<Contact> myContacts, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            foreach (Contact c in myContacts)
            {
                writer.WriteLine(c.ToString());
            }
            writer.Close();
        }
    }
}
