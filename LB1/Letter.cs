using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class Letter
    {
        string _recipient;
        DateTime _sentDate;
        const double BASE_PRICE = .50;
        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }

        public override string ToString()
        {
            return SentDate.ToString("dd/MMM/yyyy") + ", " +
                Recipient + ", " + Price.ToString("c");
        }

        public string Recipient
        {
            get
            {
                return _recipient;
            }
        }

        public DateTime SentDate
        {
            get
            {
                return _sentDate;
            }
        }

        virtual public double Price
        {
            get
            {
                return BASE_PRICE;
            }
        }
    }
}
