using AppRpgEtec.ViewModels.Personagens;

namespace AppRpgEtec.Views.Personagens;

public partial class ListagemView : ContentPage
{
	public ListagemPersonagemViewModel ViewModel;

    public ListagemView()
	{
		InitializeComponent();

        ViewModel = new ListagemPersonagemViewModel();
		BindingContext = ViewModel;
		Title = "Personagens - App Rpg Etec";
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _ = ViewModel.ObterPersonagens();
    }


}