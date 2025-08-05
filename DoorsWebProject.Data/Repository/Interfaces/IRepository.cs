namespace DoorsWebProject.Data.Repository.Interfaces
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IRepository<TEntity,TKey>
	{
		TEntity? GetById(TKey id);
		IEnumerable<TEntity> GetAll();

		TEntity? SingleOrDefault(Func<TEntity, bool> predicate);

		TEntity? FirstOrDefault(Func<TEntity, bool> predicate);

		void Add(TEntity item);

		void AddRange(IEnumerable<TEntity> items);

		bool SoftDelete(TEntity entity);

		bool HardDelete(TEntity entity);

		bool Update(TEntity item);

		void SaveChanges();
	}
}
