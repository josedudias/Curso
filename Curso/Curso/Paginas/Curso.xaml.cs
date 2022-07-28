using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("DS_GIGI.TTF", Alias= "FonteDigital")]

namespace Curso.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Curso : ContentPage
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void btn_Botao(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.CursoButton());
        }

        private void btn_Frame(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.CursoFrame());
        }

        private void btn_Entry(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.CursoEntry());
        }

        private void btn_ImgButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.CursoImgButton());
        }

        private void btn_ListView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.CursoListView());
        }

        private void btn_ListT(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.CursoListT());
        }

        private void btn_Classes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.CursoClasses());
        }

        private void btn_BD(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.CursoBD());
        }

        private void btn_CarouselView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.CarouselView());
        }
    }
}