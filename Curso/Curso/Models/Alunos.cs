using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Models
{
    public class Alunos
    {
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Imagem_Url { get; set; }

        //Cria uma Lista da classe alunos
        public List<Alunos> lstAlunos = new List<Alunos>();

        public Alunos() //construtor padrão
        {

        }

        public void Incluir()
        {
            lstAlunos.Add(new Alunos { Nome = "JOSÉ EDUARDO DIAS RUFINO", RM = "00021", Imagem_Url = "https://avatars.githubusercontent.com/u/67909560?s=400&u=5c639d8f7b52a26382434026b3bcf14bbc29a454&v=4" });
            lstAlunos.Add(new Alunos { Nome = "ANA PAULA DIAS RUFINO", RM = "00022", Imagem_Url = "student_avatar.png" });
            lstAlunos.Add(new Alunos { Nome = "PEDRO KINAPE DA SILVA", RM = "00023", Imagem_Url = "https://br.web.img2.acsta.net/c_310_420/pictures/15/07/06/12/16/032047.jpg" });
            lstAlunos.Add(new Alunos { Nome = "RAFAELA DIAS RUFINO", RM = "00024", Imagem_Url = "student_avatar.png" });
        }
    }
}
