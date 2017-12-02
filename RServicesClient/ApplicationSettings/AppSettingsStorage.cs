using RServicesClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RServicesClient.ApplicationSettings
{
    public class AppSettingsStorage : ISettings
    {
        private Settings _settings;

        public AppSettingsStorage()
        {
            _settings = Settings.Default;
            _settings.PropertyChanged += _settings_PropertyChanged;
        }

        private void _settings_PropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public Int32 TimeOut
        {
            get => _settings.TimeOut;
            set => _settings.TimeOut = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SaveChanges()
        {
            _settings.Save();
            _settings.Upgrade();
        }
    }
}
