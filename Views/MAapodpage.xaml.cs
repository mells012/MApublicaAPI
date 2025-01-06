namespace MApublicaAPI.ViewModels;
namespace MApublicaAPI.Views;

public partial class MAapodpage : ContentPage
{
	public MAapodpage()
	{
		InitializeComponent();
        BindingContext = new MAapodviewmodel();
    }
}