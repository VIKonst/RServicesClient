using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RServicesClient.ApplicationSettings
{
    internal interface ISettings : INotifyPropertyChanged
    {
        Int32 TimeOut { get; set; }


        void SaveChanges();
    }
}
