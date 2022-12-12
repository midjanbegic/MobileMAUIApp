using MobileApp.Models;
using Newtonsoft.Json;

namespace MobileApp.Services
{
    public class ProductService
    {
        static ProductService _instance;

        private string _baseUrl = "https://staging.komercijala.ba/api/products?importProviderKey=9dab1d09-eac7-4185-bec4-8032db2f0bc3";

        public static ProductService Instance
        {
            get { return _instance ?? (_instance = new ProductService()); }
        }

        public async Task<List<Product>> GetProducts()
        {
            var returnResponse = new List<Product>();
            try
            {


                using (var client = new HttpClient())
                {
                    var apiResponse = await client.GetAsync(_baseUrl);
                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();

                        if (response != null)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<Product>>(response);


                        }
                    }


                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;

            }

            return returnResponse;
        }
    }
}