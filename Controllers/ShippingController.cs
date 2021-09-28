using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ShippingController : Controller
  {
    [HttpPost("/Shipping/Index")]
    public ActionResult Index(int width, int length, int height, int weight)
    {
      Parcel parcelToSend = new Parcel(width, length, height, weight);
      parcelToSend.FindVolume();
      parcelToSend.CostToShip(); 
      return View(parcelToSend);
    }
  }
}