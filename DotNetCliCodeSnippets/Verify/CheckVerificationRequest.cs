﻿using Nexmo.Api;
using Nexmo.Api.Request;
using Nexmo.Api.Verify;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCliCodeSnippets.Verify
{
    public class CheckVerificationRequest : ICodeSnippet
    {
        public void Execute()
        {
            var NEXMO_API_KEY = Environment.GetEnvironmentVariable("NEXMO_API_KEY") ?? "NEXMO_API_KEY";
            var NEXMO_API_SECRET = Environment.GetEnvironmentVariable("NEXMO_API_SECRET") ?? "NEXMO_API_SECRET";
            var REQUEST_ID = Environment.GetEnvironmentVariable("REQUEST_ID") ?? "REQUEST_ID";
            var CODE = Environment.GetEnvironmentVariable("CODE") ?? "CODE";

            var credentials = Credentials.FromApiKeyAndSecret(NEXMO_API_KEY, NEXMO_API_SECRET);
            var client = new NexmoClient(credentials);

            var request = new VerifyCheckRequest() { Code = CODE, RequestId = REQUEST_ID };
            var response = client.VerifyClient.VerifyCheck(request);

            Console.WriteLine($"Verify Check Complete\nRequest Id:{response.RequestId}\nStatus:{response.Status}");
        }
    }
}
