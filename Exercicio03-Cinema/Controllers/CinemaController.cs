using Microsoft.AspNetCore.Mvc;
namespace Exercicio03_Cinema.Controllers;
public class CinemaController:Controller { public IActionResult Index()=>View(); public IActionResult Filmes()=>View(); public IActionResult Ingressos()=>View(); }