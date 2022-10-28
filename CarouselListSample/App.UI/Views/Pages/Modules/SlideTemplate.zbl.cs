using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Pages;
using Zebble;

namespace UI.Modules
{
    partial class SlideTemplate
    {
        public Task OnSlideTapped()
        {
            return Nav.Forward<SubjectPage>(new { info = Item.Value.Details.ToList() }) ;
        }
    }
}
