// Copyright 2020 Greg Eakin
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at:
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// From the Mathologer video: The hardest "What comes next?" (Euler's pentagonal formula)
// https://www.youtube.com/watch?v=iJ8pnCO0nTY

using System.Collections.Generic;
using Xunit;

namespace WhatComesNext
{
    public class FactorTests
    {
        [Fact]
        public void Factor12()
        {
            var next = new WhatsNext();
            var buffer = next.Primes(12);
            Assert.Equal(new List<decimal> {2m, 3m, 5m, 7m, 11m, 13m}, buffer);
        }

        [Fact]
        public void Factor100()
        {
            var next = new WhatsNext();
            var buffer = next.Primes(100);
            Assert.Equal(
                new List<decimal>
                {
                    2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101
                }, buffer);
        }
    }
}