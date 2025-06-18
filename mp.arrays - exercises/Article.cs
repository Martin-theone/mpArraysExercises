using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    // Define the Article class
    class Article
    {
        // Properties for the article's title, content, and author
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        // Constructor to initialize the article
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        // Method to edit the content of the article
        public void Edit(string newContent)
        {
            Content = newContent;
        }

        // Method to change the author of the article
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        // Method to rename the title of the article
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        // Override ToString to print the article in the desired format
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    // Main class to run the program
        // Run method to execute the logic
        public static void Run()
        {
            // Read the initial article input (title, content, author)
            string[] articleInput = Console.ReadLine().Split(", ");
            string title = articleInput[0];
            string content = articleInput[1];
            string author = articleInput[2];

            // Create a new article object
            Article article = new Article(title, content, author);

            // Read the number of commands
            int n = int.Parse(Console.ReadLine());

            // Execute each command
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                if (command.StartsWith("Edit: "))
                {
                    string newContent = command.Substring(6); // Remove "Edit: " from the start
                    article.Edit(newContent);
                }
                else if (command.StartsWith("ChangeAuthor: "))
                {
                    string newAuthor = command.Substring(14); // Remove "ChangeAuthor: " from the start
                    article.ChangeAuthor(newAuthor);
                }
                else if (command.StartsWith("Rename: "))
                {
                    string newTitle = command.Substring(8); // Remove "Rename: " from the start
                    article.Rename(newTitle);
                }
            }

            // Output the final article details
            Console.WriteLine(article);
        }
    }
}