﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace OrgChartControllerExample.Model
{
    public class ContactContextInitializer {
        public ObservableCollection<Contact> Generate()
        {
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>() {
                new Contact("Carolyn", "Baker") {
                    Gender = Gender.Female, Email = "carolyn.baker@example.com", Phone = "(555)349-3010",
                    Address = "1198 Theresa Cir", City = "Whitinsville", State = "MA", Zip = "01582",
                    ParentId = 0,
                },
                new Contact("Amber", "Seaman") {
                    Gender = Gender.Female, Phone = "(555)698-4285",
                    Address = "28700 S Main St", City = "Wilsonville", State = "AL", Zip = "35188",
                    ParentId = 0,
                },
                new Contact("Annie", "Vicars") {
                    Gender = Gender.Female, Email = "annie.vicars@example.com", Phone = "(555)922-1349",
                    Address = "7267 New York Ave", City = "Jersey City", State = "NJ", Zip = "07306",
                    ParentId = 1,
                },
                new Contact("Darlene", "Catto") {
                    Gender = Gender.Female, Email = "darlene.catto@example.com", Phone = "(555)752-0582",
                    Address = "32125 4th St NW #210", City = "Washington", State = "DC", Zip = "20001",
                    ParentId = 2,
                },
                new Contact("Angela", "Gross") {
                    Gender = Gender.Female, Email = "angela.gross@example.com", Phone = "(555)247-1252",
                    Address = "8723 Chicago Ave", City = "Nederland", State = "TX", Zip = "77620",
                    ParentId = 2,
                },
                new Contact("Edward", "Keck") {
                    Gender = Gender.Male, Email = "edward.keck@example.com", Phone = "410-7042",
                    Address = "38202 Greens Rd", City = "Humble", State = "TX", Zip = "77397",
                    ParentId = 4,
                },
                new Contact("Angela", "Walker") {
                    Gender = Gender.Female, Email = "angela.walker@example.com", Phone = "555",
                    Address = "8913 Lakeshore Dr", City = "Jacksons Gap", State = "AL", Zip = "36863",
                    ParentId = 4,
                },
                new Contact("Alice", "Martin") {
                    Gender = Gender.Female, Email = "alice.martin@example.com", Phone = "(555)493-8440",
                    Address = "652 Avonwick Gate", City = "Toronto", State = "ON", Zip = "33125",
                    ParentId = 4,
                },
                new Contact("Andrew", "Carter") {
                    Gender = Gender.Male, Email = "andrew.carter@example.com", Phone = "(555)578-3946",
                    Address = "7121 Bailey St", City = "Worcester", State = "MA", Zip = "01605",
                    ParentId = 5,
                },
                new Contact("George", "Morrison") {
                    Gender = Gender.Male, Email = "george.morrison@example.com", Phone = "(555)468-3668",
                    Address = "7716 Country Woods Cir", City = "Kissimmee", State = "FL", Zip = "34747",
                    ParentId = 5,
                },
            };
            InitializePhotos(contacts);
            foreach(Contact c in contacts)
            {
                c.Id = contacts.IndexOf(c);
            }
            //contacts.ForEach(x => x.Id = contacts.IndexOf(x));
            return contacts;
           
        }
        void InitializePhotos(IList<Contact> contacts) {
            foreach (Contact contact in contacts)
            {
                contact.Photo = GetPhoto(contact);
            }
        }
        byte[] GetPhoto(string name) {
            return File.ReadAllBytes(@"..\..\Images\" + name);
        }
        byte[] GetPhoto(Contact contact) {
            return GetPhoto(contact.FirstName + contact.LastName + ".jpg");
        }
    }
}
