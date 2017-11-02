using LanguageExt;
using System;
using System.Threading.Tasks;
using static LanguageExt.Prelude;

namespace LangExtOptBiIterAsync
{
    public class Program
    {
        public static void Main(string[] _)
        {
            Console.WriteLine("Press key to start");
            Console.ReadKey();

            RunIssue().Wait();

            Console.WriteLine("Press key to terminate");
            Console.ReadKey();
        }

        static Task RunIssue()
        {
            return ValidateAsync();
        }

        static Task<Unit> ValidateAsync()
        {
            Task<Option<string>> textOptTask = Task.Run(() => (Option<string>)None);

            Task<Unit> doActionTask = textOptTask.BiIterAsync(
                None: () =>
                    Console.WriteLine("Do Action None"),
                Some: text =>
                    Console.WriteLine($"Do Action Some: '{text ?? "<null>"}'"));

            return doActionTask;
        }
    }
}
