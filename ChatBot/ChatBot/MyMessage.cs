using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
namespace ChatBot
{
    class MyMessage
    {
        public string request { get; set; }
        public string response { get; set; }
        public string this[string request]
        {
            get
            {
                if (this.request.Equals(request))
                    return response;
                else return "";
            }
        }

    }
    class Messages
    {
        List<MyMessage> messages;
        List<string> univanswers;
        List<string> univquestions;
        public Messages()
        {
            messages = new List<MyMessage>();
            univanswers = new List<string>() { 
                "I should think...",
                "Well.. it is hard to say",
                "Who knows...",
                "Who are asking?",
                "I do not want answering this question..."
            };
            univquestions = new List<string>();
            messages.Add(new MyMessage { request = "Hello", response = "hi" });
            messages.Add(new MyMessage { request = "how are you", response = "i am fine" });
            string filepath = @"D:\question_answer_pairs.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();
            lines.RemoveAt(0);
            foreach (var i in lines)
            {
                List<string> list = new List<string>();
                list = i.Split("	").ToList();
                messages.Add(new MyMessage { request = list[1], response = list[2] });
            }
        }
        public string this[string request]
        {
            get
            {
                foreach(var i in messages)
                {
                    if (!i[request].Equals("") && !i[request].Equals("NULL"))
                        return i[request];
                    else if (!i[request].Equals("") && i[request].Equals("NULL"))
                        return "i don't know the answer of this question";
                }
                Random random = new Random();
                int indexofanswer = random.Next(0, univanswers.Count-1);
                return univanswers[indexofanswer];
            }
        }
    }
}
