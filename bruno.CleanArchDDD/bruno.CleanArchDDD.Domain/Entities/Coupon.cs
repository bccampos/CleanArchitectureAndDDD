using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.CleanArchDDD.Domain.Entities
{
    public class Coupon
    {
        public string Code { get; private set; }
        public int Percentage { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public Coupon(string code, int percentage, DateTime expireDate)
        {
            Code = code;
            Percentage = percentage;
            ExpireDate = expireDate;
        }

        public bool IsExpired()
        {
            return ExpireDate.Date < DateTime.UtcNow.Date;
        }
    }
}
