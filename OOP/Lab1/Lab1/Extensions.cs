using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	public static class Extensions
	{
		public static string Repr<T>(this ICollection<T> collection, string separator)
		{
			if (collection.Count != 0)
			{
				StringBuilder sb = new StringBuilder();
				foreach (var item in collection)
				{
					sb.Append(item.ToString());
					if (separator == "\n")
					{
						sb.AppendLine();
					}
					sb.Append(separator);
					//sb.Append(", ");
				}
				sb.Remove(sb.Length - 2, 2);
				return sb.ToString();
			}
			return "";
		}
	}
}
