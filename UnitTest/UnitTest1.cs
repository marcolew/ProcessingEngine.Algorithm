using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProcessingEngine.Algorithm.Sample;
using ProcessingEngine.Algorithm;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ProcessingEngine.Algorithm.UnitTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Calculate()
		{
			Random r = new Random();
			int a = r.Next();
			int b = r.Next();
			int c = a * b;

			SampleAlgorithm s = new SampleAlgorithm();
			s.Input = a;
			s.Parameter = b;
			s.Run();

			Assert.AreEqual(c, s.Output);
		}

		[TestMethod]
		public void GetInputParameter()
		{
			SampleAlgorithm s = new SampleAlgorithm();
			AlgorithmInfo i = new AlgorithmInfo(s);
			var ip = i.GetInputProperties();
			foreach (var item in ip)
			{
				foreach (var i2 in item.CustomAttributes)
				{
					Console.WriteLine(i2.AttributeType.ToString());
				}
			}
			Assert.IsTrue(ip.Count() > 0);
		}

		[TestMethod]
		public void GetOutputParameter()
		{
			SampleAlgorithm s = new SampleAlgorithm();
			AlgorithmInfo i = new AlgorithmInfo(s);
			var ip = i.GetOutputProperties();
			foreach (var item in ip)
			{
				foreach (var i2 in item.CustomAttributes)
				{
					Console.WriteLine(i2.AttributeType.ToString());
				}
			}
			Assert.IsTrue(ip.Count() > 0);
		}

		[TestMethod]
		public void GetParameter()
		{
			SampleAlgorithm s = new SampleAlgorithm();
			AlgorithmInfo i = new AlgorithmInfo(s);
			var ip = i.GetParameterProperties();
			foreach (var item in ip)
			{
				foreach (var i2 in item.CustomAttributes)
				{
					Console.WriteLine(i2.AttributeType.ToString());
				}
			}
			Assert.IsTrue(ip.Count() > 0);
		}

	}
}
