using System;
using System.Collections.Generic;
using System.Text;

namespace Addressbok
{
    interface Imanager
    {
        void Save(Contact c, string fileName);
        List<Contact> Load(string filenName);
        void UpdateAll(List<Contact> contact, string fileName);
    }
}
