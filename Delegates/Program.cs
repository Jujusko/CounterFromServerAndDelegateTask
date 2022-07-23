// See https://aka.ms/new-console-template for more information
using Delegates;


AsyncCall test = new();
Task t = test.AsyncCaller(2000);
Task.WaitAll(t);
