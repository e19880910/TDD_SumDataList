using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_SumDataList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_SumDataList.Tests
{
	[TestClass()]
	public class SumDataListGeneraterTests
	{
		[ExpectedException(typeof(ArgumentException))]
		[TestMethod()]
		public void Test_GroupCountIsSmallThenZero_Should_Get_ArgumentException()
		{
			//arrange
			var target = new SumDataListGenerater();
			int gruopCount = -1;
			//act
			var act = target.GetSumDataList<object>(null,null, gruopCount);
		}

		[ExpectedException(typeof(ArgumentException))]
		[TestMethod()]
		public void Test_GroupCount_Is_0_Should_Get_ArgumentException()
		{
			//arrang
			var target = new SumDataListGenerater();
			int gruopCount = 0;

			//act
			var act = target.GetSumDataList<object>(null, null, gruopCount);
		}



		
	}


}