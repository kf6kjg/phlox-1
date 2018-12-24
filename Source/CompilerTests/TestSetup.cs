﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CompilerTests
{
    [SetUpFixture]
    class TestSetup
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            System.IO.Directory.SetCurrentDirectory(TestContext.CurrentContext.TestDirectory);
        }
    }
}
