using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VICore;

namespace VICore.Models
{
    public class Identity
    {

        public Gender gender;
        public string FullName;
        public DateTime Birthday;
        public string Address;
        public string Phone;

        public OnlineCharacteristics onlineCharacteristics;
        public PhysicalCharacteristics physicalCharacteristics;
        public Finance finance;
        public Employment employment;
        public TrackingNumbers trackingNumbers;
        public Other other;

        public enum Gender
        {
            Male,
            Female
        }
        public class OnlineCharacteristics
        {
            public string Email, Username, Password, BrowserUserAgent;
            List<Account> accounts;
        }
        public class PhysicalCharacteristics
        {
            public string Height, Weight, BloodType;
        }
        public class Finance
        {
            public string Visa, Expires, CVV2;
        }
        public class Employment
        {
            public string Company, Occupation;
        }
        public class TrackingNumbers
        {
            public string UPSTrackingNumber, WesternUnionMTCN, MoneyGramMTCN;
        }
        public class Other
        {
            public string FavoriteColor;
        }
    } 
}
