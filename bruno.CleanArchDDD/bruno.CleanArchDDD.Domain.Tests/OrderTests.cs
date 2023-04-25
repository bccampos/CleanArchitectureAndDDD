using bruno.CleanArchDDD.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.CleanArchDDD.Domain.Tests
{
    public class OrderTests
    {
        [Test]
        public void ShouldThrowException_WithInvalidCpf()
        {
            var invalidCpf = "111.111.111-11";
            Exception ex = Assert.Throws<Exception>(() => new Order(invalidCpf, DateTime.UtcNow, 1));

            Assert.AreEqual("Invalid Cpf", ex.Message);
        }

        [Test]
        public void ShouldCreateOrder_With3Items()
        { 
            var validCpf = "778.278.412-36";

            var order = new Order(validCpf, DateTime.UtcNow, 1);

            order.AddItem("1", 1000, 2);
            order.AddItem("2", 5000, 1);
            order.AddItem("3", 30, 3);

            Assert.AreEqual(7090, order.GetTotal());
        }

        [Test]
        public void ShoudlCreateOrder_WithCoupon()
        {
            var validCpf = "778.278.412-36";

            var order = new Order(validCpf, DateTime.UtcNow, 1);
            order.AddItem("1", 1000, 2);
            order.AddItem("2", 5000, 1);
            order.AddItem("3", 30, 3);

            order.AddCoupon(new Coupon("VALE-20", 20, DateTime.UtcNow));
            Assert.AreEqual(5672, order.GetTotal());
        }

        [Test]
        public void Shoudl_Not_CreateOrder_WithQuantityNegative()
        {
            var validCpf = "778.278.412-36";

            Exception ex = Assert.Throws<Exception>(() => new Order(validCpf, DateTime.UtcNow, -1));

            order.AddCoupon(new Coupon("VALE-20", 20, DateTime.UtcNow));
            Assert.AreEqual("Invalid Quantity", ex.Message);
        }


    }
}
