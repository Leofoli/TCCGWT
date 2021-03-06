using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TCCGWT.Models;

namespace TCCGWT.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Cadastro(ClienteCadastroModel cliente)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://20.114.208.185/api/cliente");
                var result = await client.PostAsJsonAsync<ClienteCadastroModel>("cliente", cliente);

                if (result.IsSuccessStatusCode)
                {
                    var ApiResponse = await result.Content.ReadAsStringAsync();

                    var res = JsonConvert.DeserializeObject<Int64>(ApiResponse);
                    if (res == 0)
                    {
                        ModelState.AddModelError(string.Empty, "Dados inválidos");
                        return View();
                    }
                    return RedirectToAction("Login", "Login");
                }
            }

            ModelState.AddModelError(string.Empty, "Servidor off ");

            return View();
        }
    }
}