using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Charlie bit my finger","CocoMelon", 2);
        Comment comment1 = new Comment("Billybob1", "haha look, charlie bit his finger!");
        video1.makeComment(comment1);
        Comment comment2 = new Comment("zoomy321", "Charlie is so weird bahahahha");
        video1.makeComment(comment2);
        Comment comment3 = new Comment("craftmaster74", "what a baby i bet that didn't even hurt");
        video1.makeComment(comment3);
        video1.PrintVideo();

        Video video2 = new Video("How to tie a tie","HowtoChannel", 3);
        Comment vid2comment1 = new Comment("Hankgilbert3","Thanks man, I used this to teach my son");
        video2.makeComment(vid2comment1);
        Comment vid2comment2 = new Comment("jackattack25","I accidentally tied a half hitch, help");
        video2.makeComment(vid2comment2);
        Comment vid2comment3 = new Comment("bieberfeverfan332","Is it the same way for a bow tie???");
        video2.makeComment(vid2comment3);
        video2.PrintVideo();

        Video video3 = new Video("My Apology...","Smilevlogs", 5);
        Comment vid3comment1 = new Comment("redheadredemption34","L take, your ungrateful");
        video3.makeComment(vid3comment1);
        Comment vid3comment2 = new Comment("Johnjohnjohnjohn08","Ya right, I doubt he is soryy");
        video3.makeComment(vid3comment2);
        Comment vid3comment3 = new Comment("Ibitcharliesfinger321","Thanks for the apology man, keep up with the vlogs!");
        video3.makeComment(vid3comment3);
        video3.PrintVideo();
    }
}