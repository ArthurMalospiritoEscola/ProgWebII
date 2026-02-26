namespace Biblioteca.Models;

public class Livro {
    public int numPaginas {get;set;}
    public string? autor {get;set;}
    public string? titulo {get;set;}
    public string? genero {get;set;}
    public DateOnly dataPublicacao {get;set;}

    public Livro(int numPaginas, string autor, string titulo, string genero, DateOnly dataPublicacao) {
        this.numPaginas = numPaginas;
        this.autor = autor;
        this.titulo = titulo;
        this.genero = genero;
        this.dataPublicacao = dataPublicacao;
    }
}