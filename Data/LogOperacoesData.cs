using EstoqueLojaV._0._2.Models.Log;
using Microsoft.EntityFrameworkCore;

namespace EstoqueLojaV._0._2.Data
{
    public class LogOperacoesData : DbContext
    {

        private readonly ApplicationDbContext _context;
        
        public LogOperacoesData(DbContextOptions<LogOperacoesData> options, ApplicationDbContext context) : base(options)
        {
            _context = context;
        }


        public void SalvarLog(LogAuditoria log)
        {
            try
            {
                _context.LogsAuditoria.Add(log);
                _context.SaveChanges();
            }
            catch (Exception ex) { }
        }
    }
}
