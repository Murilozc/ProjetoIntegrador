using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoI4.Models;
using Microsoft.AspNetCore.Http;
namespace ProjetoI4.Controllers
{
    public class PacotesController : Controller
    {
         public IActionResult Fretamento()
        {   
            
            return View();
        }
        [HttpPost]
        public IActionResult Fretamento (FretamentoeTurismo T){
            
            PacotesBD novo = new PacotesBD();
            PacotesBD.Inserir_FretamentoeTurismo(T);
            
            ViewBag.FretamentoeTurismo = "O seu pedido de orçamento foi enviado!";
            return View();
        }
        public IActionResult FaleConosco()
        {   
            
            return View();
        }
        [HttpPost]
        public IActionResult FaleConosco (FaleConosco a){
            
            PacotesBD ur = new PacotesBD();
            PacotesBD.Inserir_FaleConosco(a);
            
            ViewBag.FaleConosco = "A sua dúvida foi enviada com sucesso!";
            return View();
        }
        
        public IActionResult Aempresa()
        {
            return View();
        }
         public IActionResult Lista()
        {
            if(HttpContext.Session.GetString("Conta") != "administrador")
             return RedirectToAction("Login");

            PacotesBD pacotesbd = new PacotesBD();
            List<Pacotes> Lista = PacotesBD.Listar();
            return View (Lista);
        }
        public IActionResult Cadastro()
    {       if(HttpContext.Session.GetString("Conta") != "administrador")
            return RedirectToAction("Login");
       return  View();

    }
    [HttpPost]
    public IActionResult Cadastro(Pacotes pacotes)
    {
          if(HttpContext.Session.GetString("Conta") != "administrador")
            return RedirectToAction("Login");

         PacotesBD pacotesbd = new PacotesBD();
           PacotesBD.Inserir(pacotes);
           ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View ();   
    }
       public IActionResult Editar(int Id)
    {
         if(HttpContext.Session.GetString("Conta") != "administrador")
            return RedirectToAction("Login");

        PacotesBD pacotesbd = new PacotesBD();
        Pacotes pacotes = PacotesBD.BuscarPorId(Id);
        return View(pacotes);


    }
    [HttpPost]
    public IActionResult Editar(Pacotes pacotes)
    {
       if(HttpContext.Session.GetString("Conta") != "administrador")
            return RedirectToAction("Login");


         PacotesBD pacotesbd = new PacotesBD();
           PacotesBD.Atualizar(pacotes);
           ViewBag.Mensagem = "Pacote Turístico atualizado com sucesso!";
            return RedirectToAction ("Lista");   
    }
    public IActionResult Remover(int Id)
    {
       
        PacotesBD pacotesbd = new PacotesBD();
        PacotesBD.Remover(Id);
        return RedirectToAction ("Lista");   
    }
    public IActionResult PacotesDisponiveis()
    {
    
            PacotesBD pacotesbd = new PacotesBD();
            List<Pacotes> Pacotes = PacotesBD.Listar();
            return View (Pacotes);
    }
        
        
        //Login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
           Usuario UsuarioEncontrado = UsuarioBD.ValidarLogin(usuario);
           
           
            if(UsuarioEncontrado !=null)
            {
               
                HttpContext.Session.SetInt32("Id", UsuarioEncontrado.Id);
                HttpContext.Session.SetString("Nome", UsuarioEncontrado.Nome);
                HttpContext.Session.SetString("Conta", UsuarioEncontrado.Conta);
                ViewBag.Mensagem = "Você Está Logado!";
               
            }
            else{
               
                ViewBag.Mensagem = "Falha no login!";
                
            }
            return View();

        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}