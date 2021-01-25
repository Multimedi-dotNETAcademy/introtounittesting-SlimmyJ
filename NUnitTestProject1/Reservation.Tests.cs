using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    internal class ReservationTests

    {
        [SetUp]
        public void SetUp()

        {
            User _testadmin = new User();
            _testadmin.IsAdmin = true;
        }

        [Test]
        public void WhenUserIsNotAdminandReservationMadeByUser_CheckifCancelIsPossible_ResultEqualsTrueOrFalse()
        {
            //ARRANGE
            User _testuser = new User();
            _testuser.IsAdmin = false;

            Reservation _testreservation = new Reservation();
            _testreservation.MadeBy = _testuser;

            //ACT
            bool result = _testreservation.CanBeCancelledBy(_testuser);

            //ASSERT

            Assert.AreEqual(result, true);
        }

        [Test]
        public void WhenUserIsNotAdminAndReservationNotMadeByUser_CheckifCancelIsPossible_ResultEqualsTrueOrFalse()
        {
            //ARRANGE
            User _testuser = new User();
            _testuser.IsAdmin = false;

            Reservation _testreservation = new Reservation();

            //ACT
            bool result = _testreservation.CanBeCancelledBy(_testuser);

            //ASSERT

            Assert.AreEqual(result, false);
        }

        [Test]
        public void WhenUserIsAdminAndReservationNotMadeByUser_CheckifCancelIsPossible_ResultEqualsTrueOrFalse()
        {
            //ARRANGE
            User _testuser = new User();
            _testuser.IsAdmin = true;

            Reservation _testreservation = new Reservation();

            //ACT
            bool result = _testreservation.CanBeCancelledBy(_testuser);

            //ASSERT

            Assert.AreEqual(result, true);
        }

        [Test]
        public void WhenUserIsAdminAndReservationMadeByUser_CheckifCancelIsPossible_ResultEqualsTrueOrFalse()
        {
            //ARRANGE
            User _testuser = new User();
            _testuser.IsAdmin = true;

            Reservation _testreservation = new Reservation();
            _testreservation.MadeBy = _testuser;

            //ACT
            bool result = _testreservation.CanBeCancelledBy(_testuser);

            //ASSERT

            Assert.AreEqual(result, true);
        }
    }
}