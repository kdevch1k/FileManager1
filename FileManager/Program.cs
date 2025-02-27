using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        var app = new FileManagerApp();
        app.Run();
    }
}
public class FileManagerApp
{
    private readonly ConsoleUI ui;
    private readonly InputHandler input_;

    public FileManagerApp()
    {
        ui = new ConsoleUI();
        input_ = new InputHandler();
    }
    
    public void Run()
    {
        while (true)
        {
            ui.Draw();
            input_.KeyListen();
        }
    }
}