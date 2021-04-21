using System.Collections.ObjectModel;

namespace avalondock_mvvm_demo
{
    public class MainVm
    {
        public MainVm()
        {
            Anchorables = new ObservableCollection<DefaultAchorableVm>();
            Anchorables.Add(new DefaultAchorableVm("pierwsza zakładka"));
            Anchorables.Add(new DefaultAchorableVm("druga zakładka"));
            Anchorables.Add(new DefaultAchorableVm("trzecia zakładka"));
        }

        public ObservableCollection<DefaultAchorableVm> Anchorables { get; }
    }
}
