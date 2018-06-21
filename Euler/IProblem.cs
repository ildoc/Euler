namespace Euler
{
    public interface IProblem
    {
        string Title { get; }
        string Description { get; }
        string GetSolution();
    }
}
