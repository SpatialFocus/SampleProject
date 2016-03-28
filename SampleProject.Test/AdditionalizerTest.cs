namespace SampleProject.Test
{
	using System.Diagnostics;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class AdditionalizerTest
	{
		[TestMethod]
		public void Add_AAndBAreZero_ReturnsZero()
		{
			Additionalizer additionalizer = new Additionalizer();

			int result = additionalizer.Add(0, 0);

			Debug.Assert(result == 0);
		}
	}
}