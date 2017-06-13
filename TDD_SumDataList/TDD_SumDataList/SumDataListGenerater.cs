using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TDD_SumDataList
{
	public class SumDataListGenerater
	{
		public IList<int> GetSumDataList<T>(IList<T> sourceData , string itemName, int groupCount) where T:class
		{
			if (groupCount <= 0) throw new ArgumentException();
			if (itemName == null) throw new ArgumentException();
			

			throw new NotImplementedException();
		}

	}
}
