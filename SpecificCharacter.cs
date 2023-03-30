namespace FactFinderOnlineTest
{
    internal class SpecificCharacter
    {
        public static string GetMiddle(string input)
        {
            try
            {
                // offset variable to the appropriate value (Example: 1 for even, 0 for odd)
                var offset = input.Length % 2 == 0 ? 1 : 0;

                return input.Substring(input.Length / 2 - offset, offset + 1);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
