using CounterFromServer;



var tasks = new Task[2];
tasks[0] = Task.Run(() => TaskAddCount());
tasks[1] = Task.Run(() => TaskForGet());

Task.WaitAll(tasks);






async void TaskAddCount()
{
    var tasks = new Task[50];
    for (int i = 0; i < tasks.Length; i++)
    {
        tasks[i] = Task.Run(() => Server.AddToCount(10));
    }
    Task.WaitAll(tasks);
}

async void TaskForGet()
{
    var taskes = new Task[50];
    for (int e = 0; e < taskes.Length; e++)
    {
        taskes[e] = Task.Run(() => Server.GetCount());
    }
    Task.WaitAll(taskes);
}
