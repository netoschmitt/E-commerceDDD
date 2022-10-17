using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IServiceProduct
    {
        // metodos customizados - verificações regras de negocio
        Task AddProduct(Produto produto);
        Task UpdateProduct(Produto produto);
    }
}
