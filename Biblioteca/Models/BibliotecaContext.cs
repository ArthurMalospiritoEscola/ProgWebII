using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

/// <summary>
/// Contexto do banco de dados da aplicação de Biblioteca.
/// Classe que representa a conexão com o banco de dados.
/// Reponsável por gerenciar a comunicação com o banco de dados utilizando o EF (Entity Framework)
/// </summary>
public class BibliotecaContext : DbContext
{
    /// <summary>
    /// Inicializa uma nova instância do contexto da biblioteca.
    /// </summary>
    /// <param name="options">
    /// Opções de configuração do contexto fornecidas pelo Entity Framework.
    /// </param>
    public BibliotecaContext(DbContextOptions<BibliotecaContext> options): base(options)
    {
        
    }
    /// <summary>
    /// Cria e representa a conexão da tabela livros no banco de dados.
    /// </summary>
    public DbSet<Livro> Livros { get; set; }
    /// <summary>
    /// Cria e representa a conexão da tabela atuores no banco de dados.
    /// </summary>
    public DbSet<Autor> Autores { get; set; }

}