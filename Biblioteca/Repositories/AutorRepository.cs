namespace Biblioteca.Repositories;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

public class AutorRepository: IAutorRepository 
{
    readonly BibliotecaContext _context;

    public AutorRepository(BibliotecaContext context)
    {
        _context = context;
    }
    public async Task<bool> CriarAutorAsync(Autor autor)
    {
        await _context.Autores.AddAsync(autor);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Autor>> BuscarTodosAutoresAsync() {
        return await _context.Autores.ToListAsync();
    }
    
}

public interface IAutorRepository
{
    Task<bool> CriarAutorAsync(Autor autor);
    Task<List<Autor>> BuscarTodosAutoresAsync();
}