using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace QuizApi.Models
{
    [DataContract]
    public class Answer
    {
        public Answer(String text, bool isCorrect)
        {
            this.text = text;
            this.isCorrect = isCorrect;
        }
        [DataMember]
        public String text;
        [DataMember]
        public bool isCorrect;
    }
}