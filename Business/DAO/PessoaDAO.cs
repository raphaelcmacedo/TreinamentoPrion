﻿using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DAO
{
    public class PessoaDAO:GenericDAO<Pessoa>
    {
        public Pessoa FindByName (string nome)
        {
            return null;
        }
    }
}
