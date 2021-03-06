﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NetTopologySuite.IO.ShapeFile.Test
{
    class Issue174
    {
        [Test, Category("Issue174")]
        public void ensure_NetTopologySuite_IO_ShapeFile_assembly_is_strongly_named()
        {
            AssertStronglyNamedAssembly(typeof(ShapeReader));
        }

        [Test, Category("Issue174")]
        public void ensure_NetTopologySuite_IO_GDB_assembly_is_strongly_named()
        {
            AssertStronglyNamedAssembly(typeof(GDBReader));
        }

        [Test, Category("Issue174")]
        public void ensure_NetTopologySuite_IO_GeoTools_assembly_is_strongly_named()
        {
            AssertStronglyNamedAssembly(typeof(ShapefileDataReader));
        }

        private void AssertStronglyNamedAssembly(Type typeFromAssemblyToCheck)
        {
            Assert.IsNotNull(typeFromAssemblyToCheck, "Cannot determine assembly from null");
            var assembly = typeFromAssemblyToCheck.Assembly;
            StringAssert.DoesNotContain("PublicKeyToken=null", assembly.FullName, "Strongly named assembly should have a PublicKeyToken in fully qualified name");
        }
    }
}
