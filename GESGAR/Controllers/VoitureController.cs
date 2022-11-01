using GESGAR.Models;
using Microsoft.AspNetCore.Mvc;

namespace GESGAR.Controllers
{
    public class VoitureController : Controller
    {
        public IActionResult Index()
        {
            Voiture voiture;
            voiture = new Voiture();
            voiture.Marque = "Peugeot";
            voiture.Id = 1;
            voiture.Couleur = "Noir";
            voiture.Etat = "Préparation";
            voiture.Annee = new DateOnly(2022, 10, 29);
            voiture.Immatriculation = "OO-999-OO";
            voiture.Kilometrage = 200000;
            voiture.Carburant = "Diesel";
            voiture.Modele = "407";
            return View(voiture);
        }
    }
}
