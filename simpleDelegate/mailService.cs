using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDelegate
{
    public class mailService
    {
        public void onVideoEncoded(object source, videoEventArgs args)
        {
            Console.WriteLine("Mail is send ..."+args.video.Title);
        }
    }
}
