using Microsoft.AspNetCore.Mvc;
namespace Exercicio06_Alunos.Controllers;
public class HomeController:Controller { public IActionResult Index()=>RedirectToAction("Index","Aluno"); public IActionResult Error()=>View(); }