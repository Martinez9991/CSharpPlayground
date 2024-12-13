using System.Threading;
namespace ThreadingE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! 1");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 2");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 3");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 4");

            //new Thread(()=>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 1");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 2");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 3");
            //}).Start();


            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4");
            //}).Start();

            //var taskCompletionSource = new TaskCompletionSource<bool>();
            //var thread = new Thread(() => 
            //    {
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //        Thread.Sleep(5000);
            //        taskCompletionSource.TrySetResult(true);
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            //    });
            ////Console.WriteLine($"Thread number: {thread.ManagedThreadId}");
            //thread.Start();
            //var test = taskCompletionSource.Task.Result;
            //Console.WriteLine("Task was done : {0}",test);

            //Enumerable.Range(0, 100).ToList().ForEach(f =>
            //{
            //    new Thread(() =>
            //    {
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            //    }).Start();
            //});

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            })
            { IsBackground = true }.Start();

            Enumerable.Range(0, 100).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                });
            });

            //Console.ReadKey();
        }
    }
}
