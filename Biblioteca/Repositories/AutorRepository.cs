namespace Biblioteca.Repositories;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Repositório responsável pelas operações de acesso e manipulação de dados relacionadas à entidade Autor.
///
/// Esta classe realiza consultas e persistência de autores utilizando o Entity Framework Core.
/// </summary>
public class AutorRepository: IAutorRepository 
{
    private readonly BibliotecaContext _context;
    /// <summary>
    /// Inicializa uma nova instância do repositório de autores.
    /// </summary>
    /// <param name="context">
    /// Contexto do banco de dados utilizado para acessar os dados.
    /// </param>
    public AutorRepository(BibliotecaContext context)
    {
        _context = context;
    }
    /// <summary>
    /// Cria um novo autor no banco de dados.
    /// </summary>
    /// <param name="autor">Objeto autor a ser cadastrado.</param>
    /// <returns>
    /// Retorna verdadeiro caso o autor seja salvo com sucesso.
    /// </returns>
    public async Task<bool> CriarAutorAsync(Autor autor)
    {
        await _context.Autores.AddAsync(autor);
        await _context.SaveChangesAsync();
        return true;
    }
    /// <summary>
    /// Busca todos os autores cadastrados no banco de dados.
    /// </summary>
    /// <returns>
    /// Lista contendo todos os autores cadastrados.
    /// </returns>
    public async Task<List<Autor>> BuscarTodosAutoresAsync() {
        return await _context.Autores.ToListAsync();
    }
    
}
/// <summary>
/// Define os contratos de acesso aos dados da entidade Autor.
/// </summary>
public interface IAutorRepository
{
    /// <summary>
    /// Cria um novo autor no banco de dados.
    /// </summary>
    Task<bool> CriarAutorAsync(Autor autor);
    /// <summary>
    /// Retorna todos os autores cadastrados.
    /// </summary>
    Task<List<Autor>> BuscarTodosAutoresAsync();
}