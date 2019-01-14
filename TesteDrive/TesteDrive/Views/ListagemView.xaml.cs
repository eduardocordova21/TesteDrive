using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDrive.Models;
using Xamarin.Forms;

namespace TesteDrive.Views
{
    public partial class ListagemView : ContentPage
    {
        public ListagemView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Veiculo>(this, "VeiculoSelecionado", (msg) => { Navigation.PushAsync(new DetalheView(msg), true); });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Veiculo>(this, "VeiculoSelecionado");
        }
    }
}
