﻿//     Copyright (C) 2014-2019 de4dot@gmail.com
//     This file is part of dnSpy
//     dnSpy is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//     You should received a copy of the GNU General Public License
//     along with dnSpy.  If not see <http://www.gnu.org/licenses/>.

namespace Core_App;

public class Members
{

}
    record ImutableRecord
    {
        public ImutableRecord()
        {
            // This is different than that.








            // many spaces here



            /*
             *
             *
             *
             * for a purpose
             * of clarity
             * which is bit important
             * now
             * Evene more then ever.
             */

        }
    }

struct MyStructWhichUsedImutableRecord
{
    public ImutableRecord Record { get; set; }
}

interface IImutableInterface
{
    void GetImutableRecord()
    {
        void LoclGetImutableParametr(ImutableRecord immutableRecord)
        {
            var t = immutableRecord;
        }
    }
}