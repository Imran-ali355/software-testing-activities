// Implementation of polymorphism using an SQA test scenario.
using System;

namespace OOPPractice
{
    public abstract class TestCase
    {
        protected TestCase(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void Execute();
    }

    public class LoginUiTest : TestCase
    {
        public LoginUiTest() : base("UI login test") { }

        public override void Execute()
        {
            Console.WriteLine($"Running {Name}: enter credentials and verify the dashboard.");
        }
    }

    public class LoginApiTest : TestCase
    {
        public LoginApiTest() : base("API login test") { }

        public override void Execute()
        {
            Console.WriteLine($"Running {Name}: send login request and verify HTTP 200.");
        }
    }

    public static class PolymorphismExample
    {
        public static void Run()
        {
            // The same base type invokes different implementations at runtime.
            TestCase[] tests = { new LoginUiTest(), new LoginApiTest() };

            foreach (TestCase test in tests)
            {
                test.Execute();
            }
        }
    }
}
 