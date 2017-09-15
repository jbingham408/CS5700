
using System.Runtime.Serialization;

namespace PersonMatcher
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int ObjectId;
        [DataMember]
        public string StateFileNumber;
        [DataMember]
        public string SocialSecurityNumber;
        [DataMember]
        public string FirstName;
        [DataMember]
        public string MiddleName;
        [DataMember]
        public string LastName;
        [DataMember]
        public int BirthYear;
        [DataMember]
        public int BirthMonth;
        [DataMember]
        public int BirthDay;
        [DataMember]
        public string Gender;
        [DataMember]
        public string NewbornScreeningNumber;
        [DataMember]
        public string IsPartOfMultipleBirth;
        [DataMember]
        public int BirthOrder;
        [DataMember]
        public string BirthCounty;
        [DataMember]
        public string MotherFirstName;
        [DataMember]
        public string MotherMiddleName;
        [DataMember]
        public string MotherLastName;
        [DataMember]
        public string Phone1;
        [DataMember]
        public string Phone2;
    }
}
