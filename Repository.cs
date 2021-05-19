// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="">
//   
// </copyright>
// <summary>
//   The repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Interview
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The repository.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class Repository<T> : IRepository<T> where T : IStoreable
    {
        /// <summary>
        /// The entities.
        /// </summary>
        private List<T> entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// </summary>
        /// <param name="entities">
        /// The entities.
        /// </param>
        public Repository(List<T> entities)
        {
            this.entities = entities;
        }

        /// <summary>
        /// The all.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<T> All()
        {
            return entities;
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public void Delete(IComparable id)
        {
            entities.Remove(entities.FirstOrDefault(x => x.Id.Equals(id)));
        }

        /// <summary>
        /// The find by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public T FindById(IComparable id)
        {
            return entities.FirstOrDefault(x => x.Id.Equals(id));
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        public void Save(T item)
        {
            entities.Add(item);
        }
    }
}
