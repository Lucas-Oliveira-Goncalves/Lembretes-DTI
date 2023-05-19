using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using LembretesDTI.Models;
using Microsoft.AspNetCore.Mvc;


namespace LembretesDTI.Controllers
{
    public class LembreteController : Controller
    {
        private static List<Lembrete> lembretes = new List<Lembrete>();

        //public ActionResult Index()
        //{
        //    return View(lembretes);
        //}
        [HttpGet]
        public List<Lembrete> ObterLembretes()
        {
            return lembretes;
        }

        [HttpPost]
        public ActionResult AdicionarLembrete()
        {
            var nome = Request.Form["nome"][0];
            var data = DateTime.Parse(Request.Form["data"][0]);
            int id = CriaId();
            if (String.IsNullOrEmpty(nome))
            {
                ModelState.AddModelError("Nome", "O Nome do bilhete deve estar preenchido");
                return RedirectToAction("Index");
            }

            if (data < DateTime.Now)
            {
                ModelState.AddModelError("Data", "A data deve estar no futuro");
                return RedirectToAction("Index");
            }
            Lembrete lembrete = new Lembrete { Nome = nome, Data = data, Id = id };
            lembretes.Add(lembrete);
            lembretes = lembretes.OrderBy(l => l.Data).ToList();

            return Redirect("https://localhost:7254/");
        }

        protected int CriaId()
        {
            int contador = lembretes.Count();
            int id = 0;
            if (contador != 0)
            {
                Lembrete aux = new Lembrete();
                aux = lembretes[contador - 1];
                id = aux.Id;
            }
            return id + 1;
        }
        [HttpPost]
        public IActionResult RemoverLembrete(int id)
        {
            Lembrete lembrete = lembretes.FirstOrDefault(l => l.Id == id);
            if (lembrete != null)
            {
                lembretes.Remove(lembrete);
            }


            return new OkResult ();
        }
    }
}
