namespace DoorsWebProject.Data.Common
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public static class ExceptionMessages
	{
		public const string SoftDeleteOnNonSoftDeletableEntity =
			"Soft Delete can't be performed on an Entity which doesn't support it!";
	}
}
