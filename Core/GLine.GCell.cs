﻿// Copyright 2004-2018 The Poderosa Project.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Poderosa.Document.Internal {

    /// <summary>
    /// Cell of <see cref="GLine"/>.
    /// </summary>
    internal struct GCell {
        public GChar Char;
        public GAttr Attr;

        public GCell(GChar ch, GAttr attr) {
            Char = ch;
            Attr = attr;
        }

        public void Set(GChar ch, GAttr attr) {
            // this method can assign members faster comparing to the following methods.
            // 1:
            //   array[i].Char = ch;
            //   array[i].Attr = attr;  // need realoding of the address of array[i]
            // 2:
            //   array[i] = new GCell(ch, attr); // need copying temporary 8 bytes.

            Char = ch;
            Attr = attr;
        }

        public void SetNul() {
            Char = GChar.ASCII_NUL;
            Attr -= GAttrFlags.UseCjkFont;
        }
    }

}
