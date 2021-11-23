using System.Text.RegularExpressions;

namespace carserveprime.console
{
    public class RegistrationFormatValidator
    {
        public bool validateRegistration(ref string regnNumber)
        {
            regnNumber = Regex.Replace(regnNumber, @"\s+", "");
            const string regPattern = "^[A-Z]{2}[ -][0-9]{1,2}(?: [A-Z])?(?: [A-Z]*)? [0-9]{4}$";
            bool isRegistrationvalid = Regex.IsMatch(regnNumber, regPattern);
            return isRegistrationvalid;
        }
    }
}


