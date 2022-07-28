using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Curso.Models;
using System.Collections.ObjectModel;

namespace Curso.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselView : ContentPage
    {
        //instanciando a classe livros
        Livros liv = new Livros();
        public CarouselView()
        {
            InitializeComponent();

            // processando e gerando a lista

            liv.AdicionaLivros();
            // adicionando a lista de livros
            // ao itemsource do carouselview
            crv1.ItemsSource = liv.listaLivros;
            
            
        }
    }
}