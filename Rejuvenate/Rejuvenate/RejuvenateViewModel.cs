using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rejuvenate
{
    class RejuvenateViewModel : INotifyPropertyChanged
    {
        private bool _isWorking;
        private string _status;
        private float _progress;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsWorking
        {
            protected set
            {
                if (value != _isWorking)
                {
                    _isWorking = value;
                    OnPropertyChanged("IsWorking");
                }
            }

            get { return _isWorking; }
        }

        public string StatusText
        {
            protected set
            {
                if (value != _status)
                {
                    _status = value;
                    OnPropertyChanged("StatusText");
                }
            }

            get { return _status; }
        }

        public float Progress
        {
            protected set
            {
                if (value != _progress)
                {
                    _progress = value;
                    OnPropertyChanged("Progress");
                }
            }

            get { return _progress; }
        }

        public Command PsmPlusCommand { protected set; get; }

        public Command RunCommand { protected set; get; }

        public Command LaunchCommand { protected set; get; }

        public Command PullCommand { protected set; get; }

        public Command DisconnectCommand { protected set; get; }

        public Command UpdateCommand { protected set; get; }

        public RejuvenateViewModel()
        {
            _isWorking = true;
            _progress = 0.65f;
            _status = "Waiting for connection...";
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
        }
    }
}
