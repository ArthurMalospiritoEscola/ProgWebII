namespace Biblioteca.Models;

public class Livro {

    public int Id {get;set;}
    public string? Titulo {get;set;}
    public int NumPaginas {get;set;}
    public int AutorId {get;set;}
    public Autor? Autor {get;set;}
    public Genero Genero {get;set;}
    public DateOnly DataPublicacao {get;set;}

    public string? ImageName {get;set;}

}