using System;
using Xunit;

namespace PointTest
{
    public class UnitTestPoint
    {
        private Point _pointForTest;

        public UnitTestPoint()
        {
            _pointForTest = new Point(1, 2, 3);
        }

        [Fact]
        public void InitializeClass()
        {
            double x = _pointForTest.X;
            double y = _pointForTest.Y;
            double r = _pointForTest.R;

            Assert.Equal(x, 1.0);
            Assert.Equal(y, 2.0);
            Assert.Equal(r, 3.0);
        }

        [Fact]
        public void GetByIndex()
        {
            double x = _pointForTest[0];
            double y = _pointForTest[1];

            Assert.Equal(x, 1.0);
            Assert.Equal(y, 2.0);
        }

        [Fact]
        public void SetX(){
            _pointForTest.X = 5;
            Assert.Equal(_pointForTest.X, 5);
        }

        [Fact]
        public void SetY(){
            _pointForTest.Y = 8;
            Assert.Equal(_pointForTest.Y, 8);
        }

        [Fact]
        public void SetRadius(){
            _pointForTest.R = 50;
            Assert.Equal(_pointForTest.R, 50);
        }

        [Fact]
        public void PositionMove()
        {
            _pointForTest.Move(5, 5);

            double x = _pointForTest.X;
            double y = _pointForTest.Y;

            Assert.Equal(x, 6);
            Assert.Equal(y, 7);
        }

        [Fact]
        public void MultipleOnScalar(){
            _pointForTest.Scalar = 5;

            double x = 1.0 * 5;
            double y = 2.0 * 5;

            Assert.Equal(x, _pointForTest.X);
            Assert.Equal(y, _pointForTest.Y);
        }

        [Fact]
        public void DistanceFromBeginning()
        {
            double x = _pointForTest.Distance();

            Assert.Equal(x, Math.Sqrt(1.0 + 4.0));
        }

        [Fact]
        public void PositionIncrement()
        {
            _pointForTest++;

            double x = _pointForTest.X;
            double y = _pointForTest.Y;

            Assert.Equal(x, 2.0);
            Assert.Equal(y, 3.0);
        }

        [Fact]
        public void PositionDecrement()
        {
            _pointForTest--;

            double x = _pointForTest.X;
            double y = _pointForTest.Y;

            Assert.Equal(x, 0.0);
            Assert.Equal(y, 1.0);
        }

        [Fact]
        public void PointsEquals(){
            Point truePoint = new Point(1, 2, 3);
            Point falsePoint = new Point(3, 2, 1);

            Assert.True(truePoint == _pointForTest);
            Assert.False(falsePoint == _pointForTest);
        }

        [Fact]
        public void PointsUnequals()
        {
            Point truePoint = new Point(3, 2, 1);
            Point falsePoint = new Point(1, 2, 3);

            Assert.True(truePoint != _pointForTest);
            Assert.False(falsePoint != _pointForTest);
        }

        [Fact]
        public void SumPoints(){
            Point result = new Point(3, 4, 3);
            var sum = _pointForTest + 2;

            Assert.Equal(sum.X, result.X);
            Assert.Equal(sum.Y, result.Y);
        }
    }
}
