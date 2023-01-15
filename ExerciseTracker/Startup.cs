using ExerciseTracker.Controller;

namespace ExerciseTracker;

public class Startup
{
    private readonly IExerciseController _exerciseController;

    public Startup(IExerciseController exerciseController)
    {
        _exerciseController = exerciseController;
    }
    public void Run()
    {
        _exerciseController.Run();
    }
}