using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAddressBook_2.MVVM.Models;

namespace WPFAddressBook_2.Services
{
    internal class FileService
    {
        //VIDEO 5: KODEN
        private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";


        public ObservableCollection<ContactModel> ReadFromFile()
        {
            try
            {
                using var sr = new StreamReader(filePath);
                return JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(sr.ReadToEnd())!;
            }
            catch { return new ObservableCollection<ContactModel>(); }
        }

        public void SaveToFile(ObservableCollection<ContactModel> contacts)
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(JsonConvert.SerializeObject(contacts));
        }






        //public void AddToList(ContactModel contact)
        //{
        //    //contacts.Add(contact);
        //    //SaveToFile();
        //}

        //public void RemoveFromList(ContactModel contact)
        //{
        //    //contacts.Remove(contact);
        //    //SaveToFile();
        //}



        //VIDEO 4: KODEN
        //public string FilePath { get; set; } = null!;
        //public void Save(string content)
        //{
        //    using var sw = new StreamWriter(FilePath);
        //    sw.WriteLine(content);
        //}
        //public string Read()
        //{
        //    try
        //    {
        //        using var sr = new StreamReader(FilePath);

        //        return sr.ReadToEnd();
        //    }
        //    catch
        //    {
        //        return null!;
        //    }
        //}
    }
}
