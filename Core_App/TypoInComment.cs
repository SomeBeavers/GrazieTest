//     Copyright (C) 2014-2019 de4dot@gmail.com
//     This file is part of dnSpy
//     dnSpy is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//     You should received a copy of the GNU General Public License
//     along with dnSpy.  If not see <http://www.gnu.org/licenses/>.

using System.ComponentModel;

/*
     * Licensed to the Apache Software Foundation (ASF) under one or more
     * contributor license agreements.  See the NOTICE file distributed with
     * this work for additional information regarding copyright ownership.
     * The ASF licenses this file to You under the Apache License, Version 2.0
     * (the "License"); you may not use this file except in compliance with
     * the License.  You may obtain a copy of the License at
     *
     *     http://www.apache.org/licenses/LICENSE-2.0
     *
     * Unless required by applicable law or agreed to in writing, software
     * distributed under the License is distributed on an "AS IS" BASIS,
     * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
     * See the License for the specific language governing permissions and
     * limitations under the License.
     */


namespace Core_App;

/// <summary>
/// A simple class that stores <see cref="string"/>s as <see cref="T:char[]"/>'s in a
/// hash table.  Note that these
/// is not a general purpose
/// class.  For example, it cannot remove items from the
/// set, nor does it resize its hash table to be smaller,
/// etc.  It is designed to be quick to test if a <see cref="T:char[]"/>
/// is in the set without the necessity of converting it
/// to a <see cref="string"/> first.
/// 
/// <a name="version"></a>
/// <para>You must specify the required <see cref="LuceneVersion"/>
/// compatibility when creating <see cref="CharArraySet"/>:
/// <ul>
///   <li> As of 3.1, supplementary characters are
///       properly lowercased.</li>
/// </ul>
/// Before 3.1 supplementary characters could not be
/// lowercased correctly due to the lack of Unicode 4
/// support in JDK 1.4. To use instances of
/// <see cref="CharArraySet"/> with the behavior before Lucene
/// 3.1 pass a <see cref="LuceneVersion"/> to the constructors.
/// </para>
/// <para>
/// <em>Please note:</em> This class implements <see cref="ISet{T}"/> but
/// does not behave like it should in all cases. The generic type is
/// <see cref="string"/>, because you can add any object to it,
/// that has a string representation (which is converted to a string). The add methods will use
/// <see cref="object.ToString()"/> and store the result using a <see cref="T:char[]"/>
/// buffer. The same behavior have the <see cref="Contains(string)"/> methods. 
/// The <see cref="GetEnumerator()"/> returns an <see cref="T:IEnumerator{char[]}"/>
/// </para>
/// </summary>
/// <code>
///public void TestMethod()
/// {
///
/// var s = "I'm bit weak today";
/// }
/// </code>
public class TypoInComment
{
    /// <summary>
    /// v "I'm bit weak today";
    /// </summary>
    public void Test()
    {
        // I'm bit
        // weak today.
        /* That is called
        called: "Too much work"*/
    }

    /// <summary>
    ///     which are called
    /// called
    /// </summary>
    public void Test2()
    {
        // These method
        // are not used
        // anywhere in
        // the code. aftr

        // These method is not used anywhere in the code.

        // Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`, then press Enter. You can now see whitespace characters in your code.
    }

    // TODO: rewrite the following method to implement IEnumerable so it can be used in a foreach loop.
    // These function depend on another function so they should called aftr it.
    public void Test3()
    {
        /*
    Generate following code example in
        the
        editor:
    mov eax,[esp+4]
    test eax,eax
    jz jmp_orig_func
    cmp dword ptr [esp+8],0
    je jmp_orig_func
    cmp eax,-1
    je fix
    push eax
    call GetProcessId
    cmp eax,pid
    jne jmp_orig_func
fix:
    mov eax,[esp+8]
    and dword ptr [eax],0
    mov eax,1
    ret 8
jmp_orig_func:
    jmp orig_func
*/
        LocalFunction(1);

        // These function depend on another function, so they should call after it.
        void LocalFunction(int i)
        {
            int myBestPossibleIdentifirWithTypoImBitWeakToday = 1;
            Console.WriteLine(myBestPossibleIdentifirWithTypoImBitWeakToday);
        }
    }
    //  To learn more about this method which called after. I'm bit weak today.

    /// <summary>
    ///     See <see cref="Test3" /> to learn more about this method which becalled after <see cref="Test3" />.
    /// </summary>
    /// <param name="random">
    ///     Get random numbers using <see cref="Test3" /> to detect
    ///     who will
    ///     won the lottery
    /// </param>
    /// <see cref="Test3" />
    public void Test4(int random)
    {
        /* Methods which have the [DebuggerHidden] attribute */
        /* Before protocol version 2.26, this includes [DebuggerStepThrough] as well */
    }

    /// <summary>
    /// Этот класс который здесь создается
    /// показывает нам что делать с
    /// <see cref="Test3"/> и <see cref="Test4"/>, И это хорошо.
    /// </summary>
    public class Test1
    {
        //Этот клас который здесь создается показывает нам что делать,    слушай меня.Сейчас это доступно здесь. Но опечатка в коменте тоже сдесь.
        // Не следует пытаться не делать это, потому что это не будет работать. Не для этого оно.
        public static void Info([Localizable(true)] string message) { }
        public static void Debug([Localizable(false)] string message) { }

        public static void TestMethod()
        {
            /*Get random numbers to detect who will won the lottery.*/
            int winLotery = new Random(1).Next(10);
            var s = ""; int t = 1;
        }
    }
}