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
// From the Mathologer video: The hardest "What comes machine?" (Euler's pentagonal formula)
// https://www.youtube.com/watch?v=iJ8pnCO0nTY

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace WhatComesNext
{
    public class PrimeTests
    {
        [Fact]
        public void Prime12()
        {
            var machine = new Machine();
            var primes = machine.Primes(12);
            Assert.Equal(new List<decimal> {2m, 3m, 5m, 7m, 11m, 13m}, primes);
        }

        [Fact]
        public void Prime100()
        {
            var machine = new Machine();
            var primes = machine.Primes(100);
            Assert.Equal(new List<decimal>
                {
                    2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101
                }, primes);
        }

        // [Fact]
        // public void Prime100000()
        // {
        //     var machine = new Machine();
        //     var watch = new Stopwatch();
        //     watch.Start();
        //     var primes = machine.Primes(100000);
        //     Assert.Equal(9592, primes.Count());
        //     watch.Stop();
        //     // Assert.Equal(0, watch.ElapsedMilliseconds);
        //     // took 94.984 seconds on my laptop
        // }
    }
}