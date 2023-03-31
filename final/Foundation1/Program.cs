using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        // First video

        Video video1 = new Video();
        video1._title = "Web Development In 2023 - A Pratical Guide";
        video1._author = "Brad Traversy";
        video1._length = 180;

        Comment comment1 = new Comment();
        comment1._name = "Arnold";
        comment1._text = "A new year and a new great practical guide video from Brad.";

        Comment comment2 = new Comment();
        comment2._name = "Ryan C";
        comment2._text = "I love your videos Brad, keep them coming.";

        Comment comment3 = new Comment();
        comment3._name = "Sam Suarez";
        comment3._text = "You're the best Brad, I was waiting for this one. Thanks for your hard work.";

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        // Second video

        Video video2 = new Video();
        video2._title = "Nvidia CEO Jensen Huang On A.I.";
        video2._author = "CNBC";
        video2._length = 1800;

        Comment comment4 = new Comment();
        comment4._name = "TriuMusik";
        comment4._text = "We created the thing called accelerated pricing and it's taken until now to really take off.";

        Comment comment5 = new Comment();
        comment5._name = "Thuy Doan";
        comment5._text = "Great summary of modern tech, felt a bit advertorial, but hey... no one's asking the hard questions.";

        Comment comment6 = new Comment();
        comment6._name = "Danny";
        comment6._text = "I want to see what they do with Nitendo on the next switch";

        Comment comment7 = new Comment();
        comment7._name = "Ben";
        comment7._text = "Better take advantage of A.I. and learn it to gain an advantage, A.I. is here to stay.";

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);

        // Third video

        Video video3 = new Video();
        video3._title = "The Suggar Lobby: How the Industry Hides The Real Harm Caused By Sugar";
        video3._author = "ENDEVR";
        video3._length = 3300;

        Comment comment8 = new Comment();
        comment8._name = "Brenda P";
        comment8._text = "Anyone else enjoy watching food documentaries?";

        Comment comment9 = new Comment();
        comment9._name = "Jenni Franklin";
        comment9._text = "Never let a company tell u only the good things about a product. I'm teaching my children early in life.";

        Comment comment10 = new Comment();
        comment10._name = "Olivia";
        comment10._text = "I love watching food documentaries.";

        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);

        // Add videos to list
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        // Iterate
        foreach (Video currentVideo in videosList)
        {
            Console.WriteLine($"Title: {currentVideo._title}");
            Console.WriteLine($"Author: {currentVideo._author}");
            Console.WriteLine($"Length: {currentVideo._length}");
            Console.WriteLine($"Number of comments: {currentVideo._comments.Count}\n");

            Console.WriteLine("Comments made on this video:");
            foreach (Comment currentComment in currentVideo._comments)
            {
                currentComment.DisplayComment();
            }

            Console.WriteLine("\n\n");
        }
    }
}