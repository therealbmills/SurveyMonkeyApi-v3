﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SurveyMonkey.Enums;

namespace SurveyMonkey.Containers
{
    [JsonConverter(typeof(TolerantJsonConverter))]
    public class Question
    {
        public long? Id { get; set; }
        public QuestionFamily? Family { get; set; }
        public QuestionSubtype? Subtype { get; set; }
        public int? Position { get; set; }
        public QuestionRequired Required { get; set; }
        public QuestionSorting Sorting { get; set; }
        public QuestionValidation Validation { get; set; }
        public List<Headings> Headings { get; set; }
        public bool? Visible { get; set; }
        public bool? ForcedRanking { get; set; }
        public string Href { get; set; }
        public QuestionAnswers Answers { get; set; }
    }
}