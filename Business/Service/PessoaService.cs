using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DAO;

namespace Business.Service
{
    public class PessoaService:GenericService<Pessoa>
    {
        public PessoaService():base(new PessoaDAO())
        {

        }

        public Pessoa Find(string name)
        {
            //O PROBLEMA ESTÁ AQUI
            base.dao.Fin
        }
    }
}
