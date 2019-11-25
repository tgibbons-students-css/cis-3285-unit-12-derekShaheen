using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// @author Derek Shaheen
/// @date 11/24/2019
/// @description Assignment code used for the user object
/// </summary>
namespace SubtypeCovariance
{
    public class User : Entity
    {
        public User(Guid newID) : base(newID)
        {
            EmailAddress = "";
        }

        public static Guid newID { get; private set; }
        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
