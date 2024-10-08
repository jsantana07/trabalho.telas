using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using System;
using trabalho.equipe.Modelos; // Adicionando para uso de string e outras funcionalidades

namespace trabalho.equipe
{

    public partial class ClientesPage : ContentPage
    {
        public Cliente cliente;
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();


        public ClientesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                IdLabel.Text = cliente.Id.ToString();
                NomeEntry.Text = cliente.Nome;
                EnderecoEntry.Text = cliente.Endereco;
            }
        }

        private async void OnCadastrarClienteClicked(object sender, EventArgs e) // Adicionado 'async'
        {
            //if (await VerificaSeDadosEstaoCorretos())
            {
                var cliente = new Cliente(); // Usando 'Cliente' com maiúscula
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    cliente.Id = int.Parse(IdLabel.Text);
                else
                    cliente.Id = 0;
                cliente.Nome = NomeEntry.Text;
                cliente.Endereco = EnderecoEntry.Text; // Corrigido para 'Endereco'
                cliente.CPF = CPFEntry.Text;
                clienteControle.CriarOuAtualizar(cliente); // Adicionado 'await' e corrigido 'CriarOuAtualizar'

                await DisplayAlert("Cadastro", "Cliente cadastrado com sucesso!", "OK");
            }
        }
         private async void OnApagarClienteClicked(object sender, EventArgs e)
  {
   
    if (cliente == null || cliente.Id < 1)
      await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
     
      clienteControle.Apagar(cliente.Id);
      
      Application.Current.MainPage = new ListaClientesPage(); 
    }
  }


    }
}




