using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp_practice_01
{
    public class OnDemandAgentService
    {
        ErrorLog errorLog = new ErrorLog();
        Authorization authorization = new Authorization();

        EmailService emailService = new EmailService();

        
        public OnDemandAgent StartNewOnDemandMachine()
        {
            errorLog.LogInfo("Starting on-demand agent startup logic");
            try
            {
                if (authorization.IsAuthorized(Username, Password))
                {
                    errorLog.LogInfo(string.Format("User {0} will attempt to start a new on-demand agent.", Username));
                    OnDemandAgent agent = StartNewAmazonServer();
                   emailService.SendEmailToAdmin(string.Format("User {0} has successfully started a machine with ip {1}.", Username, agent.Ip));
                    return agent;
                }
                else
                {
                    errorLog.LogWarning(string.Format("User {0} attempted to start a new on-demand agent."));
                    throw new UnauthorizedAccessException("Unauthorized access to StartNewOnDemandMachine method.");
                }
            }
            catch (Exception ex)
            {
                errorLog.LogError("Exception in on-demand agent creation logic");
                throw;
            }
        }

        public string Username { get; set; }
        public string Password { get; set; }

        private OnDemandAgent StartNewAmazonServer()
        {
            //Call Amazon API and start a new EC2 instance, implementation omitted
            OnDemandAgent amazonAgent = new OnDemandAgent();
            amazonAgent.Host = "usweav-ec2.mycompany.local";
            amazonAgent.Ip = "54.653.234.23";
            amazonAgent.ImageId = "ami-784930";
            return amazonAgent;
        }


       
    }
}
