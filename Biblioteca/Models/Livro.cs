namespace Biblioteca.Models;

public class Livro {

    public int Id {get;set;}
    public int NumPaginas {get;set;}
    public string? Autor {get;set;}
    public string? Titulo {get;set;}
    public string? Genero {get;set;}
    public DateOnly DataPublicacao {get;set;}


    public Livro(int numPaginas, string autor, string titulo, string genero, DateOnly dataPublicacao) {
        this.NumPaginas = numPaginas;
        this.Autor = autor;
        this.Titulo = titulo;
        this.Genero = genero;
        this.DataPublicacao = dataPublicacao;
    }
}