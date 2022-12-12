﻿using MobileApp.Models;
using MobileApp.Services;
using System.Collections.ObjectModel;

namespace MobileApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
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
    }
}