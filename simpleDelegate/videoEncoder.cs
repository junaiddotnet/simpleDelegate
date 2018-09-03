using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDelegate
{
    public class videoEventArgs :EventArgs
    {
        public video video { get; set; }
    }
   public class videoEncoder
    {
        public delegate void videoEncoderEventHandlder (object source, videoEventArgs args);

        public event videoEncoderEventHandlder videoEncoded;
        public void Encode(video v)
        {
            Console.WriteLine("Video is Encoded ...");
            onVideoEncoded(v);
        }
        protected virtual void onVideoEncoded (video v)
        {
            if (videoEncoded!=null)
            {
                videoEncoded(this, new videoEventArgs() { video=v});
            }
        }
    }
}
