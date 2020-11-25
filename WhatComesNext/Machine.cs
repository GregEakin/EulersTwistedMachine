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
                var next = 0m;
                for (var j = 0; j <= i; j++)
                {
                    var doAdj = adjustments.TryGetValue(i - j, out var doAdd);
                    if (!doAdj) continue;
                    next += doAdd ? counts[j] : -counts[j];
                }

                counts[i + 1] = next;
                counts[0]++;

                if (next == i + 2m)
                    yield return next - 1m;

                var found = NextAdjustment(adjustments.Count);
                if (i < found - 1) continue;
                adjustments.Add(i + 1, adjustments.Count % 4 < 2);
            }
        }

        public decimal PartitionNumbers(int count)
        {
            var counts = new decimal[count + 2];
            counts[0] = 1m;
            var adjustments = new Dictionary<int, bool> {{0, true}};
            for (var i = 0; i <= count; i++)
            {
                var next = 0m;
                for (var j = 0; j <= i; j++)
                {
                    var doAdj = adjustments.TryGetValue(i - j, out var doAdd);
                    if (!doAdj) continue;
                    next += doAdd ? counts[j] : -counts[j];
                }

                counts[i + 1] = next;

                var found = NextAdjustment(adjustments.Count);
                if (i < found - 1) continue;
                adjustments.Add(found, adjustments.Count % 4 < 2);
            }

            return counts[count];
        }
    }
}