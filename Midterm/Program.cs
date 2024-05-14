using System;

class ElizaResponse
{
    static void Main(string[] args)
    {
        string userInput;
        Console.WriteLine("Welcome to Eliza. Type 'quit' to exit.");
        Console.WriteLine("What's your name?");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, " + userName + " tell me what troubles you");

        do
        {
            Console.Write("You: ");
            userInput = Console.ReadLine();

            string elizaResponse = CreateElizaResponse(userInput);
            Console.WriteLine("Eliza: " + elizaResponse);

        } while (userInput.ToLower() != "quit");
    }

    static string CreateElizaResponse(string userStatement)
    {
        if (userStatement.ToLower().Contains("my"))
        {
            int myIndex = userStatement.ToLower().IndexOf("my");
            string restOfStatement = userStatement.Substring(myIndex + 3);
            string[] words = restOfStatement.Split(' ');

            if (words.Length > 0)
            {
                string noun = words[0].TrimEnd('.', '!', '?'); // Get the noun after "my"
                return $"Tell me more about your {noun}.";
            }
        }

        if (userStatement.ToLower().Contains("love") || userStatement.ToLower().Contains("hate"))
        {
            return "You have strong feelings about that!";
        }

        
        string[] defaultResponses = { "Please go on.", "Tell me more.", "Continue.", "Interesting. Could you elaborate?", "That's quite intirguing, Tell me some more.", "Would you like to discuss that?"};
        Random rand = new Random();
        int randomIndex = rand.Next(defaultResponses.Length);

        return defaultResponses[randomIndex];
    }
}