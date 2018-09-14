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
        public void OpsPrintTest()
        {
            Assert.True(true);
            var interpreter = new Interpreter();
            interpreter.Runner("dc add 32");
            interpreter.Runner("dc ad 20");
            interpreter.Runner("ad add ad");
            interpreter.Runner("pt add");
           
            interpreter.Runner("dc sub 32");
            interpreter.Runner("dc sb 20");
            interpreter.Runner("sb sub sb");
            interpreter.Runner("pt sub");
            
            interpreter.Runner("dc div 20");
            interpreter.Runner("dc dv 2");
            interpreter.Runner("dv div dv");
            interpreter.Runner("pt div");
            
            interpreter.Runner("dc mul 32");
            interpreter.Runner("dc ml 20");
            interpreter.Runner("ml mul ml");
            interpreter.Runner("pt mul");
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