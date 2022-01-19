using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            //dbMigrator.Migrate();

            //var dbMigrator = new DbMigrator(new FileLogger("c:\\Users\\sing13242\\OneDrive - Hatch Ltd\\Documents\\Log.txt"));
            //dbMigrator.Migrate();

            var encoder = new VideoEncoder();
            encoder.RegisteredNotificationChannel(new MailNotificationChannel());
            encoder.RegisteredNotificationChannel(new SmsNotificationChannel());

            encoder.Encode();
        }
    }
}
