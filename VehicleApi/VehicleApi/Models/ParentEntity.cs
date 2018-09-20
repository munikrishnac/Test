using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Secura
{
	public abstract class ParentEntity
	{
		public ParentEntity()
		{
			_id = ObjectId.GenerateNewId().ToString();
		}

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

		private string _id;

	}
}