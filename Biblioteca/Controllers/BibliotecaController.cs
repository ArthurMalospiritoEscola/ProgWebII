using Biblioteca.Models;
using Biblioteca.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;

/// <summary>
/// Controlar principal responsável por organizar as rotas de acesso da biblioteca.
/// </summary>
public class BibliotecaController : Controller
{
    /// <summary>
    /// Representa o objeto de LivroRepository, feita para acessar dados do banco de dados da tabela livros.
    /// </summary>
    private readonly ILivroRepository _livroRepository;
    /// <summary>
    /// Representa o objeto de AutorRepository, feita para acessar dados do banco de dados da tabela autores.
    /// </summary>
    private readonly IAutorRepository _autorRepository;
    /// <summary>
    /// Método constrtutor rodado quando o controller é criado.
    /// Pega instâncias dos repositorys para relacionar o banco de dados.
    /// </summary>
    /// <param name="livroRepository">Instância de LivroRepository</param>
    /// <param name="autorRepository">Instância de AutorRepository</param>
    public BibliotecaController(ILivroRepository livroRepository, IAutorRepository autorRepository) {
        _livroRepository = livroRepository;
        _autorRepository = autorRepository;
    }
    
    //ARRUMAR TODAS AS ROTAS PARA FILTRAR MELHOR DEPOIS!!!

    /// <summary>
    /// Rota inicial do projeto.
    /// Pega 3 livros escolhidos a mão para exibir na página inicial.
    /// </summary>
    /// <returns>Retorna a View junto com os dados dos livros a serem exibidos</returns>
    public async Task<IActionResult> Index()
    {
        //Pega os dados de livros no banco de dados por meio do livroRepository.
        List<Livro> livros = await _livroRepository.BuscarTodosLivrosAsync();

        //Cria a lista de livros.
        List<Livro> famousBooks;
        //Filtra os livros por id escolhendo quais serão exibidos.
        var book1 = livros.FirstOrDefault(x=> x.Id==7);
        var book2 = livros.FirstOrDefault(x=> x.Id==3);
        var book3 = livros.FirstOrDefault(x=> x.Id==12);

        //Verifica se todos os livros existem.
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

    /// <summary>
    /// Rota de mostrar a página de um livro específico
    /// </summary>
    /// <param name="id">Id do livro que será exibido</param>
    /// <returns>Retorna a View com os dados do livro para serem exibidor</returns>
    public async Task<IActionResult> Livro(int id)
    {
        //Pega os dados de livros no banco de dados por meio do livroRepository.
        List<Livro> livros = await _livroRepository.BuscarTodosLivrosAsync();
        //Filtra qual livro deverá ser exibido.
        var livro = livros.FirstOrDefault(x => x.Id==id);
        return View(livro);
    }
    /// <summary>
    /// Rota de exibir os dados de um autor em específico.
    /// </summary>
    /// <param name="id">Id do autor que será exibido.</param>
    /// <returns>Retorna a View com dados do autor e livros que tal autor escreveu.</returns>
    public async Task<IActionResult> Autor(int id)
    {
        //Pega os dados de livros no banco de dados por meio do autorRepository.
        List<Autor> autores=await _autorRepository.BuscarTodosAutoresAsync();
        //Pega os dados de livros no banco de dados por meio do livroRepository.
        List<Livro> livros = await _livroRepository.BuscarTodosLivrosAsync();
        //Pega o autor que foi escolhido pelo Id da rota.
        var autor = autores.FirstOrDefault(x => x.Id==id);
        //Pega a obra do autor que foi escolhido pelo Id da rota.
        var Obras = livros.Where(x => x.AutorId==id).ToList();
        
        return View((autor, Obras));
    }
    /// <summary>
    /// Rota que represente a escolha de todos os livros separados por gênero.
    /// </summary>
    /// <returns>Retorna a View com todas as listas de livros separadas por Gênero</returns>
    public async Task<IActionResult> Livros()
    {
        //Pega os dados de livros no banco de dados por meio do livroRepository.
        List<Livro> livros = await _livroRepository.BuscarTodosLivrosAsync();

        //Cria as listas de cada gênero.
        List<Livro> Romances;
        List<Livro> Ficcoes;
        List<Livro> Biografias;
        List<Livro> Tragedias;
        List<Livro> Poemas;

        //Filtra todos os livros de cada gênero.
        Romances = livros.Where(x => x.Genero==Genero.Romance).ToList();
        Ficcoes = livros.Where(x => x.Genero==Genero.Ficcao).ToList();
        Biografias = livros.Where(x => x.Genero==Genero.Biografia).ToList();
        Tragedias = livros.Where(x => x.Genero==Genero.Tragedia).ToList();
        Poemas = livros.Where(x => x.Genero==Genero.Poema).ToList();

        return View((Romances,Ficcoes,Biografias,Tragedias,Poemas));
    }
    /// <summary>
    /// Rota que mostra uma lista com todos os autores.
    /// </summary>
    /// <returns>Retorna a View com a lista de todos autores.</returns>
    public async Task<IActionResult> Autores()
    {
        //Pega os dados de livros no banco de dados por meio do autorRepository.
        List<Autor> autores = await _autorRepository.BuscarTodosAutoresAsync();
        return View(autores);
    }
    /// <summary>
    /// Rota de criar livro, onde exibe o formulário para adicionar os dados para um livro ser criado.
    /// </summary>
    /// <returns>Retorna a View com lista de autores para serem escolhidos como autor do livro.</returns>
    public async Task<IActionResult> CriarLivro()
    {
        List<Autor> autores = await _autorRepository.BuscarTodosAutoresAsync();
        return View(autores);
    }
    /// <summary>
    /// Rota POST de criar livro.
    /// Pega todos os dados enviados pelo formulário da rota CriarLivro, cria um objeto livro e o adiciona no banco de dados.
    /// </summary>
    /// <param name="livro">Objeto de livro criado no formulário.</param>
    /// <returns>Retorna um redirecionamento do usuário para tela de livros para ver se seu livro foi criado.</returns>
    [HttpPost]
    public async Task<IActionResult> CriarLivroAsync(Livro livro)
    {
        //Adiciona o livro criado para dentro do banco de dados por meio do repository.
        await _livroRepository.CriarLivroAsync(livro);
        return RedirectToAction("Livros");
    }
    /// <summary>
    /// Rota de criar autor que exibe o formulário para inserir os dados de criar o autor.
    /// </summary>
    /// <returns>Retorna a View com formulário.</returns>
    public async Task<IActionResult> CriarAutor()
    {
        return View();
    }

    /// <summary>
    /// Rota POST para criar autor.
    /// Pega todos os dados inseridos pelo formulário de CriarAutor e os insere no banco de dados.
    /// </summary>
    /// <param name="autor">Objeto de autor criado no formulário.</param>
    /// <returns>Retorna um redirecionamento do usuário para tela de autores para ver se seu autor foi criado.</returns>
    [HttpPost]
    public async Task<IActionResult> CriarAutorAsync(Autor autor)
    {
        await _autorRepository.CriarAutorAsync(autor);
        return RedirectToAction("Autores");
    }

}
