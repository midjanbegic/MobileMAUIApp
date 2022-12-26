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

  
    public void testFunc(object sender, System.EventArgs e)
    {
        Console.WriteLine("test 123");
    }
}
