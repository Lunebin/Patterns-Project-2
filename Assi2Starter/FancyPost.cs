using System;

namespace Assi2
{
    class FancyPost : Post
    {
        public FancyPost(string t, string b) : base(t, b) {

        }

        public override string getPrintableBody()
        {
            string reverseString = string.Empty;
            for (int i = Body.Length - 1; i >= 0; i--)
            {
                reverseString += Body[i];
            }
            return reverseString;
        }

        public override string getPrintableTitle()
        {
            string reverseString = string.Empty;
            for (int i = Title.Length - 1; i >= 0; i--)
            {
                reverseString += Title[i];
            }
            return reverseString;
        }
    }
}
