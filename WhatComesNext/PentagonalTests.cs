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

using Xunit;

namespace WhatComesNext
{
    public class PentagonalTests
    {
        [Fact]
        public void Test0()
        {
            var next = new WhatsNext();
            var buffer = next.PartitionNumbers(0);
            Assert.Equal(1m, buffer);
        }

        [Fact]
        public void Test1()
        {
            var next = new WhatsNext();
            var buffer = next.PartitionNumbers(1);
            Assert.Equal(1m, buffer);
        }

        [Fact]
        public void Test2()
        {
            var next = new WhatsNext();
            var buffer = next.PartitionNumbers(2);
            Assert.Equal(2m, buffer);
        }

        [Fact]
        public void Test3()
        {
            var next = new WhatsNext();
            var buffer = next.PartitionNumbers(3);
            Assert.Equal(3m, buffer);
        }

        [Fact]
        public void Test4()
        {
            var next = new WhatsNext();
            var buffer = next.PartitionNumbers(4);
            Assert.Equal(5m, buffer);
        }

        [Fact]
        public void Test13()
        {
            var next = new WhatsNext();
            var buffer = next.PartitionNumbers(13);
            Assert.Equal(101m, buffer);
        }

        [Fact]
        public void Test666()
        {
            var next = new WhatsNext();
            var buffer = next.PartitionNumbers(666);
            Assert.Equal(11956824258286445517629485m, buffer);
        }
    }
}