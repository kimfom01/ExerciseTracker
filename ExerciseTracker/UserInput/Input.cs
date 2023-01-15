using ExerciseTracker.Validations;

namespace ExerciseTracker.UserInput;

public class Input
{
    private readonly InputValidation _inputValidation;

    public Input(InputValidation inputValidation)
    {
        _inputValidation = inputValidation;
    }

    public string GetChoice()
    {
        Console.Write("Enter your choice: ");
        var choice = Console.ReadLine();
        while (!_inputValidation.ValidateInput(choice))
        {
            Console.WriteLine("Error! Invalid input.");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
        }

        return choice;
    }

    public int GetId()
    {
        Console.Write("Enter the id: ");
        int id;
        var input = Console.ReadLine();
        while (!_inputValidation.ValidateIdInput(input, out id))
        {
            Console.WriteLine("Error! Invalid input.");
            Console.Write("Enter the id: ");
            input = Console.ReadLine();
        }

        return id;
    }

    public string GetComments()
    {
        Console.Write("Enter your comments: ");
        var comments = Console.ReadLine();
        while (!_inputValidation.ValidateInput(comments))
        {
            Console.WriteLine("Error! Invalid input.");
            Console.Write("Enter your comments: ");
            comments = Console.ReadLine();
        }

        return comments;
    }
}
