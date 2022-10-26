using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zebble;
using Olive;
using System.Diagnostics;
using Zebble.Mvvm;
using System.Linq;
using Domain.Models;

namespace UI.Pages
{
    partial class SubjectPage
    {

        public override async Task OnInitializing()
        {
            var data = Nav.Param<List<WordInfo>>("info");
            SubjectList.Source = data.Select(x => new WordInfoVM(x)).ToList();
            await base.OnInitializing();
        }

        public async void GoBack()
        {
            await Nav.Back();
        }
    }
    public class WordInfoVM : ViewModel<WordInfo>
    {
        public WordInfoVM() { }
        public WordInfoVM(WordInfo src) => Source.Set(src);
    }
}
