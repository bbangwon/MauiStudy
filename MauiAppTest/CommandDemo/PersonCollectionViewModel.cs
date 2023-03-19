using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiAppTest.CommandDemo
{
    public class PersonCollectionViewModel : INotifyPropertyChanged
    {
        private bool isEditing;
        private PersonViewModel personEdit;

        public event PropertyChangedEventHandler PropertyChanged;

        public PersonCollectionViewModel()
        {
            NewCommand = new Command(
                execute: () =>
                {
                    PersonEdit = new PersonViewModel();
                    PersonEdit.PropertyChanged += OnPersonEditPropertyChanged;
                    IsEditing = true;
                    RefreshCanExecutes();
                },
                canExecute: () =>
                {
                    return !IsEditing;
                });

            SubmitCommand = new Command(
                execute: () => {
                    Persons.Add(PersonEdit);
                    PersonEdit.PropertyChanged += OnPersonEditPropertyChanged;
                    PersonEdit = null;
                    IsEditing = false; 
                    RefreshCanExecutes();
                }, 
                canExecute: () => { 
                    return PersonEdit != null &&
                            PersonEdit.Name != null &&
                            PersonEdit.Name.Length > 1 &&
                            PersonEdit.Age > 0;
                });
            CancelCommand = new Command(
                execute: () =>
                {
                    PersonEdit.PropertyChanged -= OnPersonEditPropertyChanged;
                    PersonEdit = null;
                    IsEditing = false;
                    RefreshCanExecutes();
                },
                canExecute: () =>
                {
                    return IsEditing;
                });
        }

        void OnPersonEditPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            (SubmitCommand as Command).ChangeCanExecute();
        }

        void RefreshCanExecutes()
        {
            (NewCommand as Command).ChangeCanExecute();
            (SubmitCommand as Command).ChangeCanExecute();
            (CancelCommand as Command).ChangeCanExecute();
        }

        public bool IsEditing
        {
            get => isEditing;
            set => SetProperty(ref isEditing, value);
        }

        public PersonViewModel PersonEdit { 
            get => personEdit; 
            set => SetProperty(ref personEdit, value); 
        }

        public ICommand NewCommand { get; private set; }
        public ICommand SubmitCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }

        public IList<PersonViewModel> Persons { get; } = new ObservableCollection<PersonViewModel>();

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
