namespace Biblioteca.Models;

public class Livro {

    public int Id {get;set;}
    public string? Titulo {get;set;}
    public int NumPaginas {get;set;}
    public Autor Autor {get;set;}
    public Genero Genero {get;set;}
    public DateOnly DataPublicacao {get;set;}

    public string? ImageName {get;set;}


    public Livro(int id, string titulo,Autor autor, int numPaginas, Genero genero, DateOnly dataPublicacao, string imageName) {
        this.Id = id;
        this.NumPaginas = numPaginas;
        this.Autor = autor;
        this.Titulo = titulo;
        this.Genero = genero;
        this.DataPublicacao = dataPublicacao;
        this.ImageName=imageName;
    }
}