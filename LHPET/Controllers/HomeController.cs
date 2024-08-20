using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPET.Models;

namespace LHPET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(1," Augusto Reis", "857.032.950-41", "augustoreis2@gmail.com", "Bombom");
        Cliente cliente2 = new Cliente(2,"Augusto Igino", "039.618.250-09", "augustoreis2@gmail.com", "Bombom");
        Cliente cliente3 = new Cliente(3,"Augusto Igino", "039.618.250-09", "augustoreis2@gmail.com", "Bombom");
        Cliente cliente4 = new Cliente(4,"Augusto Igino", "039.618.250-09", "augustoreis2@gmail.com", "Bombom");
        Cliente cliente5 = new Cliente(5,"Augusto Igino", "039.618.250-09", "augustoreis2@gmail.com", "Bombom");

        //lista de clientes e atribuir clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(1, "c# pet sa", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(2, "php pet sa", "14.182.102/0001-80", "php@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(3, "c++ pet sa", "14.182.102/0001-80", "c++@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(4, "java pet sa", "14.182.102/0001-80", "java@pet.org");
        Fornecedor fornecedor5 = new Fornecedor(5, "css pet sa", "14.182.102/0001-80", "css@pet.org");

        //lista de fornecedor e atribuir fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
