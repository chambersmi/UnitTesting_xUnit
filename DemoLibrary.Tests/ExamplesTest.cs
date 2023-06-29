﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using System.IO;

namespace DemoLibrary.Tests
{
    public class ExamplesTest
    {
        [Fact]
        public void ExampleLoadTestFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid file name");
            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExampleLoadTestFile_InvalidNameShouldFail()
        {
            Assert.Throws<ArgumentException>("file",() => Examples.ExampleLoadTextFile(""));
        }

    }
}
