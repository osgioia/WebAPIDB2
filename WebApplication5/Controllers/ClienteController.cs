using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class ClienteController : ApiController
    {
        // GET: Cliente
        public ObjectResult<Cliente_TraerTodo_Result> Get()
        {
            Taller_MecanicoEntities taller_MecanicoEntities = new Taller_MecanicoEntities();
            var clientes = taller_MecanicoEntities.Cliente_TraerTodo();
            return clientes;
        }
    }
}