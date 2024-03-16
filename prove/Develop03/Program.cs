class Program
{
    static void Main(string[] args)
    {
        // Creamos una instancia de la clase Reference
        Reference reference = new Reference("2 Nephi", 9, 18);

        // Creamos una instancia de la clase Scripture
        Scripture scripture = new Scripture("But, behold, the arighteous, the bsaints of the Holy One of Israel, they who have believed in the Holy One of Israel, they who have endured the ccrosses of the world, and despised the shame of it, they shall dinherit the ekingdom of God, which was prepared for them ffrom the foundation of the world, and their gjoy shall be full hforever.");

        // Creamos una instancia de la clase Game y comenzamos el juego
        Game game = new Game(reference, scripture);
        game.Start();
    }
}
