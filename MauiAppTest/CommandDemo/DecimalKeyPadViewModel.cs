using System.ComponentModel;
using System.Windows.Input;

namespace MauiAppTest.CommandDemo
{
    public class DecimalKeyPadViewModel : INotifyPropertyChanged
    {
        private string entry = "0";

        public string Entry { 
            get => entry; 
            private set
            {
                if(entry != value)
                {
                    entry = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Entry)));
                }
            }
        }

        public DecimalKeyPadViewModel()
        {
            ClearCommand = new Command(
                execute: () =>
                {
                    Entry = "0";
                    RefreshCanExcutes();
                });
            BackspaceCommand = new Command(
                execute: () =>
                {
                    Entry = Entry.Substring(0, Entry.Length - 1);
                    if (Entry == "")
                    {
                        Entry = "0";
                    }
                    RefreshCanExcutes();
                },
                canExecute: () =>
                {
                    return Entry.Length > 1 || Entry != "0";
                });
            DigitCommand = new Command<string>(
                execute: (string arg) =>
                {
                    Entry += arg;
                    if (Entry.StartsWith("0") && !Entry.StartsWith("0."))
                    {
                        Entry = Entry.Substring(1);
                    }
                    RefreshCanExcutes();
                },
                canExecute: (string arg) =>
                {
                    return !(arg == "." && Entry.Contains("."));
                });
        }

        private void RefreshCanExcutes()
        {
            (BackspaceCommand as Command).ChangeCanExecute();
            (DigitCommand as Command).ChangeCanExecute();
        }

        public ICommand ClearCommand { get; private set; }
        public ICommand BackspaceCommand { get; private set; }
        public ICommand DigitCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
