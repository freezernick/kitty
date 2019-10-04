// Lic:
// High/KittyHighCS.cs
// Kitty
// version: 19.10.04
// Copyright (C)  Jeroen P. Broks
// This software is provided 'as-is', without any express or implied
// warranty.  In no event will the authors be held liable for any damages
// arising from the use of this software.
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it
// freely, subject to the following restrictions:
// 1. The origin of this software must not be misrepresented; you must not
// claim that you wrote the original software. If you use this software
// in a product, an acknowledgment in the product documentation would be
// appreciated but is not required.
// 2. Altered source versions must be plainly marked as such, and must not be
// misrepresented as being the original software.
// 3. This notice may not be removed or altered from any source distribution.
// EndLic
ï»¿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty {
    class KittyHighCS:KittyPL {

        public KittyHighCS() {
            // Not complete yet, but for now this will do!
            KeyWords.Add("using");
            KeyWords.Add("namespace");
            KeyWords.Add("class");
            KeyWords.Add("struct");
            KeyWords.Add("public");
            KeyWords.Add("private");
            KeyWords.Add("protected");
            KeyWords.Add("internal");            
            KeyWords.Add("void");
            KeyWords.Add("string");
            KeyWords.Add("int");
            KeyWords.Add("char");
            KeyWords.Add("bool");
            KeyWords.Add("switch");
            KeyWords.Add("case");
            KeyWords.Add("default");
            KeyWords.Add("goto"); // EEEEW!
            KeyWords.Add("if");
            KeyWords.Add("else");
            KeyWords.Add("do");
            KeyWords.Add("while");
            KeyWords.Add("true");
            KeyWords.Add("false");
            KeyWords.Add("abstract");
            KeyWords.Add("override");
            KeyWords.Add("this");
            KeyWords.Add("get");
            KeyWords.Add("set");
            KeyWords.Add("try");
            KeyWords.Add("catch");
            KeyWords.Add("finally");
            KeyWords.Add("static");
            KeyWords.Add("return");
            KeyWords.Add("for");
            KeyWords.Add("in");
            KeyWords.Add("foreach");
            KeyWords.Add("delegate");
            KeyWords.Add("readonly");
            KeyWords.Add("new");
            KeyWords.Add("break");
            KeyWords.Add("null");

            Langs["cs"] = this;
            Language = "C#";
        }

    }
}

