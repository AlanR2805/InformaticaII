using System;
using Xunit;

namespace BinTreeTests
{
    public class BinTreeTests
    {
        [Fact]
        public void TestSumar()
        {
            IBinTree sut = new BinaryTree(
                8,
                new BinaryTree(6),
                new BinaryTree(
                    10,
                    new BinaryTree(5),
                    null
                )
            );

            Assert.Equal(29, sut.Suma());
        }

        [Fact]
        public void TestdeInsert()
        {
            IBinTree sut = new BinaryTree(8);
            sut.Insert(60);
            sut.Insert(15);
            sut.Insert(55);
            sut.Insert(2);
            sut.Insert(20);
            sut.Insert(25);
            sut.Insert(7)
                ;
            int[] result = sut.ToArray();

            Assert.Equal(new int[] {2,7,15,20,25,55,60}, result);
        }
    }
}
