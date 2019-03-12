using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bitwise
{
    [TestFixture]
    class BitwiseTesting
    {
        [Test]
        public void MaxValue()
        {
            Assert.AreEqual(1, CheckMaxValue(5, 2));
            Assert.AreEqual(4, CheckMaxValue(8, 5));
            Assert.AreEqual(0, CheckMaxValue(2, 2));
        }

        private int CheckMaxValue(int num1, int num2)
        {
            int bitwise;
            int max = 0;

            for (var a = 1; a < num1; a++)
            {
                for (var b = a + 1; b <= num1; b++)
                {
                    Console.WriteLine("a: {0}  b: {1}", a, b);
                    bitwise = a & b;
                    Console.WriteLine(bitwise);
                    if (bitwise < num2 && max < bitwise)
                    {
                        max = bitwise;
                        Console.WriteLine("max: {0}", max);
                    }
                }
            }

            return max;
        }
    }
}
