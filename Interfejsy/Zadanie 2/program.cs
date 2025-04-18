using System;
using System.Collections.Generic;

public interface IMedia
{
    void Play();
    void Stop();
}

public class Audio : IMedia
{
    public void Play()
    {
        Console.WriteLine("Odtwarzanie pliku audio");
    }

    public void Stop()
    {
        Console.WriteLine("Zatrzymanie odtwarzania audio");
    }
}

public class Video : IMedia
{
    public void Play()
    {
        Console.WriteLine("Odtwarzanie pliku wideo");
    }

    public void Stop()
    {
        Console.WriteLine("Zatrzymanie odtwarzania wideo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IMedia> mediaList = new List<IMedia>
        {
            new Audio(),
            new Video(),
            new Audio(),
            new Video()
        };

        foreach (var media in mediaList)
        {
            media.Play();
            media.Stop();
            Console.WriteLine();
        }
    }
}