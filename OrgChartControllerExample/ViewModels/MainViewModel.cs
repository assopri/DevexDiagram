using OrgChartControllerExample.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OrgChartControllerExample.ViewModels
{
    public class MainViewModel
    {
        public IList<Contact> Contacts { get; protected set; }

        public MainViewModel()
        {
            Contacts = new ContactContextInitializer().Generate();
        }
    }
}