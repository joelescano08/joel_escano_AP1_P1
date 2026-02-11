using joel_escano_AP1_P1.DAL;
using joel_escano_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace joel_escano_AP1_P1.Services
{
    public class ViajesEspacialesService(IDbContextFactory<Contexto> DbFactory)
    {



        public async Task<bool> Guardar(Cerveza ViajesEspaciales)
        {
            return true;
        }

        public async Task<bool> Existe(int ViajesId) {  return true; }

        public async Task<bool> Eliminar() {  return true; }

        public async Task<List<Cerveza>> Listar(Expression<Func<Cerveza, bool >> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();


            return await contexto.ViajesEspaciales.Where(criterio).AsNoTracking().ToListAsync();

        }









    }
}
