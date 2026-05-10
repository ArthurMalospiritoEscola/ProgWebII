namespace Biblioteca.Repositories;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Repositório responsável pelas operações de acesso e manipulação de dados relacionadas à entidade Livro.
///
/// Esta classe realiza consultas e persistência de autores utilizando o Entity Framework Core.
/// </summary>
public class LivroRepository: ILivroRepository 
{
    private readonly BibliotecaContext _context;
    /// <summary>
    /// Inicializa uma nova instância do repositório de livros.
    /// </summary>
    /// <param name="context">
    /// Contexto do banco de dados utilizado para acessar os dados.
    /// </param>
    public LivroRepository(BibliotecaContext context)
    {
        _context = context;
    }
    /// <summary>
    /// Cria um novo livro no banco de dados.
    /// </summary>
    /// <param name="livro">Objeto livro a ser cadastrado.</param>
    /// <returns>
    /// Retorna verdadeiro caso o livro seja salvo com sucesso.
    /// </returns>
    public async Task<bool> CriarLivroAsync(Livro livro)
    {
        await _context.Livros.AddAsync(livro);
        await _context.SaveChangesAsync();
        return true;
    }
    /// <summary>
    /// Busca todos os livros cadastrados no banco de dados.
    /// </summary>
    /// <returns>
    /// Lista contendo todos os livros cadastrados.
    /// </returns>
    public async Task<List<Livro>> BuscarTodosLivrosAsync() {
        return await _context.Livros.Include(l => l.Autor).ToListAsync();
    }
    
}

public interface ILivroRepository
{
    Task<bool> CriarLivroAsync(Livro livro);
    Task<List<Livro>> BuscarTodosLivrosAsync();
}