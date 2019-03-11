﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegEx
{
    [TestFixture]
    class RegExTesting
    {
        [Test]
        public void CheckEmail_Gmail()
        {
            Assert.AreEqual("sally", CheckEmail("sally", "sally@gmail.com"));
        }

        private string CheckEmail(string name, string email)
        {
            var regex = new Regex("(gmail)");

            Match result = regex.Match(email);
            if (result.Success)
            {
                return name;
            }
            else
                return "no";

        }
    }
}