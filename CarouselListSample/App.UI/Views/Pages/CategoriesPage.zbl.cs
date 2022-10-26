using Domain.Api.Repositories;
using Domain.Models;
using Olive;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UI.Pages
{
    partial class CategoriesPage
    {
        public override async Task OnInitializing()
        {
            LiveApi liveApi = new LiveApi();
            var categories = await liveApi.GetCategories();
            await CategoriesList.UpdateSource(categories);
            await base.OnInitializing();
        }
        public override async Task OnPreRender()
        {
            await base.OnPreRender();
        }

        public async Task ChangeTheme()
        {
            Zebble.Device.Screen.DarkMode = !Zebble.Device.Screen.DarkMode;
            await UIContext.RefreshUI();
        }


    }
}
