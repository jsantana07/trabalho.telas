using Controles;
using Microsoft.Maui.Controls;
using Modelos;
using trabalho.equipe.Modelos;

namespace trabalho.equipe
{
    public partial class ListaCostureiraPage : ContentPage
    {
        CostureiraControle costureiraControle = new CostureiraControle();


        public ListaCostureiraPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ListaCostureira.ItemsSource = costureiraControle.LerTodos();
        }


        private async void CadastrarCostClicado(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CostureiraPage());

        }
        async void QuandoSelecionarCostNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CostureiraPage();
            page.costureira = e.SelectedItem as Costureira;
            await Navigation.PushAsync(page);
        }
    }
} 