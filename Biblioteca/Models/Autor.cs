namespace Biblioteca.Models;

public class Autor
{
    public int Id {get;set;}
    public string? Nome {get;set;}
    public string? imageName {get;set;}

    public Autor(int id,string Nome,string imageName)
    {   
        this.Id =id;
        this.Nome= Nome;
        this.imageName =imageName;
    }
}