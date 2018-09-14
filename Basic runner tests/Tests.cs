using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
            var interpreter = new Interpreter();
            Assert.True(interpreter.Runner("sh hi").Equals("hi"));
        }

        [Test]
        public void IntPrintTest()
        {
            var interpreter = new Interpreter();
            interpreter.Runner("dc tst 32");
            Assert.True((interpreter.Runner("pt tst").Equals("32")));
        }

        [Test]
        public void StringPrintTest()
        {
            var interpreter = new Interpreter();
            interpreter.Runner("dc txt hello");
            Assert.True((interpreter.Runner("pt txt").Equals("hello")));
        }

        [Test]
        public void AddPrintTest()
        {
            var interpreter = new Interpreter();
            interpreter.Runner("dc add 32");
            interpreter.Runner("dc ad 20");
            interpreter.Runner("ad add ad");
            
            interpreter. Runner("dc sub 32");
            interpreter.Runner("dc sb 20");
            interpreter.Runner("sb sub sb");
         
            interpreter.Runner("dc div 20");
            interpreter.Runner("dc dv 2");
            interpreter.Runner("dv div dv");
            
            interpreter.Runner("dc mul 32");
            interpreter.Runner("dc ml 20");
            interpreter.Runner("ml mul ml");
            
            Assert.True((interpreter.Runner("pt add").Equals("52"))&&
            (interpreter.Runner("pt sub").Equals("12"))&&
            (interpreter.Runner("pt div").Equals("10"))&&
            (interpreter.Runner("pt mul").Equals("640")));
        }
        [Test]
        public void MovePrintTest()
        {
           
            var interpreter = new Interpreter();
            interpreter.Runner("dc mvr 32");
            interpreter.Runner("mv mvr mr");
            interpreter.Runner("pt mr");
            interpreter.Runner("dc mvt tst");
            interpreter.Runner("mv mvt mt");
            Assert.True((interpreter.Runner("pt mr").Equals("32"))&&(interpreter.Runner("pt mt").Equals("tst")));
        }
    }
}