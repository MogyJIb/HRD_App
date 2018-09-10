using HRD_DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Rest.Services
{
    public class RewardService : Service<Reward>, IRewardService
    {
        public const string NAME = "rewards";

        public RewardService(HttpClient httpClient, Dictionary<string, string> args)
            : base(NAME, httpClient, args) { }
    }
}