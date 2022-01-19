using System.Collections;
using System.Collections.Generic;

namespace InterfaceExample
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationList;



        public VideoEncoder()
        {
            _notificationList = new List<INotificationChannel>();
            

        }

        public void Encode(VideoEncoder video) 
        {
            foreach (var notification in _notificationList) 
            {
                notification.Send(new Message());
            }
            
        }

        public void RegisteredNotificationChannel(INotificationChannel channel) 
        {
            _notificationList.Add(channel);
        }
    }
}
