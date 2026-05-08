namespace Biblioteca.Repositories;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

public class LivroRepository: ILivroRepository 
{
    readonly BibliotecaContext _context;

    public LivroRepository(BibliotecaContext context)
    {
        _context = context;
    }
    public async Task<bool> CriarLivroAsync(Livro livro)
    {
        await _context.Livros.AddAsync(livro);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Livro>> BuscarTodosLivrosAsync() {
        return await _context.Livros.Include(l => l.Autor).ToListAsync();
    }
    
}

public interface ILivroRepository
{
    Task<bool> CriarLivroAsync(Livro livro);
    Task<List<Livro>> BuscarTodosLivrosAsync();
}