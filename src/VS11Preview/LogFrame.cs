﻿#region Copyright and license information
// Copyright 2012 Jon Skeet
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
#endregion

using System;

namespace Eduasync
{
    public sealed class LogFrame : IDisposable
    {
        private readonly string name;

        public LogFrame(string name)
        {
            this.name = name;
            Console.WriteLine("Entering log frame {0}", name);
        }

        public void Dispose()
        {
            Console.WriteLine("Exiting log frame {0}", name);
        }
    }
}
