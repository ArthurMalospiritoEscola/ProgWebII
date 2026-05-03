namespace Biblioteca.Models;

public class Autor
{
    public int Id {get;set;}
    public string? Nome {get;set;}
    public string? Descricao {get;set;}
    public string? ImageName {get;set;}

    public Autor(int id,string Nome,string Descricao,string ImageName)
    {   
        this.Id =id;
        this.Nome= Nome;
        this.Descricao = Descricao;
        this.ImageName =ImageName;
    }
}