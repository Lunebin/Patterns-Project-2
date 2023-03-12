using System;

namespace Assi2
{
    class PostProxy : Content
    {

        private Post post = null;
        private string title;
        private string body = null;
        private bool downloaded = false;

        public PostProxy(int index)
        {
            if (post == null)
            {
                post = new Post();
                title = "Default Title";
                body = "Default Body";
            }
            else
            {
                Console.WriteLine("Error: Post already created.");
            }
        }

        public string printTitle()
        {
            if (post == null)
            {
                return "Error: There is no post.";
            }
            else if (downloaded == true)
            {
                return post.Title;
            }
            else
            {
                return title;
            }
        }

        public void setTitle(string t)
        {
            if (post == null)
            {
                Console.WriteLine("Error: There is no post.");
            }
            else if (downloaded == true)
            {
                post.Title = t.ToString();
            }
            else
            {
                title = t;
            }
        }
        public void setBody(string b)
        {
            if (post == null)
            {
                Console.WriteLine("Error: There is no post.");
            }
            else if (downloaded == true)
            {
                post.Body = b.ToString();
            }
            else
            {
                body = b.ToString();
            }
        }
        public override string printPost()
        {
            if (post == null)
            {
                return "Error: There is no post to print.";
            }
            else if (downloaded == true)
            {
                return post.printPost();
            }
            else
            {
                return title + "\n------\n" + body;
            }
        }
        public void downloadPost()
        {
            downloaded = true;
            post = new FancyPost(title.ToString(), body);
        }
    }
}
