using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Video> myvideos = new List<Video>();
        
        Video vid1 = new Video();
        {
            Comment com1 = new Comment();
            {
                com1._user = "User1";
                com1._text = "Lorem ipsum dolor";
            }

            Comment com2 = new Comment();
            {
                com2._user = "User2";
                com2._text = "Sit amet, consectetur adipiscing elit.";
            }

            Comment com3 = new Comment();
            {
                com3._user = "User3";
                com3._text = "Sed do eiusmod tempor incididunt ut labore.";
            }

            vid1._author = "Creator1";
            vid1._title = "Youtube1";
            vid1._length = 30;

            vid1._comments.Add(com1);
            vid1._comments.Add(com2);
            vid1._comments.Add(com3);
        }
    

        // Second Video
        Video vid2 = new Video();
        {
            Comment com1 = new Comment();
            {
                com1._user = "Uuser1";
                com1._text = "Et dolore magna aliqua.";
            }

            Comment com2 = new Comment();
            {
                com2._user = "Uuser2";
                com2._text = "Ut enim ad minim veniam.";
            }

            Comment com3 = new Comment();
            {
                com3._user = "Uuser 3";
                com3._text = "Quis nostrud exercitation ullamco laboris nisi.";
            }

            vid2._author = "Creator2";
            vid2._title = "Youtube2";
            vid2._length = 30;

            vid2._comments.Add(com1);
            vid2._comments.Add(com2);
            vid2._comments.Add(com3);
        }

        Video vid3 = new Video();
        {
            Comment com1 = new Comment();
            {
                com1._user = "Uuuser1";
                com1._text = "Ut aliquip ex ea commodo consequat.";
            }

            Comment com2 = new Comment();
            {
                com2._user = "Uuuser2";
                com2._text = "Duis aute irure dolor in reprehenderit.";
            }

            Comment com3 = new Comment();
            {
                com3._user = "Uuuser 3";
                com3._text = "In voluptate velit esse cillum dolore eu fugiat.";
            }

            vid3._author = "Creator3";
            vid3._title = "Youtube3";
            vid3._length = 30;

            vid3._comments.Add(com1);
            vid3._comments.Add(com2);
            vid3._comments.Add(com3);
        }

        myvideos.Add(vid1);
        myvideos.Add(vid2);
        myvideos.Add(vid3);

        foreach (Video video in myvideos)
        {
            video.GetVideo();
        }
    }
}