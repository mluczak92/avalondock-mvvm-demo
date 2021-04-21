using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace avalondock_mvvm_demo
{
    public class DefaultAchorableVm : INotifyPropertyChanged
    {
        bool isSelected;
        bool isActive;
        string title;

        public event PropertyChangedEventHandler PropertyChanged;

        public DefaultAchorableVm(string title)
        {
            Title = title;
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }


        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                OnPropertyChanged();
                Debug.WriteLine($"{Title}.Selected = {isSelected}");
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
                OnPropertyChanged();
                Debug.WriteLine($"{Title}.Activated = {isActive}");
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
