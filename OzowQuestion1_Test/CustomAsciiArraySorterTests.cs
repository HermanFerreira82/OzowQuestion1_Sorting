using System;
using Xunit;
using FluentAssertions;
using OzowQuestion1_Sorting;

namespace OzowQuestion1_Test
{
    /// <summary>
    /// CustomAsciiArraySorter Tests using the Arrange, Act and Assert (AAA) Pattern with FluentAssertions
    /// </summary>
    public class CustomAsciiArraySorterTests
    {
        /// <summary>
        /// The baseline test as part of the question: CustomAsciiArraySorter
        /// "Contrary to popular belief, the pink unicorn flies east" to "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy"
        /// </summary>
        [Fact]
        public void DictionaryCustomSorter_BaseLine_Success()
        {
            var sorter = new CustomAsciiArraySorter();
            var result = sorter.Sort("Contrary to popular belief, the pink unicorn flies east");
            result.Should().Be("aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy");
        }

        /// <summary>
        /// Empty: CustomAsciiArraySorter
        /// Empty Input, Empty Output
        /// </summary>
        [Fact]
        public void DictionaryCustomSorter_Empty_Success()
        {
            var sorter = new CustomAsciiArraySorter();
            var result = sorter.Sort(String.Empty);
            result.Should().Be(String.Empty);
        }

        /// <summary>
        /// Empty: CustomAsciiArraySorter
        /// Empty Input, Empty Output
        /// </summary>
        [Fact]
        public void DictionaryCustomSorter_SpecialChar_Success()
        {
            var sorter = new CustomAsciiArraySorter();
            var result = sorter.Sort("~!@#$%^&*()_+{}[]:;'\",./<>?`/*-+");
            result.Should().Be(String.Empty);
        }
    }
}
