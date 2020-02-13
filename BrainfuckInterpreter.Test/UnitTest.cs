using BrainfuckInterpreter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainfuckInterpreter.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void InterpreterTest1()
        {
            const string input = "+++++++++[>++++++++>+++++++++++>+++>+<<<<-]>.>++.+++++++..+++.>+++++.<<+++++++++++++++.>.+++.------.--------.>+.>+.";
            var output = Interpreter.Run(input);
            Assert.AreEqual(output, "Hello World!");
        }

        [TestMethod]
        public void InterpreterTest2()
        {
            const string input = ">+++++++++[<++++++++>-]<.>+++++++[<++++>-]<+.+++++++..+++.[-]>++++++++[<++++>-]<.>+++++++++++[<+++++>-]<.>++++++++[<+++>-]<.+++.------.--------.[-]>++++++++[<++++>-]<+.[-]++++++++++.";
            var output = Interpreter.Run(input);
            Assert.AreEqual(output, "Hello World!");
        }

        [TestMethod]
        public void InterpreterTest3()
        {
            const string input = ">++++[<++++++++>-]>++++++++[<++++++>-]<++.<.> +.<.> ++.<.> ++.<.> ------..<.>.++.<.> --.++++++.<.> ------.>+++[<+++>-]<-.<.> -------.+.<.> -.+++++++.<.>------.--.<.> ++.++++.<.> ---.---.<.> +++.-.<.> +.+++.<.> --.--.<.> ++.++++.<.>---.-----.<.> +++++.+.<.> .------.<.> ++++++.----.<.> ++++.++.<.> -.-----.<.> +++++.+.<.>";
            var output = Interpreter.Run(input);
            Assert.AreEqual(output, "2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89");
        }
    }
}
