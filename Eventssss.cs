using System;
public delegate void Notify();  // delegate
public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted; // publisher raise the event
    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        OnProcessCompleted();                           //event raise
    }
    protected virtual void OnProcessCompleted()        //protected virtual method
    {
        ProcessCompleted?.Invoke();                     //if ProcessCompleted is not null then call delegate
    }
}
class Program
{
    public static void Main(string[] args)
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += bl_ProcessCompleted;                  // subscriber register with an event
        bl.StartProcess();
    }
    public static void bl_ProcessCompleted()                          // event handler
    {
        Console.WriteLine("Process Completed!");
    }
}