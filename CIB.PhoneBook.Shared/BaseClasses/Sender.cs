using System;
using System.Runtime.Serialization;
using System.Web;
using CIB.PhoneBook.Shared.Interfaces;

namespace CIB.PhoneBook.Shared.BaseClasses
{
    public class Sender : ISender
    {
        [DataMember] public int LocalIdUser { get; set; } = 0;
        [DataMember] public string LocalUsername { get; set; }
        [DataMember] public string LocalPassword { get; set; }
        [DataMember] public string UserEmailAddress { get; set; }
        [DataMember] public string UserMailPassword { get; set; }
        [DataMember] public int? IdWorkingAs { get; set; }
        [DataMember] public string WorkingAsUsername { get; set; }
        [DataMember] public int LocalIdDealer { get; set; } = 0;
        [DataMember] public int LocalDealerCode { get; set; } = 0;
        [DataMember] public string LocalDealerName { get; set; }
        [DataMember] public DateTime RequestDateTime { get; set; } = DateTime.Now;

        public Sender()
        {
            //var loggedInUser = HttpContext.Current.Session["LoggedInUser"] as MotovateUser ?? new MotovateUser();
            //LocalIdUser = loggedInUser.IdUser;
            //LocalUsername = loggedInUser.Username;
            //UserEmailAddress = loggedInUser.Email;
            //UserMailPassword = loggedInUser.ExchangePassword;
            //LocalIdDealer = loggedInUser.Dealer.IdDealer;
            //LocalDealerCode = loggedInUser.Dealer.DealerCode;
            //LocalDealerName = loggedInUser.Dealer?.DealerName;

            //var workingAsUser = HttpContext.Current.Session["MotovateUser"] as MotovateUser ?? loggedInUser ?? new MotovateUser();
            //IdWorkingAs = workingAsUser.IdUser;
            //WorkingAsUsername = workingAsUser.Username;
        }



    }
}
