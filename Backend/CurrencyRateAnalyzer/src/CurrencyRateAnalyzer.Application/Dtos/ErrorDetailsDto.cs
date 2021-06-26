using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyRateAnalyzer.Application.Dtos
{
    public class ErrorDetailsDto
    {
        public int StatusCode { get; }
        public string Message { get; }

        [JsonConstructor]
        public ErrorDetailsDto(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
