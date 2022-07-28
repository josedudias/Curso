using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Curso.Models;

namespace Curso.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursoListView : ContentPage
    {
        List<string> alunox = new List<string>();
        Alunos Alu = new Alunos();
        public CursoListView()
        {
            InitializeComponent();

            alunox.Add("João");
            alunox.Add("Américo");
            alunox.Add("Zico");
            alunox.Add("Romário");

            lstView1.ItemsSource = alunox;
            Alu.Incluir();
            lstView2.ItemsSource = Alu.lstAlunos;
        }
    }
}