﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProvidersRepository
    {
        void Add(ProviderModel providerModel);
        void Edit(ProviderModel providerModel);
        void Delete(int id);
        IEnumerable<ProviderModel> GetAll();
        IEnumerable<ProviderModel> GetByValues(string values);
    }
}
