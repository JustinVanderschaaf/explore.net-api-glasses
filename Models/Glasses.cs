namespace GlassesApi.Models;
//defining what our data will look like, kinda like setting up db
public class Glasses
{
    public int Id {get; set; }

    public string? Name {get; set;}

    public string? Color {get; set;}

    public string? Shape {get; set;}
}