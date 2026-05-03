using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;

public class BibliotecaController : Controller
{
    public List<Autor> autorList;
    public List<Livro> bookList;
    public BibliotecaController() {
        autorList  = new List<Autor> {
            new Autor(0, "William Shakespeare", "Dramaturgo e poeta inglês do século XVI, amplamente considerado o maior escritor da língua inglesa. Autor de peças icônicas como Hamlet, Romeu e Julieta e Macbeth. Suas obras exploram temas universais como amor, poder, traição e identidade humana, sendo encenadas até hoje em todo o mundo.", "shakespeare.jpg"),
            new Autor(1, "Machado de Assis", "Um dos maiores escritores da literatura brasileira, fundador da Academia Brasileira de Letras. Destacou-se no realismo com obras como Dom Casmurro e Memórias Póstumas de Brás Cubas. Sua escrita é marcada por ironia, crítica social e profunda análise psicológica dos personagens.", "machado.jpg"),
            new Autor(2, "Graciliano Ramos", "Importante escritor do modernismo brasileiro, conhecido por seu estilo direto e crítico. Sua obra mais famosa, Vidas Secas, retrata a dura realidade do sertão nordestino. Também abordou questões sociais e políticas com grande profundidade em seus livros.", "graciliano.jpg"),
            new Autor(3, "Fiódor Dostoiévski", "Escritor russo do século XIX, referência na literatura psicológica e filosófica. Autor de clássicos como Crime e Castigo e Os Irmãos Karamázov. Suas obras exploram a moral, a culpa, a fé e os conflitos internos do ser humano.", "fiodor.jpg"),
            new Autor(4, "George Orwell", "Escritor e jornalista britânico, conhecido por sua crítica aos regimes totalitários. Autor de obras marcantes como 1984 e A Revolução dos Bichos. Seus textos abordam vigilância, manipulação política e liberdade individual.", "georgeOrwell.jpg"),
            new Autor(5, "Dante Alighieri", "Poeta italiano da Idade Média, considerado o pai da língua italiana moderna. Sua principal obra, A Divina Comédia, descreve uma jornada pelo Inferno, Purgatório e Paraíso. É um dos maiores clássicos da literatura mundial.", "danteAlighieri.jpg"),
            new Autor(6, "Carolina Maria de Jesus", "Escritora brasileira que ganhou notoriedade com o livro Quarto de Despejo. Em sua obra, relata o cotidiano na favela com olhar sensível e realista. Tornou-se um importante símbolo da literatura periférica e da denúncia social.", "carolinaMariaDeJesus.jpg"),
            new Autor(7, "Homero", "Poeta da Grécia Antiga, tradicionalmente apontado como autor da Ilíada e da Odisseia. Suas obras narram feitos heroicos e aventuras mitológicas. São fundamentais para a cultura e literatura ocidental.", "homero.jpg"),
            new Autor(8, "Nikola Tesla", "Inventor e engenheiro elétrico, pioneiro no desenvolvimento da corrente alternada. Contribuiu significativamente para a eletricidade moderna e diversas tecnologias. É reconhecido como um dos grandes gênios da ciência.", "nikolaTesla.jpeg")
        }; 
        bookList  = new List<Livro> {
            new Livro(0,"Hamlet",autorList[0],112,"Tragédia",new DateOnly(1600,12,25),"hamlet.jpeg"),
            new Livro(1,"Memórias póstumas de Brás Cubas",autorList[1],225,"Romance",new DateOnly(1881,11,12),"memoriasPostumas.jpg"),
            new Livro(2,"Dom Casmurro",autorList[1],250,"Romance",new DateOnly(1889,09,01),"domCasmurro.jpeg"),
            new Livro(3,"Vidas secas",autorList[2],143,"Romance",new DateOnly(1938,06,12),"vidasSecas.jpeg"),
            new Livro(4,"Memórias do subsolo",autorList[3],101,"Romance",new DateOnly(1864,02,14),"memoriasSubsolo.jpeg"),
            new Livro(5,"Revolução dos bichos",autorList[4],132,"Ficção",new DateOnly(1945,08,17),"revolucaoBichos.jpeg"),
            new Livro(6,"1984",autorList[4],300,"Ficção",new DateOnly(1949,06,8),"1984.jpeg"),
            new Livro(7,"Divina Comédia",autorList[5],615,"Poema",new DateOnly(1472,04,11),"divinaComedia.jpeg"),
            new Livro(8,"Quarto de Despejo",autorList[6],173,"Biografia",new DateOnly(1960,07,27),"quartoDespejo.jpeg"),
            new Livro(9,"Odisseia",autorList[7],600,"Poema",new DateOnly(01,01,01),"odisseia.jpg"),
            new Livro(10,"Minhas Invenções",autorList[8],89,"Biografia",new DateOnly(1943,01,07),"minhasInvencoes.jpg"),
            new Livro(11,"Otelo, o Mouro de Veneza",autorList[0],167,"Tragédia",new DateOnly(1604,03,03),"hotelo.jpg")
        };
    }
    
    


    public IActionResult Index()
    {
        List<Livro> famousBooks;
        
        var book1 = bookList.FirstOrDefault(x=> x.Id==0);
        var book2 = bookList.FirstOrDefault(x=> x.Id==1);
        var book3 = bookList.FirstOrDefault(x=> x.Id==5);

        if(book1!=null && book2!=null && book3!=null)
        {
            famousBooks = new List<Livro> {
                book1,
                book2,
                book3
                
            };
        } else
        {
            famousBooks = new List<Livro>();
        }
        return View(famousBooks);
    }

    public IActionResult Livro(int id)
    {
        var livro = bookList.FirstOrDefault(x => x.Id==id);
        return View(livro);
    }

    public IActionResult Autor(int id)
    {
        var autor = autorList.FirstOrDefault(x => x.Id==id);

        var Obras = bookList.Where(x => x.Autor.Id==id).ToList();
        Console.WriteLine(autor.ImageName);
        
        return View((autor, Obras));
    }

    public IActionResult Livros()
    {
        List<Livro> Romances;
        List<Livro> Ficcoes;
        List<Livro> Biografias;
        List<Livro> Tragedias;
        List<Livro> Poemas;

        Romances = bookList.Where(x => x.Genero=="Romance").ToList();
        Ficcoes = bookList.Where(x => x.Genero=="Ficção").ToList();
        Biografias = bookList.Where(x => x.Genero=="Biografia").ToList();
        Tragedias = bookList.Where(x => x.Genero=="Tragédia").ToList();
        Poemas = bookList.Where(x => x.Genero=="Poema").ToList();

        return View((Romances,Ficcoes,Biografias,Tragedias,Poemas));
    }
    public IActionResult Autores()
    {
        return View(autorList);
    }
}