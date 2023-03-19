using System.ComponentModel;
using System.Windows.Input;

namespace MauiAppTest.ControlTemplateDemo
{
    public class MyButtonContentChangeViewModel : INotifyPropertyChanged
    {
        private string content;
        private string footer;

        public event PropertyChangedEventHandler PropertyChanged;

        public MyButtonContentChangeViewModel()
        {
            RuntimeChangeContentCommand = new Command(
                execute: () =>
                {
                    Content = $"Change Content {DateTime.Now}";
                    Footer = $"Change Footer {DateTime.Now}";
                });

            Content = "Init Content";
            Footer = "Init Footer";
        }

        public ICommand RuntimeChangeContentCommand { get; private set; }

        public string Content
        {
            get => content;
            private set
            {
                if (content != value)
                {
                    content = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Content)));
                }
            }
        }
        public string Footer { 
            get => footer;
            private set
            {
                if(footer != value)
                {
                    footer = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Footer)));
                }
            }
        }
    }
}
