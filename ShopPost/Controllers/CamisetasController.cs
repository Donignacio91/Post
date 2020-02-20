using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Reposiories;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Mvc;

namespace ShopPost.Controllers
{
    public class CamisetasController : Controller
    {
        RepositoryShop repo;
        public CamisetasController(RepositoryShop repo)
        {
            this.repo = repo;
        }

        // GET: Camisetas
        public ActionResult CompraCamisetas(string cual, string like, string dislike, int count)
        {
            ViewData["msj"] = "";
            if (like == "like")
            {
                ViewData["msj"] = "Te ha gustado la "+ cual;
                    Trace.TraceInformation("La " + cual + " ha recibido un  " + like);
                    MetricTelemetry metricaLike = new MetricTelemetry();
                    metricaLike.Name = "Like "+ cual;
                    metricaLike.Sum = count;
                    TelemetryClient client = new TelemetryClient();
                    client.TrackEvent("Evento Like");
                    client.TrackMetric(metricaLike);

            }
            else if (dislike == "dislike")
            {
                ViewData["msj"] = "No te ha gustado la " + cual;
                Trace.TraceInformation("La " + cual + " ha recibido un  " + dislike);
                    MetricTelemetry metricaDislike = new MetricTelemetry();
                    metricaDislike.Name = "dislike "+ cual;
                    metricaDislike.Sum = count;
                    TelemetryClient client = new TelemetryClient();
                    client.TrackEvent("Evento dislike");
                    client.TrackMetric(metricaDislike);
                }

            return View(repo.GetCamisetas().ToList());
        }
      

    
    }
}