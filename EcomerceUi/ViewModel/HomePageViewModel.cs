using CommunityToolkit.Mvvm.ComponentModel;
using EcomerceUi.Models;
using EcomerceUi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomerceUi.ViewModel
{
   public  class HomePageViewModel:ObservableObject
    {
        private readonly CategoryServices _categoryServices;
        public HomePageViewModel(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public ObservableCollection<Category> Categories { get; set; } = new();
        public async Task IntializeAsync()
        {
            foreach(var category in await _categoryServices.GetMainCategoriesAsync())
            {
                Categories.Add(category);
            }
        }
    }
}
