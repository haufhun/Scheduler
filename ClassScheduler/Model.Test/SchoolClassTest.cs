﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Test
{

    [TestClass]
    public class SchoolClassTest
    {
        private const string t = "Dr. Gruenbacher";

        [TestMethod]
        public void SchoolClassEmptyConstructorContainsObjectIsNotNull()
        {
            var c = new SchoolClass();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void SchoolClassConstructedWithTeacherContainsTeacher()
        {
            var c = new SchoolClass(t);
            Assert.AreEqual(t,c.Teacher);
        }

        [TestMethod]
        public void SchoolClassContainsOneClassTime()
        {
            const string ct = "MWF 11:30 12:20";
            var c = new SchoolClass(t, ct);

            Assert.AreEqual(ct, c.ClassTime);
        }

        [TestMethod]
        public void SchoolClassContainsTwoClassTimes()
        {
            string[] ct2 = {"MWF 11:30 12:20", "TU 11:30 12:20"};


        }
    }
}
