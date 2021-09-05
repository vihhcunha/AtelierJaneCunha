using AtelierJaneCunhaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AtelierJaneCunhaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("/home")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("contato")]
        public IActionResult Contato()
        {
            ViewBag.Sucesso = null;
            return View();
        }

        [Route("sobre-nos")]
        public IActionResult SobreNos()
        {
            return View();
        }

        [Route("catalogo")]
        public IActionResult Catalogo()
        {
            return View();
        }

        [Route("contato")]
        [HttpPost]
        public async Task<IActionResult> Contato(MensagemContato mensagemContato)
        {
            if (!ModelState.IsValid) return View(mensagemContato);

            try
            {
                var emailRemetente = _configuration["EmailSettings:Email"];
                var senhaRemetente = _configuration["EmailSettings:Senha"];
                var emailDestinatarioContato = _configuration["EmailRecipientContact"];

                using (var smtpClient = new SmtpClient("SMTP.office365.com", 587))
                {
                    smtpClient.Credentials = new NetworkCredential(emailRemetente, senhaRemetente);
                    smtpClient.EnableSsl = true;

                    await smtpClient.SendMailAsync(emailRemetente, emailDestinatarioContato, "Contato do site institucional", mensagemContato.Nome + " - " + mensagemContato.Email + " - " + mensagemContato.Mensagem);
                }

                ViewBag.Sucesso = true;
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Sucesso = false;
                return View();
            }
        }
    }
}
