using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();
        static public StreamReader sr;

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" + LoginValidation.currentUsername + ";" + LoginValidation.CurrentUserRole + ";"+ activity;
            currentSessionActivities.Add(activityLine);
            LogContext context = new LogContext();
            context.Logs.Add(new Log(activityLine));
            context.SaveChanges();
            if (File.Exists("test.txt"))
            {
                File.AppendAllText("test.txt", activityLine+"\n");
            }
        }
        static public IEnumerable<string> getFullLog()
        {
         
            System.Collections.Generic.IEnumerable<String> line = File.ReadLines("C:\\Users\\g\\source\\repos\\PS_49_Georgi_Paytov\\UserLogin\\bin\\Debug\\test.txt");

            return line;
        }
        static public IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            
            return from activity in currentSessionActivities
                   where activity.Contains(filter)
                   select activity;
        }

    }
}
