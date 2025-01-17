using Microsoft.AspNetCore.Mvc;
using ODOS.Models;
using System.Collections;
using ODOS.Interfaces;
using ODOS.Context;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace ODOS.Repositories

{
    public class ODOSRepository : IODOSInterface
    {
        private ODOSContext _dbcontext;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ODOSRepository> _logger;
        private readonly string connectionstring_HM;
        private readonly string connectionstring_ODOS;

        public ODOSRepository(IConfiguration configuration, ILogger<ODOSRepository> logger,ODOSContext ODOScontext)
        {
            _dbcontext = ODOScontext;
            _configuration = configuration;
            _logger = logger;
            connectionstring_HM = "";
            connectionstring_ODOS = "";
            
        }

        public contractmaster GetContractMasterData()
        {
            // Initialize the ContractDetails list with predefined data
            var contractdata = new List<contractdata>
            {
                new contractdata
                {
                    IntContractNo = 44944,
                    VchContractCode = "4020007973",
                    VchDescription = "NULL",
                    InterfaceId = 111,
                    Mandt = "600",
                    IdMessage = "2024-12-18-11.31.33.228",
                    CustId = 1103480,
                    MarketSeg = "1",
                    Name1Gp = "SIN STAR PRECAST (M) SDN BHD",
                    Name2Gp = "NULL",
                    StartDate = new DateTime(2024, 12, 16),
                    EndDate = new DateTime(2024, 12, 18),
                    CabFormerType = "NULL",
                    SegManager = "NULL",
                    AccManager = "NULL",
                    Status = "A",
                    ChrMeshInd = 1,
                    ChrWireRodInd = 2,
                    ChrRebarInd = 1,
                    ChrCabInd = 1,
                    ChrPrecage = 1,
                    ChrBpcInd = 1,
                    ChrPcsTrand = 3,
                    ChrColdRollWire = 2,
                    ChrPreCutWire = 1,
                    ChrCarInd = 1,
                    ChrPrcMeshInd = "NULL",
                    UpdateStatus = "Y"
                }
            };

            // Initialize the contractmaster object
            var contractMaster = new contractmaster
            {
                CODE = 200, // Example status code
                MSG = "Success", // Example message
                DATA = contractdata
            };

            return contractMaster;
        }





    }
}
;