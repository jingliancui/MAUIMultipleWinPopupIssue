using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class MyPopupViewModel: ObservableObject
    {
        private string message;
        public string Message
        {
            get => message;
            set => SetProperty(ref message, value);
        }
    }
}
