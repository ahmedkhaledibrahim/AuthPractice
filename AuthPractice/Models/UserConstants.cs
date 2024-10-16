namespace AuthPractice.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel(){ Username = "Ahmed Khaled",EmailAddress = "ahmed@gmail.com", Password = "Ahmed123", Role = "Admin",GivenName="Ahmed",Surname="Khaled"},
            new UserModel(){ Username = "Khaled Ibrahim",EmailAddress = "khaled@gmail.com", Password = "Khaled123", Role = "User",GivenName="Khaled",Surname="Ibrahim"},
            new UserModel(){ Username = "Mazen Mohamed",EmailAddress = "Mazen@gmail.com", Password = "MD123", Role = "Seller",GivenName="Mohamed",Surname="Mazen"}
        };
    }
}
