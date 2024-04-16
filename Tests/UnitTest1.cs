using Lesson9;
using System;
using System.Runtime.Serialization;

namespace Tests
{
    public class TrianleTests
    {
        private string _tmp;

        public TrianleTests()
        {
            _tmp = "123";
        }

        [Theory]
        [InlineData(4, 2, 4)]
        [InlineData(0, 0, 0)]
        public void GetSquare_ReturnsValue(int expected, int a, int b)
        {
            var triangle = new Triangle(a, b, 3);
            var actual = triangle.GetSquare();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-2, 4)]
        [InlineData(-1, 0)]
        public void GetSquare_ReturnsArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, 3));
        }

        [Theory]
        [MemberData(nameof(Triangles))]
        public void ExampleTest(Triangle triangle, int expected)
        {
            var actual = triangle.GetSquare();
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> Triangles =>
            new List<object[]>
            {
                new object[] { new Triangle(1, 246,1), 123 },
                new object[] { new Triangle(1, 0, 1), 0}
            };
    }
}