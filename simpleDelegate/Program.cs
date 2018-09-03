using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDelegate
{
    public class messageService 
    {
        public void videoEncoded (object source,videoEventArgs arg)
        {
            Console.WriteLine("Txt message has send .."+arg.video.Title);
        }
    }  
       

    delegate void messageProcessor(string x);
    class Person
    {
        string name;
        public Person (string name)
        {
            this.name = name;
        }
        public void Say (string message)
        {
            Console.WriteLine(message);
        }
    }
    class background
    {
        public static void Note (string note)
        {
            Console.WriteLine("Note is --" + note);
        }
    }
    class Program
    {
        private void saySome(string xx)
        {
            Console.WriteLine(xx);
        }
        static void Main(string[] args)
        {
            Person junaid = new Person("junaid mahmood is my name");
            Person Amamr = new Person("My name is Ammar Mahmood");
            messageProcessor message1, message2,staticMessage,anotherMethod;
            message1 = new messageProcessor(junaid.Say);
            message2 = new messageProcessor(Amamr.Say);
            staticMessage = new messageProcessor(background.Note);
          //  anotherMethod = new messageProcessor(Program.saySome);
         //   message1("hey junaid how are you");
          //  message2.Invoke("hello buddy ammar how r u ");
          //  staticMessage("statc message clal");
            anotherMethod = message1;
            anotherMethod += message2;
            anotherMethod += staticMessage;

            anotherMethod("multi delegate ...");

            // Video Encoder class delegate
            var vid  = new video(){ Title="First Video "};
            var vEncoder = new videoEncoder(); // publisher 
            var mail = new mailService(); // subscriver 
            var msgService = new messageService();
            vEncoder.videoEncoded += mail.onVideoEncoded;
            vEncoder.videoEncoded += msgService.videoEncoded;
            vEncoder.Encode(vid);
            Console.ReadLine();
        }
    }
}
