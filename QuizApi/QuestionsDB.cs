using QuizApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizApi
{
    public static class QuestionsDB
    {
        public static Question question1 = new Question("BMW", new List<Answer>() {new Answer("Inglaterra",false), new Answer("USA", false), new Answer("Alemanha", true) , new Answer("Japão", false) });
        public static Question question2 = new Question("Toyota", new List<Answer>() { new Answer("Inglaterra", false), new Answer("USA", false), new Answer("Alemanha", false), new Answer("Japão", true) });
        public static Question question3 = new Question("Mini", new List<Answer>() { new Answer("Inglaterra", true), new Answer("USA", false), new Answer("Alemanha", false), new Answer("Japão", false) });
        public static Question question4 = new Question("General Motors", new List<Answer>() { new Answer("Inglaterra", false), new Answer("USA", true), new Answer("Alemanha", false), new Answer("Japão", false) });
        public static Question question5 = new Question("Rolls-Royce", new List<Answer>() { new Answer("Inglaterra", true), new Answer("USA", false), new Answer("Alemanha", false), new Answer("Japão", false) });

        public static List<Question> questions = new List<Question> {question1,question2,question3,question4,question5 };
    }
}