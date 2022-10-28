using Domain.Api.Repositories;
using Domain.Models;
using Olive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Pages;
using Zebble;

namespace UI.Modules
{
    partial class CategoryListItem
    {
        public Bindable<Category> CategoryItem { get; set; }
        public override Task OnInitializing()
        {
            CategoryItem = new Bindable<Category>();
            CategoryItem.Changed += CategoryItem_Changed;
            CategoryItem.Set(Item);
            return base.OnInitializing();

            
        }

        private async void CategoryItem_Changed()
        {
            await Carousel.UpdateDataSource(CategoryItem.Value.Subjects);
        }

    }
}
