using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class FillUserProfileCommand
    {
        public bool SetUserData(string name, int age)
        {
            Page userProfilePage = new UserProfilePage();
            userProfilePage.LoadPage();
            Element nameField = new TextField();
            nameField.SetText(name);
            Element ageField = new TextField();
            ageField.SetText(age.ToString());
            Element saveButton = new Button();
            saveButton.Click();
            return true;
        }
    }
}
