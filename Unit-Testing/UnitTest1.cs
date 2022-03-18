using System;
using Xunit;
using Lab02a_Unit_Tests_Documentation;


namespace Unit_Testing
{
    public class UnitTest1
    {

        [Fact]
        public void Test_deposit_less_than_zero()
        {
            Assert.Equal(Program.balance, Program.Deposit(-99));
        }


        [Fact]
        public void Test_withdraw_grater_than_balance()

        {
            Assert.Equal(Program.balance, Program.Withdraw(245));
        }


        [Fact]
        public void Test_withdraw_less_than_zero()
        {
            Assert.Equal(Program.balance, Program.Withdraw(-4));


        }
    }
}
