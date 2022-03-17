using System;
using Xunit;
using Unit_Testing;


namespace Unit_Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            [Theory]
            [InlineData(200)]
            [InlineData(400)]
            public void canTEstWithdraw(decimal value)
            {
                decimal withdraw = Program.Withdraw(value);
                Assert.Equal(withdraw, Program.ViewBalance());
            }

            [Theory]
            [InlineData(200)]
            [InlineData(400)]
            public void canTestDeposit(decimal value)
            {
                decimal deposit = Program.Deposit(value);
                Assert.Equal(deposit, Program.ViewBalance());
            }
        }
    }
}
