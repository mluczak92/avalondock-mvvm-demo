using System.Windows;
using System.Windows.Controls;

namespace avalondock_mvvm_demo
{
    public class PanesTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultStyle { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is DefaultAchorableVm)
                return DefaultStyle;

            return base.SelectTemplate(item, container);
        }
    }
}
