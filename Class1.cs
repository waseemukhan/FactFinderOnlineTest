using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactFinderOnlineTest
{
    internal class Class1 
    { 
        public static bool IsFormat(string str, string f) 
        { 
            var allowedDict = new Dictionary<string, bool>() 
            { 
                { "number", true }, 
                { "date", true }, 
                { "timespan", true } 
            }; 

            int isNotAllowed = 0;
            
            for (var i = 1; i < allowedDict.Count; i++) 
            { 
                if (f == allowedDict.Keys.ToArray()[i - 1])
                { 
                    isNotAllowed |= 1 << i; 
                } 
            } 
            
            if (isNotAllowed > 0) 
                throw new Exception("Format not allowed."); 

            if (f.ToLower() == "number") 
                return Int32.TryParse(str, out var _); 

            else if (f.ToLower() == "date") 
                return DateTime.TryParse(str, out var _); 

            else if (f.ToLower() == "timespan") 
                return DateTime.TryParse(str, out var _); 

            throw new Exception("Unknown format."); 
        }

        // Simplified version of above IsFormat method
        public static bool IsFormatUpdatedVersion(string input, string f)
        {
            try
            {
                var allowedFormatStrArr = new string[] { "number", "datetime", "timespan" };
                var format = f.ToLower();

                if (!allowedFormatStrArr.Contains(format))
                {
                    throw new Exception(String.Format("Format '{0}' not allowed.", format));
                }

                switch (format)
                {
                    case "number":
                        return Int32.TryParse(input, out var _);
                    case "datetime":
                        return DateTime.TryParse(input, out var _);
                    case "timespan":
                        return TimeSpan.TryParse(input, out var _);
                    default:
                        throw new Exception("Unknown format.");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured in the IsFormatUpdatedVersion method:", ex);
            }

        }
    }
}

