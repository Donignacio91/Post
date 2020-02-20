using ShopPost.Data;
using ShopPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Application.Reposiories
{
    public class RepositoryShop
    {
        ContextShop context;
        public RepositoryShop(ContextShop context)
        {
            this.context = context;
        }
        public List<Camiseta> GetCamisetas()
        {
            var consulta = from datos in context.Camisetas
                           select datos;
            return consulta.ToList();
        }
        public Camiseta GetCamisetaID(int id)
        {
            var consulta = from datos in context.Camisetas
                           where datos.IdProducto == id
                           select datos;
            return consulta.SingleOrDefault();
        }
    }
}