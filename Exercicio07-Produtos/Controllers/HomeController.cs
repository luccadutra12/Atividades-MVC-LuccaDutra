using Microsoft.AspNetCore.Mvc;
namespace Exercicio07_Produtos.Controllers;
public class HomeController:Controller { public IActionResult Index()=>RedirectToAction("Index","Produto"); public IActionResult Error()=>View(); }