
namespace MApublicaAPI.ViewModels;


public partial class MAaboutpage : ContentPage
{
	public MAaboutpage()
	{
		InitializeComponent();
        BindingContext = new ApodViewModel();
    }
}