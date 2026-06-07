using Microsoft.AspNetCore.Mvc;
using CadastroAluno.Models; // Ajuste para o nome correto do seu namespace se necessário

namespace CadastroAluno.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                // Passo 5: Redireciona para a View de Confirmação passando os dados do aluno
                return RedirectToAction("Confirmacao", aluno);
            }

            return View(aluno);
        }

        // NOVO MÉTODO: Carrega a página de sucesso com os dados recebidos
        [HttpGet]
        public IActionResult Confirmacao(Aluno aluno)
        {
            return View(aluno);
        }
    }
}