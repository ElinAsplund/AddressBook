﻿using Newtonsoft.Json;
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
    }
}
