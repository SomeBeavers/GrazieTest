//     Copyright (C) 2014-2019 de4dot@gmail.com
//     This file is part of dnSpy
//     dnSpy is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//     You should received a copy of the GNU General Public License
//     along with dnSpy.  If not see <http://www.gnu.org/licenses/>.

namespace Framework_Lib
{
    public abstract class IInheritance
    {
        public abstract void IMUTABLE_TEST();
    }

    public class Inheritance : IInheritance
    {
        /// <summary>
        /// In futre this will be different then that.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void IMUTABLE_TEST()
        {
            throw new System.NotImplementedException();
        }
    }

    public class TestClass
    {
        public void this_is_immutable_test()

        {
            throw new System.NotImplementedException();
        }
        protected internal void test()
        {
            throw new System.NotImplementedException();
        }
    }
}