using System;
using Xunit;
using FluentAssertions;
using OzowQuestion1_Sorting;

namespace OzowQuestion1_Test
{
    /// <summary>
    /// DictionaryCustomSorter Tests using the Arrange, Act and Assert (AAA) Pattern with FluentAssertions
    /// </summary>
    public class CustomDictionarySorterTests
    {
        /// <summary>
        /// The baseline test as part of the question: DictionaryCustomSorter
        /// "Contrary to popular belief, the pink unicorn flies east" to "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy"
        /// </summary>
        [Fact]
        public void DictionaryCustomSorter_BaseLine_Success()
        {
            var sorter = new CustomDictionarySorter();
            var result = sorter.Sort("Contrary to popular belief, the pink unicorn flies east");
            result.Should().Be("aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy");
        }

        /// <summary>
        /// Empty: DictionaryCustomSorter
        /// Empty Input, Empty Output
        /// </summary>
        [Fact]
        public void DictionaryCustomSorter_Empty_Success()
        {
            var sorter = new CustomDictionarySorter();
            var result = sorter.Sort(String.Empty);
            result.Should().Be(String.Empty);
        }

        /// <summary>
        /// Empty: DictionaryCustomSorter
        /// Empty Input, Empty Output
        /// </summary>
        [Fact]
        public void DictionaryCustomSorter_SpecialChar_Success()
        {
            var sorter = new CustomDictionarySorter();
            var result = sorter.Sort("~!@#$%^&*()_+{}[]:;'\",./<>?`/*-+");
            result.Should().Be(String.Empty);
        }
    }
}
