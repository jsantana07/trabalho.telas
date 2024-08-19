using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using System;
using trabalho.equipe.Modelos; // Adicionando para uso de string e outras funcionalidades

namespace trabalho.equipe
{
  
    public partial class ClientesPage : ContentPage
    {
      Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        private ObservableCollection<Cliente> Clientes; // Corrigido para 'Clientes'

        public ClientesPage()
        {
            InitializeComponent();
            Clientes = new ObservableCollection<Cliente>
            {
                new Cliente { Nome = "Larissa Gomes", Endereco = "Rua A, 123", Gmail = "larissa@gmail.com", CPF = "123.456.789-00" },
                new Cliente { Nome = "Gabriel Costa", Endereco = "Rua B, 456", Gmail = "gabriel@gmail.com", CPF = "987.654.321-00" }
            };
            ClientesCollectionView.ItemsSource = Clientes; // Corrigido para 'Clientes'
        }

        private async void OnCadastrarClienteClicked(object sender, EventArgs e) // Adicionado 'async'
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
                var cliente = new Cliente(); // Usando 'Cliente' com maiúscula
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    cliente.Id = int.Parse(IdLabel.Text);
                else
                    cliente.Id = 0;
                cliente.Nome = NomeEntry.Text;
                cliente.Endereco = EnderecoEntry.Text; // Corrigido para 'Endereco'
                cliente.CPF = CPFEntry.Text;
                await clienteControle.CriarOuAtualizar(cliente); // Adicionado 'await' e corrigido 'CriarOuAtualizar'

                await DisplayAlert("Cadastro", "Cliente cadastrado com sucesso!", "OK");
            }
        }

        private void RemoverClienteClicked(object sender, EventArgs e) // Corrigido o nome do método
        {
            var button = sender as Button;
            var cliente = button?.BindingContext as Cliente; // Corrigido para 'Cliente'
            if (cliente != null)
            {
                Clientes.Remove(cliente); // Corrigido para 'Clientes'
                DisplayAlert("Remover", "Cliente removido com sucesso!", "OK");
            }
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos() // Certifique-se de que este método esteja definido
        {
            // Implementação da verificação dos dados
            return true; // Exemplo simplificado
        }
    }
}




