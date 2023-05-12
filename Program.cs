using BirdsFlyingAroundApp.Classes;

namespace BirdsFlyingAroundApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlackBird blackBird = new BlackBird("Solsort", "mellem", "mellem, spids", "sort", "admindlig");
            Penguin penguin = new Penguin("pinvin", "mellem til stor", "kort", "sort og hvid", "svømmefødder");

            blackBird.SetLocation(15, 10);
            blackBird.SetAltitude(12);
            blackBird.Draw();

            penguin.SetLocation(12, 13);
            penguin.Draw();
        }
    }
}