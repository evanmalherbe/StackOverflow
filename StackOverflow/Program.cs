using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    public class Program
    {

        public class Post
        {
            public int Upvotes { get; set; }
            public int Downvotes { get; set; }

            public void UpvotePost()
            {
                Upvotes++;
            }

            public void DownvotePost()
            {
                Downvotes++;
            }
        }
        static void Main(string[] args)
        {
            Post post = new Post();
            ConsoleKey pressedKey = ConsoleKey.H;
            int value = 0;
            post.Upvotes = 0;
            post.Downvotes = 0;

            string postText = "This is a blog title" + "\nThis is the body of the blog post" + "\nDate posted: 9 November 2022";
            string msg = "Upvotes: " + post.Upvotes + ", Downvotes: " + post.Downvotes + "\nPress up arrow to upvote, down arrow to downvote. Esc to exit.";
            //Console.WriteLine(msg);

            while (pressedKey != ConsoleKey.Escape || value == 0)
            {
                Console.WriteLine(postText);
                Console.WriteLine();
                Console.WriteLine(msg);
                               
                pressedKey = Console.ReadKey().Key;

                if (pressedKey == ConsoleKey.UpArrow)
                    post.UpvotePost();

                if (pressedKey == ConsoleKey.DownArrow)
                    post.DownvotePost();

                value++;

                Console.Clear();

                postText = "This is a blog title" + "\nThis is the body of the blog post" + "\nDate posted: 9 November 2022";
                msg = "Upvotes: " + post.Upvotes + ", Downvotes: " + post.Downvotes + "\nPress up arrow to upvote, down arrow to downvote. Esc to exit.";

            }
        }
    }
}
