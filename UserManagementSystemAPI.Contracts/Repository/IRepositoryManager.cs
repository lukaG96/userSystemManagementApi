﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystemAPI.Contracts.Repository
{
    public interface IRepositoryManager
    {
        IUserRepository UserRepository { get; }
        IUnitOfWork UnitOfWork { get; }
        IStatusRepository StatusRepository { get; }
    }
}
