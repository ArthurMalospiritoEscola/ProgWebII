using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;

public class BibliotecaController : Controller
{
    static public List<Autor> autorList = new List<Autor> {
        new Autor(0,"Williwam Shakespeare"),
        new Autor(1,"Machado de Assis"),
        new Autor(2,"Graciliano Ramos"),
        new Autor(3,"Fiódor Dostoiévski"),
        new Autor(4,"George Orwell"),
        new Autor(5,"Dante Alighieri"),
        new Autor(6,"Carolina Maria de Jesus")
    };
    public List<Livro> bookList1 = new List<Livro> {
        new Livro(0,"Hamlet",autorList.FirstOrDefault(x => x.Id==0),112,"Tragédia",new DateOnly(1600,12,25),"hamlet.jpeg"),
        new Livro(1,"Memórias póstumas de Brás Cubas",autorList.FirstOrDefault(x => x.Id==1),225,"Romance",new DateOnly(1881,11,12),"memoriasPostumas.jpg"),
        new Livro(2,"Dom Casmurro",autorList.FirstOrDefault(x => x.Id==1),250,"Romance",new DateOnly(1889,09,01),"domCasmurro.jpeg"),
        new Livro(3,"Vidas secas",autorList.FirstOrDefault(x => x.Id==2),143,"Romance",new DateOnly(1938,06,12),"vidasSecas.jpeg"),
        new Livro(4,"Memórias do subsolo",autorList.FirstOrDefault(x => x.Id==3),101,"Novela",new DateOnly(1864,02,14),"memoriasSubsolo.jpeg"),
        new Livro(5,"Revolução dos bichos",autorList.FirstOrDefault(x => x.Id==4),132,"Ficção",new DateOnly(1945,08,17),"revolucaoBichos.jpeg"),
        new Livro(6,"1984",autorList.FirstOrDefault(x=> x.Id==4),300,"Ficção",new DateOnly(1949,06,8),"1984.jpeg"),
        new Livro(7,"Divina Comédia",autorList.FirstOrDefault(x=> x.Id==5),615,"Poema",new DateOnly(1472,04,11),"divinaComedia.jpeg"),
        new Livro(8,"Quarto de Despejo",autorList.FirstOrDefault(x=> x.Id==6),173,"Biografia",new DateOnly(1960,07,27),"quartoDespejo.jpeg")
    };


    public IActionResult Index()
    {
        List<Livro> famousBooks = new List<Livro> {
            bookList1.FirstOrDefault(x=> x.Id==0),
            bookList1.FirstOrDefault(x=> x.Id==1),
            bookList1.FirstOrDefault(x=> x.Id==5)
        };
        return View(famousBooks);
    }

    public IActionResult Livro(int id)
    {
        var livro = bookList1.FirstOrDefault(x => x.Id==id);
        return View(livro);
    }

    public IActionResult Autor(int id)
    {
        var autor = autorList.FirstOrDefault(x => x.Id==id);
        return View(autor);
    }

    public IActionResult Livros()
    {
        return View(bookList1);
    }
    public IActionResult Autores()
    {
        return View(autorList);
    }
}