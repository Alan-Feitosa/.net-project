using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using System;
using System.Collections.Generic;

namespace ClassroomHub.Services
{
    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository _moduleRepository;

        public ModuleService(IModuleRepository moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }
        public IEnumerable<Module> GetAll()
        {
            return _moduleRepository.GetAll();
        }

        public void Add(Module module)
        {
            _moduleRepository.Add(module);
        }

        public Module GetById(Guid id)
        {
            return _moduleRepository.GetById(id);
        }
    }
}
