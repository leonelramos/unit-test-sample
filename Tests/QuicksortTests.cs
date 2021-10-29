using System;
using System.Collections.Generic;
using Xunit;
using static Algorithms.Algorithms;

namespace Tests
{
    public class QuicksortTests
    {
        [Fact]
        public void Quicksort_WithUnsortedIntArray_ReturnsSortedArray()
        {
            var unsortedValues = new int[] {0,3,1,7,4};
            var expectedSortedValues = new int[] {0,1,3,4,7};

            var actualSortedValues = Quicksort<int>(new List<int>(unsortedValues));

            Assert.Equal(expectedSortedValues, actualSortedValues);
        }

        [Fact]
        public void Quicksort_WithUnsortedIntList_ReturnsSortedIntArray()
        {
            var unsortedValues = new List<int>(new int[] {0,3,1,7,4});
            var expectedSortedValues = new int[] {0,1,3,4,7};

            var actualSortedValues = Quicksort<int>(unsortedValues);

            Assert.Equal(expectedSortedValues, actualSortedValues);
        }

        [Fact]
        public void Quicksort_WithSingleIntArray_ReturnsSingleIntArray()
        {
            var unsortedValues = new int[]{1};
            var expectedSortedValues = new int[] {1};

            var actualSortedValues = Quicksort<int>(unsortedValues);

            Assert.Equal(expectedSortedValues, actualSortedValues);
        }

        [Fact]
        public void Quicksort_WithUnsortedTwoIntArray_ReturnsSortedTwoIntArray()
        {
            var unsortedValues = new int[]{1,0};
            var expectedSortedValues = new int[] {0,1};

            var actualSortedValues = Quicksort<int>(unsortedValues);

            Assert.Equal(expectedSortedValues, actualSortedValues);
        }

        [Fact]
        public void Quicksort_WithSortedTwoIntArray_ReturnsSortedTwoIntArray()
        {
            var unsortedValues = new int[]{0, 1};
            var expectedSortedValues = new int[] {0,1};

            var actualSortedValues = Quicksort<int>(unsortedValues);

            Assert.Equal(expectedSortedValues, actualSortedValues);
        }

        [Fact]
        public void Quicksort_WithSortedIntArray_ReturnsSortedIntArray()
        {
            var sortedValues = new int[]{0,1,2,3,4,5,6};
            var expectedSortedValues = new int[] {0,1,2,3,4,5,6};

            var actualSortedValues = Quicksort<int>(sortedValues);

            Assert.Equal(expectedSortedValues, actualSortedValues);
        }

        [Fact]
        public void Quicksort_WithReverseSortedIntArray_ReturnsSortedIntArray()
        {
            var unsortedValues = new int[]{6,5,4,3,2,1,0};
            var expectedSortedValues = new int[] {0,1,2,3,4,5,6};

            var actualSortedValues = Quicksort<int>(unsortedValues);

            Assert.Equal(expectedSortedValues, actualSortedValues);
        }

        [Fact]
        public void Quicksort_WithEmptyArray_ReturnsEmptyArray()
        {
            var unsortedValues = new int[]{};
            var expectedSortedValues = new int[] {};

            var actualSortedValues = Quicksort<int>(unsortedValues);

            Assert.Equal(expectedSortedValues, actualSortedValues);
        }

        [Fact]
        public void Quicksort_WithUnsortedStrings_ReturnsSortedStrings()
        {
            var unsortedValues = new string[] {"0","3","1","7","4"};
            var expectedSortedValues = new string[] {"0","1","3","4","7"};

            var actualSortedValues = Quicksort<string>(unsortedValues);

            Assert.Equal(expectedSortedValues, actualSortedValues);
        }
    }
}
