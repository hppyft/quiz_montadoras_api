using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace QuizApi.Models
{
    [DataContract]
    public class Question
    {
        public Question(String text, List<Answer> answers)
        {
            this.text = text;
            this.answers = answers;
        }
        [DataMember]
        public String text;
        [DataMember]
        public List<Answer> answers;

    }
}