using CommunityToolkit.Mvvm.Input;
using MobileApp.Models;
using MobileApp.Services;
using MobileApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MobileApp.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        ObservableCollection<Product> _products;

        public HomeViewModel()
        {
            LoadDataAsync();
        }

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        private async Task LoadDataAsync()
        {
            Products = new ObservableCollection<Product>();
            List<Product> _productList;
            _productList = await ProductService.Instance.GetProducts();


            foreach (var product in _productList)
                Products.Add(product);
        }

        [RelayCommand]

        Task Navigate() => Shell.Current.GoToAsync(nameof(DetailPage));

    }
}