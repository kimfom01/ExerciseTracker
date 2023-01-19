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

    public List<Exercise> GetAllExercises()
    {
        return _exerciseRepository.GetExercises().ToList();
    }

    public Exercise GetExerciseById()
    {
        var id = _input.GetId();

        return _exerciseRepository.GetExerciseById(id);
    }

    public void RecordNewExercise()
    {
        var startDate = DateTime.Now;
        var exercise = new Exercise { StartDate = startDate };

        _exerciseRepository.AddExercise(exercise);
        _exerciseRepository.SaveChanges();
    }

    public void UpdateExistingExercise()
    {
        var id = _input.GetId();
        var endDate = DateTime.Now;
        var comments = _input.GetComments();

        var exercise = new Exercise { EndDate = endDate, Comments = comments };

        _exerciseRepository.UpdateExercise(id, exercise);
        _exerciseRepository.SaveChanges();
    }

    public void DeleteExercise()
    {
        var id = _input.GetId();
        _exerciseRepository.DeleteExercise(id);
        _exerciseRepository.SaveChanges();
    }
}