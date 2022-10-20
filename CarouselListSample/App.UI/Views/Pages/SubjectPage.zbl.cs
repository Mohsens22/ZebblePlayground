using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zebble;
using Olive;
using System.Diagnostics;
using Zebble.Mvvm;
using System.Linq;

namespace UI.Pages
{
    partial class SubjectPage
    {
        public string[] names = { "kamran", "ali", "mohsen" };
        public override async Task OnInitializing()
        {

            await base.OnInitializing();
        }

        public override async Task OnRendered()
        {
            SubjectList.Source = names.Select(x => new StringVM(x)).ToList();
            await base.OnRendered();
        }
        public async void GoBack()
        {

        }
    }
    public class StringVM : ViewModel<string>
    {
        public StringVM() { }
        public StringVM(string src) => Source.Set(src);
    }
}
