using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_SumDataList
{
	public class SumDataListGenerater
	{
		public IList<int> GetSumDataList<T>(IList<T> sourceData , string itemName, int groupCount = 0)
		{
			if (groupCount <= 0) throw new ArgumentException();
			throw new NotImplementedException();
		}

	}
}
