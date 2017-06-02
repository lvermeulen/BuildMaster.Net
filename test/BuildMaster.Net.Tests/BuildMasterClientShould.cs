namespace BuildMaster.Net.Tests
{
    public partial class BuildMasterClientShould
    {
        private readonly BuildMasterClient _client;

        public BuildMasterClientShould()
        {
            _client = new BuildMasterClient("", "");
        }
    }
}
