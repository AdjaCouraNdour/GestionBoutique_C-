﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionBoutiqueC.core;
using GestionBoutiqueC.data.entities;


namespace GestionBoutiqueC.repository.interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        Client SelectByTelephone(string telephone);
    }
}
