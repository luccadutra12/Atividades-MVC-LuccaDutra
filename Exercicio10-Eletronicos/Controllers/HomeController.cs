using Microsoft.AspNetCore.Mvc;
namespace Exercicio10_Eletronicos.Controllers;
public class HomeController:Controller { public IActionResult Index()=>RedirectToAction("Index","Eletronico"); public IActionResult Error()=>View(); }