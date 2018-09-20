
namespace Api.Model
{
    using MongoDB.Bson;

    /// <summary>
    /// ParentEntity.
    /// </summary>
    public abstract class ParentEntity
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="ParentEntity"/> class.
        /// </summary>
        public ParentEntity()
		{
			_id = ObjectId.GenerateNewId().ToString();
		}

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id
		{
			get { return _id; }
			set
			{
				if (string.IsNullOrEmpty(value))
					_id = ObjectId.GenerateNewId().ToString();
				else
					_id = value;
			}
		}

        /// <summary>
        /// The identifier.
        /// </summary>
        private string _id;

	}
}
