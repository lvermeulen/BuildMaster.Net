// ReSharper disable InconsistentNaming

namespace BuildMaster.Net.Native.Models
{
    public class BuildTestResultsTestGroupResults
    {
        public int Execution_Id { get; set; }
        public string Group_Name { get; set; }
        public int Build_Id { get; set; }
        public int? Total_Tests { get; set; }
        public int? Passed_Tests { get; set; }
        public int? Failed_Tests { get; set; }
        public int? Inconclusive_Tests { get; set; }
    }
}
