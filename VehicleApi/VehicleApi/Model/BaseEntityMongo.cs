using Api.Model;
using System;

namespace Secura.Core
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract partial class BaseEntityMongo: ParentEntity
	{
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        //public int Id { get; set; }

        /// <summary>
        /// Is transient
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Result</returns>
        private static bool IsTransient(BaseEntityMongo obj)
        {
            return obj != null && Equals(obj.Id, default(int));
        }

        /// <summary>
        /// Get unproxied type
        /// </summary>
        /// <returns></returns>
        private Type GetUnproxiedType()
        {
            return GetType();
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Result</returns>
        public override bool Equals(object obj)
        {
            if (obj != null)
                return Equals(obj as BaseEntity);
            else
                return false;
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="other">other entity</param>
        /// <returns>Result</returns>
        public virtual bool Equals(BaseEntityMongo other)
        {
			if (other == null)
				return false;

			if (ReferenceEquals(this, other))
				return true;

			if (!IsTransient(this) &&
				!IsTransient(other) &&
				Equals(Id, other.Id))
			{
				var otherType = other.GetUnproxiedType();
				var thisType = GetUnproxiedType();
				return thisType.IsAssignableFrom(otherType) ||
						otherType.IsAssignableFrom(thisType);
			}

			return false;
		}

        /// <summary>
        /// Get hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (Equals(Id, default(int)))
                return base.GetHashCode();
            return Id.GetHashCode();
        }

        /// <summary>
        /// Equal
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <returns>Result</returns>
        public static bool operator ==(BaseEntityMongo x, BaseEntityMongo y)
        {
            return Equals(x, y);
        }

        /// <summary>
        /// Not equal
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <returns>Result</returns>
        public static bool operator !=(BaseEntityMongo x, BaseEntityMongo y)
        {
            return !(x == y);
        }
    }
}
