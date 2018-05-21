namespace MySportsFeeds.NetCore.IntegrationTests
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class TestBase
    {
        /// <summary>
        /// The base URL
        /// </summary>
        protected readonly string BASE_URL = "https://api.mysportsfeeds.com/";
        /// <summary>
        /// The username
        /// </summary>
        protected readonly string USERNAME = "ADD YOUR USERNAME HERE";
        /// <summary>
        /// The password
        /// </summary>
        protected readonly string PASSWORD = "ADD YOUR PASSWORD HERE";

        /// <summary>
        /// My sports feeds client
        /// </summary>
        protected MySportsFeedsClient mySportsFeedsClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestBase"/> class.
        /// </summary>
        public TestBase()
        {
            mySportsFeedsClient = new MySportsFeedsClient(BASE_URL, USERNAME, PASSWORD);
        }
    }
}
