using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Curso.Models; //Importar a classe

namespace Curso.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursoClasses : ContentPage
    {

        Carro Lancer = new Carro();

        public CursoClasses()
        {
            InitializeComponent();

            Lancer.Marca = "Mitsubishi";
            Lancer.Modelo = "Lancer";
            Lancer.Combustivel = "Gasolina";
            Lancer.Velocidade = 0;

            lblMarca.Text = Lancer.Marca;
            lblModelo.Text = Lancer.Modelo;
            lblCombustivel.Text = Lancer.Combustivel;
            lblVelocidade.Text = Lancer.Velocidade.ToString();


        }

        private void btnFrear_Clicked(object sender, EventArgs e)
        {

        }

        private void btnAcelerar_Clicked(object sender, EventArgs e)
        {
            Lancer.Acelerar();
            lblVelocidade.Text = Lancer.Velocidade.ToString();

            if (Lancer.Velocidade > 100)
            {
                lblVelocidade.TextColor = Color.Red;
                if (Lancer.Velocidade > 140)
                {
                    lblVelocidade.TextColor = Color.White;
                    lblVelocidade.BackgroundColor = Color.Pink;
                    lblVelocidade.Text = "morreu";
                }
            }
        }
    }
}