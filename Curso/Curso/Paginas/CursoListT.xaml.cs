using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Curso.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursoListT : ContentPage
    {
        List<String> MinhaLista = new List<string>();
        List<String> Join;
        public CursoListT()
        {
            InitializeComponent();
            Join = new List<String> { "Xamarin", "Visual Studio", "C#", "NetMauai" };

            MinhaLista.Add("Luiz");
            MinhaLista.Add("Fernanda");
            MinhaLista.Add("José");
            MinhaLista.Add("João");
            MinhaLista.Add("Alberto");
            MinhaLista.Add("Newton");
            MinhaLista.Add("Rodrigo");
            MinhaLista.Add("Laércio");

            foreach (string item in MinhaLista)
            {
                Console.WriteLine(item);
            }
            lstPicker.ItemsSource = MinhaLista;
        }
    }
}