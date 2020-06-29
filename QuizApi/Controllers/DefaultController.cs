using QuizApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizApi.Controllers
{
    public class DefaultController : ApiController
    {


        public List<Question> Get()
        {
            List<Question> questions = QuestionsDB.questions;
            Shufller.Shuffle<Question>(questions);
            return questions;
        }

    }
}
