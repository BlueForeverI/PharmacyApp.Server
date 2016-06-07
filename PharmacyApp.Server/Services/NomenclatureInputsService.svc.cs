using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AutoMapper;
using PharmacyApp.Server.App.Services;
using PharmacyApp.Server.Models;
using PharmacyApp.Server.Repositories;
using NomenclatureInput = PharmacyApp.Server.App.Models.NomenclatureInput;

namespace PharmacyApp.Server.App.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NomenclatureInputsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NomenclatureInputsService.svc or NomenclatureInputsService.svc.cs at the Solution Explorer and start debugging.
    public class NomenclatureInputsService : INomenclatureInputsService
    {
        private NomenclatureInputRepository repo = new NomenclatureInputRepository();

        static NomenclatureInputsService()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Server.Models.NomenclatureInput, NomenclatureInput>());
        }

        public List<NomenclatureInput> GetAllNomenclatureInputs()
        {
            var existingInputs = repo.FindAll();
            var proxies = existingInputs.Select(Mapper.Map<NomenclatureInput>)
                .ToList();

            return proxies;
        }
    }
}
