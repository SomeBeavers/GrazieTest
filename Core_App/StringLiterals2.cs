//     Copyright (C) 2014-2019 de4dot@gmail.com
//     This file is part of dnSpy
//     dnSpy is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//     You should received a copy of the GNU General Public License
//     along with dnSpy.  If not see <http://www.gnu.org/licenses/>.

using NLog;

namespace Core_App;
//this is different then that.
[My(nameof(StringLiterals2), "StringLiterals2")]
public class StringLiterals2
{

    public StringLiterals2()
    {
        //this is different then that.
        string concatenation = "This is different " +
                               "then that. Bit " +
                               "strange.";

        string s = @"    select b.Id, b.Fluffiness, b.Size, ac.ClubId as ClubId from Beavers b
                              inner join AnimalClub ac on b.Id = ac.AnimalId
                              Union all
                              select cr.Id, 2, 1, ac.ClubId as ClubId  from Crows cr
                              inner join AnimalClub ac on cr.Id = ac.AnimalId
                    ";
    }
}

public class MyAttribute : Attribute
{
    public MyAttribute(string name, string stringliterals2)
    {
        Console.WriteLine("Name = {0}; string = {1}. Write for debugging purposes. Id name is different from oldName = {1} then string should be rewritten.", name, stringliterals2);
    }
}