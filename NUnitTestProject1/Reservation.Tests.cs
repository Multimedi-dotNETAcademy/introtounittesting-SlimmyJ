using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    internal class ReservationTests

    {
        [SetUp]
        public void SetUp()

        {
        }

        [Test]
        public void WhenUserIsNotAdminandReservationMadeByUser_CheckifCancelIsPossible_ResultEqualsTrue()
        {
            //ARRANGE
            User _testuser = new User
            {
                IsAdmin = false
            };

            Reservation _testreservation = new Reservation
            {
                MadeBy = _testuser
            };

            //ACT
            bool result = _testreservation.CanBeCancelledBy(_testuser);

            //ASSERT

            Assert.AreEqual(true, result);
        }

        [Test]
        public void WhenUserIsNotAdminAndReservationNotMadeByUser_CheckifCancelIsPossible_ResultEqualsFalse()
        {
            //ARRANGE
            User _testuser = new User
            {
                IsAdmin = false
            };

            Reservation _testreservation = new Reservation();

            //ACT
            bool result = _testreservation.CanBeCancelledBy(_testuser);

            //ASSERT

            Assert.AreEqual(false, result);
        }

        [Test]
        public void WhenUserIsAdminAndReservationNotMadeByUser_CheckifCancelIsPossible_ResultEqualsTrue()
        {
            //ARRANGE
            User _testuser = new User
            {
                IsAdmin = true
            };

            Reservation _testreservation = new Reservation();

            //ACT
            bool result = _testreservation.CanBeCancelledBy(_testuser);

            //ASSERT

            Assert.AreEqual(true, result);
        }

        [Test]
        public void WhenUserIsAdminAndReservationMadeByUser_CheckifCancelIsPossible_ResultEqualsTrue()
        {
            //ARRANGE
            User _testuser = new User
            {
                IsAdmin = true
            };

            Reservation _testreservation = new Reservation
            {
                MadeBy = _testuser
            };

            //ACT
            bool result = _testreservation.CanBeCancelledBy(_testuser);

            //ASSERT

            Assert.AreEqual(true, result);
        }
    }
}