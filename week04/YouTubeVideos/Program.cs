using System;

class Program
{
    static void Main(string[] args)
    {
        Comment c1 = new Comment("Jordan", "This guy knows how to play!");
        Comment c2 = new Comment("James", "Seems he already knew the steps to get there");
        Comment c3 = new Comment("Pele", "I didn`t taught him that!");
        Video v1 = new Video("Messi Playing Basketball", "Ronaldinho", 60); 
        v1.AddToCommentsList(c1);
        v1.AddToCommentsList(c2);
        v1.AddToCommentsList(c3);
        v1.DisplayInfo();

        Comment c4 = new Comment("Faker", "This guy knows how to play!");
        Comment c5 = new Comment("Thomas Edson", "Seems he already knew the steps to get there");
        Comment c6 = new Comment("Eren Jaegar", "I didn`t taught him that!");
        Video v2 = new Video("What was that???!!!", "League of Legends", 60); 
        v2.AddToCommentsList(c4);
        v2.AddToCommentsList(c5);
        v2.AddToCommentsList(c6);
        v2.DisplayInfo();    
    
        Comment c7 = new Comment("Stephen King", "This guy knows how to play!");
        Comment c8 = new Comment("Michael Jackson", "Seems he already knew the steps to get there");
        Comment c9 = new Comment("Mc Donalds", "I didn`t taught him that!");
        Video v3 = new Video("I have a Dream", "Chris Rock", 60); 
        v3.AddToCommentsList(c7);
        v3.AddToCommentsList(c8);
        v3.AddToCommentsList(c9);
        v3.DisplayInfo();    
    }
}