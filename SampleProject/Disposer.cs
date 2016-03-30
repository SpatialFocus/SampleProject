namespace SampleProject
{
	using System.IO;

	public class Disposer
	{
		FileStream newFile;

		public void NoDisposeMethod()
		{
			this.newFile = new FileStream(@"c:\temp.txt", FileMode.Open);
		}
	}
}