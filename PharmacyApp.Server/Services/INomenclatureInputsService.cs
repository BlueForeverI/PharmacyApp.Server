using System.Collections.Generic;
using System.ServiceModel;
using PharmacyApp.Server.App.Models;

namespace PharmacyApp.Server.App.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INomenclatureInputsService" in both code and config file together.
    [ServiceContract]
    public interface INomenclatureInputsService
    {
        [OperationContract]
        List<NomenclatureInput> GetAllNomenclatureInputs();
    }
}
