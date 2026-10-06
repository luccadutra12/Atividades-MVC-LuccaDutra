using Microsoft.AspNetCore.Mvc; using Exercicio06_Alunos.Models;
namespace Exercicio06_Alunos.Controllers;
public class AlunoController:Controller {
static readonly List<Aluno> alunos=new(){new(){Id=1,Nome="Ana Souza",Idade=16,Curso="Desenvolvimento de Sistemas"},new(){Id=2,Nome="Bruno Lima",Idade=17,Curso="Administração"},new(){Id=3,Nome="Carla Mendes",Idade=16,Curso="Eletrônica"},new(){Id=4,Nome="Diego Alves",Idade=18,Curso="Desenvolvimento de Sistemas"},new(){Id=5,Nome="Eduarda Reis",Idade=17,Curso="Mecânica"},new(){Id=6,Nome="Felipe Costa",Idade=16,Curso="Administração"},new(){Id=7,Nome="Gabriela Rocha",Idade=17,Curso="Desenvolvimento de Sistemas"},new(){Id=8,Nome="Henrique Silva",Idade=18,Curso="Eletrônica"}};
public IActionResult Index()=>View(alunos);
public IActionResult Detalhes(int id){var a=alunos.FirstOrDefault(x=>x.Id==id);return a==null?NotFound():View(a);}
}