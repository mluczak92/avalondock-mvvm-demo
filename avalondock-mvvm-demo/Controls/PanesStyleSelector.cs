using System.Windows;
using System.Windows.Controls;

namespace avalondock_mvvm_demo
{
    public class PanesStyleSelector : StyleSelector
    {
        public Style DefaultStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            if (item is DefaultAchorableVm)
                return DefaultStyle;

            return base.SelectStyle(item, container);
        }
    }
}
