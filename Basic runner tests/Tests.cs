using System;
using System.Data;
using NUnit.Framework;
using ASMBLR;
namespace Basic_runner_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ShowTest()
        {
            Assert.True(true);
            var interpreter = new Interpreter();
            interpreter.Runner("sh hi");
        }

        [Test]
        public void IntPrintTest()
        {
            Assert.True(true);
            var interpreter = new Interpreter();
            interpreter.Runner("dc tst 32");
            interpreter.Runner("pt tst");
        }
        [Test]
        public void StringPrintTest()
        {
            Assert.True(true);
            var interpreter = new Interpreter();
            interpreter.Runner("dc txt hello");
            interpreter.Runner("pt txt");
        }
        [Test]
        public void AddPrintTest()
        {
            Assert.True(true);
            var interpreter = new Interpreter();
            interpreter.Runner("dc add 32");
            interpreter.Runner("dc ad 20");
            interpreter.Runner("ad add ad");
            interpreter.Runner("pt add");
        }
        [Test]
        public void MovePrintTest()
        {
            Assert.True(true);
            var interpreter = new Interpreter();
            interpreter.Runner("dc mvr 32");
            interpreter.Runner("mv mvr mr");
            interpreter.Runner("pt mr");
            interpreter.Runner("dc mvt tst");
            interpreter.Runner("mv mvt mt");
            interpreter.Runner("pt mt");
        }
    }
}