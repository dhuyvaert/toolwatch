using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolWatchLogger;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolWatchLogger.Tests
{
    [TestClass()]
    public class LoggerLogToFileTests
    {
        private IToolLogger logger = new LoggerLogToFile();
        [TestMethod()]
        public void LogInformationTest()
        {
            var result = logger.LogInformation("UNIT TEST");
            Assert.AreEqual(true, result.Result);
        }

        [TestMethod()]
        public void LogWarning()
        {
            var result = logger.LogWarning("UNIT TEST");
            Assert.AreEqual(true, result.Result);
        }

        [TestMethod()]
        public void LogError()
        {
            var exception = new Exception("UNIT TEST THROWN EXCEPTION", new NullReferenceException());
            var result = logger.LogError(exception, "UNIT TEST");
            Assert.AreEqual(true, result.Result);
        }

        [TestMethod()]
        public void LogGeneric()
        {
            var result = logger.Log(LogLevel.Critical, "UNIT TEST");
            Assert.AreEqual(true, result.Result);
        }
    }
}