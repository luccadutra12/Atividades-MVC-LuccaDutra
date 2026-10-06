using Microsoft.AspNetCore.Mvc;
namespace Exercicio09_Veterinaria.Controllers;
public class HomeController:Controller { public IActionResult Index()=>RedirectToAction("Index","Veterinaria"); public IActionResult Error()=>View(); }