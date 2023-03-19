using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiAppTest.CommandDemo
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private string name;
        private double age;
        private string skills;

        public string Name { 
            get => name; 
            set => SetProperty(ref name, value); 
        }
        public double Age { 
            get => age; 
            set => SetProperty(ref age, value); 
        }
        public string Skills { 
            get => skills; 
            set => SetProperty(ref skills, value); 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Name + ", age " + Age;
        }

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if(Object.Equals(storage, value)) 
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
