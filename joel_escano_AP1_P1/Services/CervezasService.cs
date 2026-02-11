using joel_escano_AP1_P1.DAL;
using joel_escano_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace joel_escano_AP1_P1.Services
{
    public class CervezasService(IDbContextFactory<Contexto> DbFactory)
    {

        public async Task<bool> Existe(int ViajesId) {
            await using var contexto = await DbFactory.CreateDbContextAsync();

            return await contexto.Cervezas.AnyAsync(c => c.IdCerveza == 0);
        }


        public async Task<bool> Insertar(Cervezas Cerveza)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();

            contexto.Cervezas.Add(Cerveza);

            return await contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(Cervezas Cerveza)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();

            contexto.Cervezas.Update(Cerveza);

            return await contexto.SaveChangesAsync() > 0;

        }




        public async Task<bool> Guardar(Cervezas Cerveza)
        {
            if (!await Existe(Cerveza.IdCerveza))
            {
                return await Insertar(Cerveza);

            }
            else
            {
                return await Modificar(Cerveza);
            }
            
        }

        public async Task<List<Cervezas>> Listar(Expression<Func<Cervezas, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();

            return await contexto.Cervezas.AsNoTracking().ToListAsync();
        }


        public async Task<bool> Eliminar(int Id)
        {

            await using var contexto = await DbFactory.CreateDbContextAsync();

            await contexto.Cervezas.AsNoTracking().Where(c => c.IdCerveza == Id).ExecuteDeleteAsync();

            return await contexto.SaveChangesAsync() > 0;
        }


    }
}
