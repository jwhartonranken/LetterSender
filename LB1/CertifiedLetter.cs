using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class CertifiedLetter : Letter
    {
        string _trackingNumber;
        const double CERTIFIED_PRICE = .65;

        public CertifiedLetter(string recipient, DateTime sentDate, string trackingNumber) : base(recipient, sentDate)
        {
            _trackingNumber = trackingNumber;
        }

        public override string ToString()
        {
            return base.SentDate.ToString("dd/MMM/yyyy") + ", " + Recipient + ", " + Price.ToString("c");
        }

        public string TrackingNumber
        {
            get
            {
                return _trackingNumber;
            }
        }

        public override double Price
        {
            get
            {
                return CERTIFIED_PRICE;
            }
        }

    }
}
