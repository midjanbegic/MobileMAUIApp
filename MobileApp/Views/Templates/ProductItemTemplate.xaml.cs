namespace MobileApp.Views.Templates;

public partial class ProductItemTemplate : ContentView
{
	public ProductItemTemplate()
	{
		InitializeComponent();
    }

    private void Add_To_Cart(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CartPage());
    }


    private void Detail_Page(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DetailPage());
    }
}
