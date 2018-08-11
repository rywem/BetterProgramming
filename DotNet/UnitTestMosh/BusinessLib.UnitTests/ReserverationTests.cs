using System;
using BusinessLib.Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLib.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCanceledBy_UserIsAdmin_ReturnsTrue()
        {
            // arrage 
            var reservation = new Reservation();
            // act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCanceledBy_SameUserCancellingReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            var reservation = new Reservation() { MadeBy = new User() };
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}
