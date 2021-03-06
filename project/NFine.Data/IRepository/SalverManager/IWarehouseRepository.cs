﻿using NFine.Data.Entity.SalverManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Data.IRepository.SalverManager
{
    public interface IWarehouseRepository : IRepositoryBase<Warehouse>
    {
        void DeleteForm(int keyValue);
        void SubmitForm(Warehouse userEntity, int? keyValue);
    }
}
