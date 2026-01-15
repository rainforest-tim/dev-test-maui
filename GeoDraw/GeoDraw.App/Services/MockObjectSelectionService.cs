using System.Security.Cryptography;

namespace GeoDraw.App.Services;

public class MockObjectSelectionService : IObjectSelectionService
{
    public static string[] _objects = [ "snowman", "fish", "car", "star", "dog", "frog" ];

    public string? ChosenThing { get; set; } = "hat";

    public void ChooseThing()
    {
        var r = RandomNumberGenerator.GetInt32(0, _objects.Length);
        for (int i = 0; i < _objects.Length; i++)
        {
            if (i == r)
            {
                ChosenThing = _objects[i];
            }
        }
    }

    public async Task<string> GetThing()
    {
        //Simulate async call
        await Task.Delay(5000);

        try
        {
            return ChosenThing switch
            {
                "snowman" => "Snowman",
                "fish" => "Fish",
                "car" => "Car",
                "start" => "Star",
                "dog" => "Dog",
                "frog" => "Frog"
            };
        }
        catch
        {
            return ChosenThing;
        }
    }
}
