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

using Xunit;

namespace WhatComesNext
{
    public class AdjustmentTests
    {
        [Fact]
        public void Test0()
        {
            var next = Machine.NextAdjustment(0);
            Assert.Equal(2, next);
        }

        [Fact]
        public void Test1()
        {
            var next = Machine.NextAdjustment(1);
            Assert.Equal(1, next);
        }

        [Fact]
        public void Test2()
        {
            var next = Machine.NextAdjustment(2);
            Assert.Equal(4, next);
        }

        [Fact]
        public void Test3()
        {
            var next = Machine.NextAdjustment(3);
            Assert.Equal(6, next);
        }

        [Fact]
        public void Test4()
        {
            var next = Machine.NextAdjustment(4);
            Assert.Equal(11, next);
        }

        [Fact]
        public void Test5()
        {
            var next = Machine.NextAdjustment(5);
            Assert.Equal(14, next);
        }

        [Fact]
        public void Test6()
        {
            var next = Machine.NextAdjustment(6);
            Assert.Equal(21, next);
        }

        [Fact]
        public void Test666()
        {
            var next = Machine.NextAdjustment(666);
            Assert.Equal(167166, next);
        }
    }
}