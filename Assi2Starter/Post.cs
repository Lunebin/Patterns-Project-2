using System;

namespace Assi2
{
    class Post : Content
    {
        public string Title;
        public string Body;

        public Post(string t, string b) {
            this.Title = t;
            this.Body = b;
        }

        public Post()
        {
             Clone();
        }

        public virtual string getPrintableTitle()
        {
            return Title;
        }

        public virtual string getPrintableBody()
        {
            return Body;
        }

        public override string printPost()
        {
            return getPrintableTitle() + "\n------\n" + getPrintableBody();
        }

        public Post Clone()
        {
            return new Post("blank", "blank");
        }
    }
}
