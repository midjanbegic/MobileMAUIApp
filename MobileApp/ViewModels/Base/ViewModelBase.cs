using Newtonsoft.Json;
using System.Windows.Input;

namespace MobileApp.ViewModels
{
   
    public class ViewModelBase : BindableObject
    {
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
