using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public class BibliotecaContext : DbContext
{
    public BibliotecaContext(DbContextOptions<BibliotecaContext> options): base(options)
    {
        
    }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Autor> Autores { get; set; }

    //Falta parâmetrar melhor a criação das tabelas no Db

}