﻿using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public async Task AddProduct(Produto produto)
        {
            var validaNome = produto.ValidaPropriedadeString(produto.Nome, "Nome");

            var validaValor = produto.ValidaPropriedadeDecimal(produto.Valor, "Valor");

            if(validaNome && validaValor)
            {
                produto.Estado = true;
                await _IProduct.Add(produto);
            }
        }

        public async Task UpdateProduct(Produto produto)
        {
            var validaNome = produto.ValidaPropriedadeString(produto.Nome, "Nome");

            var validaValor = produto.ValidaPropriedadeDecimal(produto.Valor, "Valor");

            if (validaNome && validaValor)
            {
                await _IProduct.Update(produto);
            }
        }
    }
}
