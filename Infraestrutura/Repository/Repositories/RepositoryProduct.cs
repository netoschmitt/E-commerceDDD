using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;

using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Produto>, IProduct
    {
    }
}
