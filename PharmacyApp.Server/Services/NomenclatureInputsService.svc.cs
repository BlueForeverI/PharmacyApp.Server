using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AutoMapper;
using PharmacyApp.Server.App.Models;
using PharmacyApp.Server.App.Services;
using PharmacyApp.Server.Repositories;

namespace PharmacyApp.Server.App.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NomenclatureInputsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NomenclatureInputsService.svc or NomenclatureInputsService.svc.cs at the Solution Explorer and start debugging.
    public class NomenclatureInputsService : INomenclatureInputsService
    {
        public static void AppInitialize()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Server.Models.NomenclatureInput, NomenclatureInput>());
        }

        public List<NomenclatureInput> GetAllNomenclatureInputs()
        {
            return new NomenclatureInputRepository()
                .FindAll()
                .Select(Mapper.Map<NomenclatureInput>)
                .ToList();
        }
    }
}
