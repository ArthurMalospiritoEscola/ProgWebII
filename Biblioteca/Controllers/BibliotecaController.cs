using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;

public class BibliotecaController : Controller
{
    public List<Autor> autorList;
    public List<Livro> bookList;
    public BibliotecaController() {
        autorList  = new List<Autor> {
            new Autor(0,"Williwam Shakespeare","shakespeare.jpg"),
            new Autor(1,"Machado de Assis","machado.jpg"),
            new Autor(2,"Graciliano Ramos","graciliano.jpg"),
            new Autor(3,"Fiódor Dostoiévski","fiodor.jpg"),
            new Autor(4,"George Orwell","georgeOrwell.jpg"),
            new Autor(5,"Dante Alighieri","danteAlighieri.jpg"),
            new Autor(6,"Carolina Maria de Jesus","carolinaMariaDeJesus.jpg"),
            new Autor(7,"Homero","homero.jpg"),
            new Autor(8,"Nikola Tesla","nikolaTesla.jpeg")
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