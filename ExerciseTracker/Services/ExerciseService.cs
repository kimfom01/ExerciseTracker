using ExerciseTracker.Models;
using ExerciseTracker.Repositories;

namespace ExerciseTracker.Services;

public class ExerciseService : IExerciseService
{
    private readonly IExerciseRepository _exerciseRepository;

    public ExerciseService(IExerciseRepository exerciseRepository)
    {
        _exerciseRepository = exerciseRepository;
    }

    public List<Exercise> GetAllExercises()
    {
        return _exerciseRepository.GetExercises().ToList();
    }

    public Exercise GetExerciseById(int id)
    {
        return _exerciseRepository.GetExerciseById(id);
    }

    public void RecordNewExercise(Exercise exercise)
    {
        _exerciseRepository.AddExercise(exercise);
        _exerciseRepository.SaveChanges();
    }

    public void UpdateExistingExercise(int id, Exercise exercise)
    {
        _exerciseRepository.UpdateExercise(id, exercise);
        _exerciseRepository.SaveChanges();
    }

    public void DeleteExercise(int id)
    {
        _exerciseRepository.DeleteExercise(id);
        _exerciseRepository.SaveChanges();
    }
}