using System.Collections.Generic;

namespace WpfDataTemplatingExample
{
    public class MainViewModel
    {
        public MainViewModel(IList<object> children)
        {
            Children = children;
        }

        public IList<object> Children { get; private set; }
    }
}