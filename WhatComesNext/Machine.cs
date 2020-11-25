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

namespace WhatComesNext
{
    public class Machine
    {
        public static int NextAdjustment(int adjustmentsCount)
        {
            var index = (adjustmentsCount - 1) / 2 + 1;
            var found = adjustmentsCount % 2 == 0
                ? adjustmentsCount - index * (3 * -index - 1) / 2
                : (adjustmentsCount + index * (3 * index - 1)) / 2;
            return found;
        }

        public IEnumerable<decimal> Primes(int max)
        {
            var counts = new decimal[max + 2];
            counts[0] = 1m;
            var adjustments = new Dictionary<int, bool> {{0, true}};
            for (var i = 0; i <= max; i++)
            {
                var count = 0m;
                for (var j = 0; j <= i; j++)
                {
                    var doAdj = adjustments.TryGetValue(i - j, out var doAdd);
                    if (!doAdj) continue;
                    count += doAdd ? counts[j] : -counts[j];
                }

                counts[i + 1] = count;
                counts[0]++;

                if (count == i + 2m)
                    yield return count - 1m;

                var next = NextAdjustment(adjustments.Count);
                if (i < next - 1) continue;
                adjustments.Add(next, adjustments.Count % 4 < 2);
            }
        }

        public decimal PartitionNumbers(int index)
        {
            var counts = new decimal[index + 2];
            counts[0] = 1m;
            var adjustments = new Dictionary<int, bool> {{0, true}};
            for (var i = 0; i <= index; i++)
            {
                var count = 0m;
                for (var j = 0; j <= i; j++)
                {
                    var doAdj = adjustments.TryGetValue(i - j, out var doAdd);
                    if (!doAdj) continue;
                    count += doAdd ? counts[j] : -counts[j];
                }

                counts[i + 1] = count;

                var next = NextAdjustment(adjustments.Count);
                if (i < next - 1) continue;
                adjustments.Add(next, adjustments.Count % 4 < 2);
            }

            return counts[index];
        }
    }
}