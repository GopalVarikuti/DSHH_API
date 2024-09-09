using DSHH_API.Models;
using DSHH_API.Services.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Security.Cryptography;

namespace DSHH_API.Services
{
    public class StatService : IStatService
    {
        IConfiguration Configuration;
        IConfigurationSection applicationsettings;
        private readonly DshhContext _context;

        SqlConnection cnn;
        SqlDataAdapter sda;
        DataTable dt;
        DataSet ds;
        string? conn = null;
        public StatService(DshhContext context) { 
            
            this._context = context;
        }

        public string GetStat()
        {
            try
            {
                connection();
                //logger.LogInformation("DB connection connected sucessfully");
            }
            catch (Exception ex)
            {
                //logger.LogError("Database connectivity issue =>" + ex.Message);
            }
            DshhContext context = new DshhContext();
            var users = context.Stats;

            /*Stat stat = new Stat()
            {
                Description = users.,
            };*/
            return "Raj";
        }

        public void connection()
        {
            cnn = new SqlConnection(conn);
            cnn.Open();
        }

        public Stat GetStats()
        {
            var data = _context.Stats.ToList();

            Stat statData = new Stat()
            {
                Description = data[0].Description,
                Noofevents = data[0].Noofevents,
                Volunteers = data[0].Volunteers,
                Amountcollected = data[0].Amountcollected + " Lakh Rupees",
                Helpedbypeople = data[0].Helpedbypeople
            };
            return statData;
        }
    }
}
