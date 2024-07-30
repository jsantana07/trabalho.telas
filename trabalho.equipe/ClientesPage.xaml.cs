using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace trabalho.equipe
{
    public partial class ClientesPage : ContentPage
    {
        ObservableCollection<Cliente> Clientes;

        public ClientesPage()
        {
            InitializeComponent();
            Clientes = new ObservableCollection<Cliente>
        {
                new Cliente { Nome = "Larissa Gomes", Endereco = "Rua A, 123", Gmail = "larissa@gmail.com", CPF = "123.456.789-00" },
                new Cliente { Nome = "Gabriel Costa", Endereco = "Rua B, 456", Gmail = "gabriel@gmail.com", CPF = "987.654.321-00" }
            };
            ClientesCollectionView.ItemsSource = Clientes;
        }

        private void OnCadastrarClienteClicked(object sender, EventArgs e)
        {
            // Implementar a lógica de cadastro aqui
            DisplayAlert("Cadastro", "Cliente cadastrado com sucesso!", "OK");
        }

        private void OnRemoverClienteClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var cliente = button?.BindingContext as Cliente;
            if (cliente != null)
            {
                Clientes.Remove(cliente);
                DisplayAlert("Remover", "Cliente removido com sucesso!", "OK");
            }
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Gmail { get; set; }
        public string CPF { get; set; }
    }
}

