using GESGAR.Models;
using Microsoft.AspNetCore.Mvc;

namespace GESGAR.Controllers
{
    public class GarageController : Controller
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

            Voiture voiture2 = new Voiture();
            voiture2.Marque = "Renault";
            voiture2.Id = 2;
            voiture2.Couleur = "Gris";
            voiture2.Etat = "Réservé";
            voiture2.Annee = new DateOnly(2022, 10, 29);

            Garage garage = new Garage();
            garage.Nom = "MonGarage";
            garage.listVoiture = new List<Voiture>();
            garage.listVoiture.Add(voiture);
            garage.listVoiture.Add(voiture2);
            return View(garage);
        }

        public IActionResult Vendre()
        {
            return View();
        }

        public IActionResult Voiture()
        {
            return View();
        }

        public IActionResult Nouvelle()
        {
            return View();
        }

    }
}
