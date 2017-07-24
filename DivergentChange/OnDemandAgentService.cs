using System;
using System.Collections.Generic;

namespace DivergentChange
{
    public class OnDemandAgentService
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public List<string> Log { get; set; }

        public OnDemandAgent StartNewOnDemandMachine()
        {
            LogInfo("Starting on-demand agent startup logic");

            try
            {
                if (IsAuthorized(Username, Password))
                {
                    LogInfo(string.Format("User {0} will attempt to start a new on-demand agent.", Username));
                    var agent = StartNewAmazonServer();
                    SendEmailToAdmin(string.Format("User {0} has successfully started a machine with ip {1}.", Username, agent.Ip));
                    return agent;
                }

                LogWarning(string.Format("User {0} attempted to start a new on-demand agent.", Username));
                throw new UnauthorizedAccessException("Unauthorized access to StartNewOnDemandMachine method.");
            }
            catch (Exception)
            {
                LogError("Exception in on-demand agent creation logic");
                throw;
            }
        }

        private OnDemandAgent StartNewAmazonServer()
        {
            // Call Amazon API and start a new EC2 instance, implementation omitted
            var amazonAgent = new OnDemandAgent();
            amazonAgent.Host = "usweav-ec2.mycompany.local";
            amazonAgent.Ip = "54.653.234.23";
            amazonAgent.ImageId = "ami-784930";
            return amazonAgent;
        }

        private void LogInfo(string info)
        {
            Log.Add(string.Concat("INFO: ", info));
        }

        private void LogWarning(string warning)
        {
            Log.Add(string.Concat("WARNING: ", warning));
        }

        private void LogError(string error)
        {
            Log.Add(string.Concat("ERROR: ", error));
        }

        private bool IsAuthorized(string username, string password)
        {
            return username == "admin" && password == "passw0rd";
        }

        private void SendEmailToAdmin(string message)
        {
            var emailHost = "email.mycompany.com";
            var recipient = "admin@mycompany.com";

            // actual email sending implementation omitted
        }
    }
}