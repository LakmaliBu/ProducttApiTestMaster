using Authlete.Util;
using log4net;

namespace AssignmentApiTestMaster.Util
{
    public class PropertyFileReader
    {
        static readonly ILog _logger = LogManager.GetLogger(typeof(PropertyFileReader));
        public static IDictionary<string, string> properties;

        public void Read()
        {
            string file = "config.properties";
            try
            {
                using (TextReader reader = new StreamReader(file))
                {
                    properties = PropertiesLoader.Load(reader);
                   
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);


            }
        }
    }
}
