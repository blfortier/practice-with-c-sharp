using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();

            Random likes = new Random();
            var num_likes = likes.Next(1, 10);

            Random dislikes = new Random();
            var num_dislikes = likes.Next(1, 10);

            post._title = "Working with lists";
            post._description = "Explore lists in C# and discover how fun it is.";

            for (var i = 0; i < num_likes; i++)
            {
                post.UpVote();
            }

            for (var i = 0; i < num_dislikes; i++)
            {
                post.DownVote();
            }

            Console.WriteLine("There are {0} votes", post.GetVotes());
            Console.WriteLine("Title: {0}\nDescription: {1}\nCreated: {2}", post._title, post._description, post._created);
        }
    }
}
