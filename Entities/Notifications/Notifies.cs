using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notitycoes = new List<Notifies>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifies> Notitycoes { get; set; }



        // validaçao todos campos/obj no dominio
        public bool ValidaPropriedadeString(string valor, string nomepropriedade)
        {
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Campo obrigatório",
                    NomePropriedade = nomepropriedade
                });

                return false;
            }

            return true;
        }

        // validaçao prop int/obj no dominio
        public bool ValidaPropriedadeInt(int valor, string nomepropriedade)
        {
            if (valor > 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomepropriedade
                });

                return false;
            }

            return true;
        }

        // validaçao campos decimal no dominio
        public bool ValidaPropriedadeDecimal(decimal valor, string nomepropriedade)
        {
            if (valor > 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomepropriedade
                });

                return false;
            }

            return true;
        }
    }
}
