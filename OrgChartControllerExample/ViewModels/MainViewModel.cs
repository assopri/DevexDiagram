using OrgChartControllerExample.Model;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace OrgChartControllerExample.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        //public IList<Contact> Contacts { get; protected set; }
        public ObservableCollection<Contact> Contacts { get; protected set; }

        public MainViewModel()
        {
            Contacts = new ContactContextInitializer().Generate();

            Contacts.CollectionChanged += Contacts_CollectionChanged;
        }

        private void Contacts_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}