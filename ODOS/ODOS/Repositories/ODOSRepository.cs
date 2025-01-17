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
        private readonly ILogger _logger;
        private readonly string connectionstring_HM;
        private readonly string connectionstring_ODOS;

        public ODOSRepository(IConfiguration configuration, ILogger logger,ODOSContext ODOScontext)
        {
            _dbcontext = ODOScontext;
            _configuration = configuration;
            this._logger = logger;
            connectionstring_HM = "";
            connectionstring_ODOS = "";
            
        }


      
        

    }
}
;