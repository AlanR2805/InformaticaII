using Heap;
using System;
using Xunit;

namespace HeapTest
{
	public class HeapTest
	{
		[Fact]
		public void HeapfyTest()
		{
			int[] arreglo = { 3, 8, 6, 4, 21, 12 };
			Program.Heapify(arreglo);
			Assert.Equal(new int[] { 21, 12, 8, 6, 4, 3 }, arreglo);			
		}
	}
}
