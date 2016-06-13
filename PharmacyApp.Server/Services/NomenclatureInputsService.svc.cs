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
