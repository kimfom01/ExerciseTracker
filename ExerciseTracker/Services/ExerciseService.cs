using ExerciseTracker.Models;
using ExerciseTracker.Repositories;
using ExerciseTracker.UserInput;

namespace ExerciseTracker.Services;

public class ExerciseService : IExerciseService
{
    private readonly IExerciseRepository _exerciseRepository;
    private readonly IInput _input;

    public ExerciseService(IExerciseRepository exerciseRepository, IInput input)
    {
        _exerciseRepository = exerciseRepository;
        _input = input;
    }

    public void GetAllExercises()
    {
        var exercises = _exerciseRepository.GetExercises().ToList();
        Console.Clear();
        foreach (var exercise in exercises)
        {
            Console.WriteLine(exercise.Id);
            Console.WriteLine(exercise.StartDate);
            Console.WriteLine(exercise.EndDate);
            Console.WriteLine(exercise.Duration);
            Console.WriteLine(exercise.Comments);
            Console.WriteLine();
        }

        Console.Write("Press Enter to continue");
        Console.ReadLine();
    }

    public void GetExerciseById()
    {
        var id = _input.GetId();

        var exercise = _exerciseRepository.GetExerciseById(id);
        Console.Clear();

        Console.WriteLine(exercise.Id);
        Console.WriteLine(exercise.StartDate);
        Console.WriteLine(exercise.EndDate);
        Console.WriteLine(exercise.Duration);
        Console.WriteLine(exercise.Comments);
        Console.WriteLine();

        Console.Write("Press Enter to continue");
        Console.ReadLine();
    }

    public void RecordNewExercise()
    {
        var startDate = DateTime.Now;
        var exercise = new Exercise { StartDate = startDate };

        _exerciseRepository.AddExercise(exercise);
        _exerciseRepository.SaveChanges();
        Console.Clear();
        
        Console.WriteLine("New exercise recorded");
        
        Console.Write("Press Enter to continue");
        Console.ReadLine();
    }

    public void UpdateExistingExercise()
    {
        var id = _input.GetId();
        var endDate = DateTime.Now;
        var comments = _input.GetComments();

        var exercise = new Exercise { EndDate = endDate, Comments = comments };

        _exerciseRepository.UpdateExercise(id, exercise);
        _exerciseRepository.SaveChanges();
        Console.Clear();
        
        Console.WriteLine("Exercise updated");
        
        Console.Write("Press Enter to continue");
        Console.ReadLine();
    }

    public void DeleteExercise()
    {
        var id = _input.GetId();
        _exerciseRepository.DeleteExercise(id);
        _exerciseRepository.SaveChanges();
        Console.Clear();
        
        Console.WriteLine("Exercise deleted");
        
        Console.Write("Press Enter to continue");
        Console.ReadLine();
    }
}