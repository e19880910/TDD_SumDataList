using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_SumDataList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
			//arrange
			var target = new SumDataListGenerater();
			int gruopCount = 0;

			//act
			var act = target.GetSumDataList<object>(null, null, gruopCount);
		}

		[ExpectedException(typeof(ArgumentException))]
		[TestMethod()]
		public void Test_ItemName_Is_not_exist_Should_Get_ArgumentException()
		{
			//arrange
			var target = new SumDataListGenerater();
			int gruopCount = 1;

			//act
			var act = target.GetSumDataList<object>(null, null, gruopCount);
		}

	
		[TestMethod()]
		public void Test_GroupCount_is_3_ItemName_is_Cost_Should_Get_6_15_24_21()
		{
			//arrange
			var target = new SumDataListGenerater();
			int groupCount = 3;
			ICollection<object> source = new List<object>();
			string itemName = "Cost";
			ICollection expected = new List<int>() {6,15,24,21 };

			//act
			ICollection act = target.GetSumDataList(source, itemName, groupCount);

			//assert
			CollectionAssert.AreEqual(expected, act);
		}



		[TestMethod()]
		public void Test_GroupCount_is_4_ItemName_is_Revenue_Should_Get_50_66_60()
		{
			//arrange
			var target = new SumDataListGenerater();
			int groupCount = 4;
			ICollection<object> source = new List<object>();
			string itemName = "Revenue";
			ICollection expected = new List<int>() {50,66,60};

			//act
			ICollection act = target.GetSumDataList(source, itemName, groupCount);

			//assert
			CollectionAssert.AreEqual(expected, act);
		}



	}


}