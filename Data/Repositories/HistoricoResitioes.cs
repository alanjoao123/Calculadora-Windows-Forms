using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class HistoricoRepository
    {
        #region Constructors

        protected HistoricoRepository(DbContext context)
        {
            Context = context;
        }

        #endregion

        #region Properties

        protected readonly DbContext Context;

        #endregion

        #region Methods

        public IQueryable<Historico> GetAll()
        {
            return Context.Set<Historico>().AsNoTracking();
        }

        public IQueryable<Historico> Get(Func<Historico, bool> predicate)
        {
            return GetAll().AsEnumerable().Where(predicate).AsQueryable();
        }

        public Historico Find(long id)
        {
            return Context.Set<Historico>().AsNoTracking().FirstOrDefault(t => t.Id.Equals(id));
        }

        public virtual async Task<bool> Insert(Historico obj)
        {

            Context.Set<Historico>().Add(obj);
            return await SalvarTodos();
        }

        public virtual async Task<bool> Update(Historico obj)
        {
            var dbEntity = Context.Set<Historico>().Where(x => x.Id == obj.Id).SingleOrDefault();

            if (dbEntity != null)
            {

                Context.Entry(dbEntity).CurrentValues.SetValues(obj);
                Context.Entry(dbEntity).State = EntityState.Modified;
                return await SalvarTodos();
            }

            return false;
        }

        public virtual async Task<bool> SalvarTodos()
        {
            return await Context.SaveChangesAsync() > 0;
        }

        public virtual async Task<bool> Delete(long id)
        {
            var entity = Context.Set<Historico>().FirstOrDefault(e => e.Id.Equals(id));

            if (entity == null)
                return false;


            return await Update(entity);
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        #endregion
    }
}
