namespace OzowQuestion1_Sorting
{
    /// <summary>
    /// My Customer Sorter interface
    /// </summary>
    public interface ICustomSorter
    {
        /// <summary>
        /// Sorts a string
        /// </summary>
        /// <param name="sentence">Unsorted String</param>
        /// <returns>Sorted String</returns>
        string Sort(string sentence);
    }
}
