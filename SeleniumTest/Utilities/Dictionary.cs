using System.Collections.Generic;

namespace SeleniumTest.Utilities
{
    class Dictionary
    {
        public static Dictionary<string, string> VizDictionary = new Dictionary<string, string>
        {
            //User creation page
            {"userCreated1","The Vizor Portal User, "},
            {"userCreated2",") has been successfully created."},

            //Login page
            {"LoginError", "Your sign in information is not valid. Please try again."}
        };

    }
}
