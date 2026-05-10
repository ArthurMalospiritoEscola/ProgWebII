using Biblioteca.Models;
using Biblioteca.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Importa a variável de conexão com o Banco de dados de appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); //Olhar variável de DefaultConection, pode estar errada

// Add services to the container.
builder.Services.AddControllersWithViews();

//Cria a relação do BibliotecaContext com o bano de dados escolhido.
builder.Services.AddDbContext<BibliotecaContext> (options => options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString)));

//Adiciona os dois repositorys para identificação do banco de dados.
builder.Services.AddScoped<ILivroRepository,LivroRepository>();
builder.Services.AddScoped<IAutorRepository,AutorRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Biblioteca}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
