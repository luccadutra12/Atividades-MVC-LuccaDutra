using Microsoft.AspNetCore.Mvc;
namespace Exercicio08_Biblioteca.Controllers;
public class HomeController:Controller { public IActionResult Index()=>RedirectToAction("Index","Biblioteca"); public IActionResult Error()=>View(); }