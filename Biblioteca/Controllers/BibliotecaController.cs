using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;

public class BibliotecaController : Controller
{
    public IActionResult Index()
    {
        List<Livro> l1 = new List<Livro> {
            new Livro(150,"Martin Lutero","Harry Potter","Ficção real",new DateOnly(2008,07,28)),
            new Livro(255,"Mr.Computer","Hexadecimal","Computação",new DateOnly(2000,01,01)),
            new Livro(432,"Reinaldo Teixeira","Pingo o cavalo","Suspense",new DateOnly(2007,04,13))
        };
        

        return View(l1);
    }

    public IActionResult Livro()
    {
        return View();
    }

    public IActionResult Autor()
    {
        return View();
    }

    public IActionResult Livros()
    {
        List<Livro> l1 = new List<Livro> {
            new Livro(150,"Martin Lutero","Harry Potter","Ficção real",new DateOnly(2008,07,28)),
            new Livro(255,"Mr.Computer","Hexadecimal","Computação",new DateOnly(2000,01,01)),
            new Livro(10,"10","Livro 10","Números",new DateOnly(10,10,10)),
            new Livro(1,"A","Livro A","Letras",new DateOnly(1,1,1)),
            new Livro(432,"Reinaldo Teixeira","Pingo o cavalo","Suspense",new DateOnly(2007,04,13))
        };

        return View(l1);
    }
}