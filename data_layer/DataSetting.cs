using System.Diagnostics;

namespace data_layer
{
    public class DataSetting
    {
        public static string ConnectionString = "server=.; database=Alshouha_Company; user id=sa; password=sa123456;";

        public static void StoreUsingEventLogs(string message)
        {
            string sourceName = "Transportion_App";

            if (!EventLog.SourceExists(sourceName))
                EventLog.CreateEventSource(sourceName, "Application");

            EventLog.WriteEntry(sourceName, message, EventLogEntryType.Error);
        }
    }
}
