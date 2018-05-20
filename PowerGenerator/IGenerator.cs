namespace PowerGenerator
{
    internal interface IGenerator
    {
        int Capacity { get; set; }
        string Name { get; set; }
        int Id { get; set; }
    }
}