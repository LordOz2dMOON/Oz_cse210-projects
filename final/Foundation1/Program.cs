using System;

class Program
{
    static void Main(string[] args)
    {
        Video firstVideo = new Video("product 1 specification", "Oswald", 400);
        firstVideo.comments.Add(new Comments("Steve", "This video is very good"));
        firstVideo.comments.Add(new Comments("Andrew", "This video explains the product nicely"));
        firstVideo.comments.Add(new Comments("Sarah", "Thanks for your detailed explanation in this video"));

        Video secondVideo = new Video("product 2 specification", "Michael",450);
        secondVideo.comments.Add(new Comments("Jane", "I like this video"));
        secondVideo.comments.Add(new Comments("Mark", "This video is very good and goes into detail"));
        secondVideo.comments.Add(new Comments("John", "I would like more detail on the product"));

        Video thirdVideo = new Video("product 3 specification", "John", 600);
        thirdVideo.comments.Add(new Comments("Kira", "Where can we order the product?"));
        thirdVideo.comments.Add(new Comments("Ken", "Could you expand a bit more on the product specification"));
        thirdVideo.comments.Add(new Comments("Kris", "I don't think this product does what it is advertised to do correctly"));

        Video fourthVideo = new Video("product 4 specification", "Edgar", 1000);
        fourthVideo.comments.Add(new Comments("Bola", "Is the product available to be shipped to Britain?"));
        fourthVideo.comments.Add(new Comments("Sam", "I would like to order 5"));
        fourthVideo.comments.Add(new Comments("Dan", "what is the product warranty?"));

        List<Video> Videos = new List<Video>();
        Videos.Add(firstVideo);
        Videos.Add(secondVideo);
        Videos.Add(thirdVideo);
        Videos.Add(fourthVideo);

         foreach(Video video in Videos)
        {
            Console.WriteLine($"{video._title}, {video._author}, {video._seconds}, {video.ReturnNumOfComments()}");
             foreach(Comments comment in video.comments)
            {
                Console.WriteLine($"{comment._commentAuthor}, {comment._commentText}");
            }
            Console.WriteLine(" ");
        }
    }
}