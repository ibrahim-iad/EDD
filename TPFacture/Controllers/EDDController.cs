using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPFacture.Models;
using TPFacture.ViewModels;

namespace TPFacture.Controllers
{
    public class EDDController : Controller
    {
        // GET: EDD
        public ActionResult Index()
        {
            IndexViewModel indexVM = new IndexViewModel();
            return View(indexVM);
        }

        [HttpPost]
        public ActionResult Simuler(IndexViewModel indexVM)
        {
            if (ModelState.IsValid)
            {
                FactureModel factureModel = new FactureModel();
                factureModel.DernierIndex = indexVM.DernierIndex;
                factureModel.IndexActif = indexVM.IndexActif;

                return View(factureModel);
            } else
            {
                return View("Index", indexVM);
            }
        }
    }
}