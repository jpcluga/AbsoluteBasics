using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using WpfMvvm.Model;

namespace WpfMvvm.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        //Create properties that you want to be seen or modified in the view
        //make sure the names of the properties are exactly the same to the 
        //binded controls

        private string _message;
        public string Message {
            get { return _message; }
            set {
                _message = value;

                //Supply the name of property in this method
                //this will invoke the PropertyChangedEventHandler
                //to reflect any changes in the ViewModel to the View
                RaisePropertyChanged("Message"); 
            }
        }


        private string _txtContent;
        public string TxtContent {
            get { return _txtContent; }
            set { _txtContent = value;
                RaisePropertyChanged("TxtContent");
            }
        }

        public ICommand SendContentCmd { get; private set; }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel() // <--- ENTRY POINT
        {
            //Set initial message on first load
            Message = "Hello, Welcome to WPF and MVVM Absolute Basics!";

            //Set the command to a concrete method or an anonymous method
            //will use an anonymous method for simplicity of the example.
            //Normally, you will call a method inside your relays.
            SendContentCmd = new RelayCommand(() => {
                var model = new ApplicationIdentityModel { ApplicationIdentityMessage = TxtContent };
                Message = model.ApplicationIdentityMessage;
            });
        }
    }
}