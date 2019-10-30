using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApp.Models;
using WebApp.Utils;

namespace WebApp.Controllers
{
    public class ColaboradorController : Controller
    {

        // GET: Colaborador
        public ActionResult Index()
        {
            var result = DefaultClient.GetAsync("https://localhost:44393/api/colaborador").Result;

            List<Colaborador> colaboradorList = JsonConvert.DeserializeObject<List<Colaborador>>(result);

            return View(colaboradorList);
        }

        // GET: Colaborador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Colaborador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colaborador/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Colaborador/Edit/5
        public ActionResult Edit(int id)
        {
            var result = DefaultClient
                .GetAsync(string.Format("https://localhost:44393/api/colaborador/{0}", id)).Result;

            Colaborador colaborador = JsonConvert.DeserializeObject<Colaborador>(result);

            return View(colaborador);

        }

        //Post: Colaborador/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm]Colaborador editedColaborador)
        {
            try
            {
                var result = DefaultClient
                    .PutAsync($"https://localhost:44393/api/colaborador/{id}", editedColaborador).Result;

                Colaborador colaborador = JsonConvert.DeserializeObject<Colaborador>(result);
               
                return View(colaborador);



                // TODO: Add update logic here

                // return View(collection);
            }
            catch
            {
                return View();
            }
        }

        // GET: Colaborador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Colaborador/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}