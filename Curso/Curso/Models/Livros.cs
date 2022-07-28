using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Models
{
    public class Livros {
        public string Titulo { get; set; }
        public string Imagem { get; set; }

        public List<Livros> listaLivros = new List<Livros>() ;

        public void AdicionaLivros()
        {
            listaLivros.Add(new Livros()
            {
                Titulo = "PYTHON FOR BEGGINERS",
                Imagem = "https://python-programs.com/wp-content/uploads/2021/04/How-to-Scrape-Wikipedia-Articles-with-Python.jpg"
            });

            listaLivros.Add(new Livros()
            {
                Titulo = "XAMARIN FORMS",
                Imagem = "https://blog.instabug.com/wp-content/uploads/2020/12/b_Top-Xamarin-Development-Tools-and-IDEs-.png"
            });

        }

    }
}
