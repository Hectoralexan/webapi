using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;

namespace WebAppBar.Controllers
{
    public class ProductoController : ApiController
    {
        [System.Web.Http.HttpPost]
        public IHttpActionResult Add()
        {
            using (Models.ProductosEntities2 db = new Models.ProductosEntities2())
            {
                var oproducto = new Models.ListaProductos();
                oproducto.nombre_producto = "jugoDelballe";
                oproducto.precio_venta = 80;
                db.ListaProductos.Add(oproducto);
                db.SaveChanges();
            return Ok("Hecho");
            }
        }
    }
}