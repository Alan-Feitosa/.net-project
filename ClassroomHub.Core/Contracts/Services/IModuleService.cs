using System;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Core.Contracts.Services
{
    public interface IModuleService
    {
        IEnumerable<Module> GetAll();
        void Add(Module module);
        Module GetById(Guid id);
    }
}
