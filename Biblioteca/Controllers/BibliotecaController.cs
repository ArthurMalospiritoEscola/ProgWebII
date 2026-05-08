using Biblioteca.Models;
using Biblioteca.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;

public class BibliotecaController : Controller
{
    readonly ILivroRepository _livroRepository;
    readonly IAutorRepository _autorRepository;

    public BibliotecaController(ILivroRepository livroRepository, IAutorRepository autorRepository) {
        _livroRepository = livroRepository;
        _autorRepository = autorRepository;
    }
    
    //ARRUMAR TODAS AS ROTAS PARA FILTRAR MELHOR DEPOIS!!!
    public async Task<IActionResult> Index()
    {
        List<Livro> livros = await _livroRepository.BuscarTodosLivrosAsync();

        List<Livro> famousBooks;
        
        var book1 = livros.FirstOrDefault(x=> x.Id==7);
        var book2 = livros.FirstOrDefault(x=> x.Id==3);
        var book3 = livros.FirstOrDefault(x=> x.Id==12);

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

    public async Task<IActionResult> Livro(int id)
    {
        List<Livro> livros = await _livroRepository.BuscarTodosLivrosAsync();
        var livro = livros.FirstOrDefault(x => x.Id==id);
        return View(livro);
    }

    public async Task<IActionResult> Autor(int id)
    {
        List<Autor> autores=await _autorRepository.BuscarTodosAutoresAsync();
        List<Livro> livros = await _livroRepository.BuscarTodosLivrosAsync();
        var autor = autores.FirstOrDefault(x => x.Id==id);

        var Obras = livros.Where(x => x.AutorId==id).ToList();
        
        return View((autor, Obras));
    }

    public async Task<IActionResult> Livros()
    {
        List<Livro> livros = await _livroRepository.BuscarTodosLivrosAsync();

        List<Livro> Romances;
        List<Livro> Ficcoes;
        List<Livro> Biografias;
        List<Livro> Tragedias;
        List<Livro> Poemas;

        Romances = livros.Where(x => x.Genero==Genero.Romance).ToList();
        Ficcoes = livros.Where(x => x.Genero==Genero.Ficcao).ToList();
        Biografias = livros.Where(x => x.Genero==Genero.Biografia).ToList();
        Tragedias = livros.Where(x => x.Genero==Genero.Tragedia).ToList();
        Poemas = livros.Where(x => x.Genero==Genero.Poema).ToList();

        return View((Romances,Ficcoes,Biografias,Tragedias,Poemas));
    }
    public async Task<IActionResult> Autores()
    {
        List<Autor> autores = await _autorRepository.BuscarTodosAutoresAsync();
        return View(autores);
    }


    //Provisório, colocaria em outro controller
    public async Task<IActionResult> CriarLivro()
    {
        List<Autor> autores = await _autorRepository.BuscarTodosAutoresAsync();
        return View(autores);
    }

    [HttpPost]
    public async Task<IActionResult> CriarLivroAsync(Livro livro)
    {
        await _livroRepository.CriarLivroAsync(livro);
        return RedirectToAction("Livros");
    }
    public async Task<IActionResult> CriarAutor()
    {

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CriarAutorAsync(Autor autor)
    {
        await _autorRepository.CriarAutorAsync(autor);
        return RedirectToAction("Autores");
    }

}