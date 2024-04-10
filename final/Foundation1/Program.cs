class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Solicitar al usuario que ingrese detalles de videos y comentarios
        while (true)
        {
            Console.WriteLine("Enter video details:");
            Video video = new Video();
            Console.Write("Title: ");
            video.Title = Console.ReadLine();
            Console.Write("Author: ");
            video.Author = Console.ReadLine();
            Console.Write("Length (in seconds): ");
            video.Length = int.Parse(Console.ReadLine());

            // Solicitar al usuario que ingrese comentarios para el video
            Console.WriteLine("Enter comments (press Enter to finish):");
            while (true)
            {
                Console.Write("Commenter's Name (or press Enter to finish): ");
                string commenterName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(commenterName))
                {
                    break;
                }
                Console.Write("Comment Text: ");
                string commentText = Console.ReadLine();
                video.AddComment(commenterName, commentText);
            }

            videos.Add(video);

            Console.Write("Do you want to add another video? (yes/no): ");
            string response = Console.ReadLine();
            if (response.ToLower() != "yes")
            {
                break;
            }
        }

        // Mostrar los detalles de cada video ingresado por el usuario
        Console.WriteLine("\nVideos Details:");
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}