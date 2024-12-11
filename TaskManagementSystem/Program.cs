namespace TaskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailTask = new EmailTask()
            {
                Message = "Hello this is a test email",
                Recipient = "test@test.com"
            };
            var reportTask = new ReportTask()
            {
                ReportName = "Annual Report",
            };
            var emailProcessor = new TaskProcessor<EmailTask,string>(emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute());

            Console.ReadKey();
        }
    }
}
