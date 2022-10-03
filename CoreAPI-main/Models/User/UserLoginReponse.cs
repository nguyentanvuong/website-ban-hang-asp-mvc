﻿using Newtonsoft.Json.Linq;

namespace WebApi.Models.User
{
    public class UserLoginReponse
    {
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int? gender { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string birthday { get; set; }
        public string phone { get; set; }
        public string status { get; set; }
        public string usercreated { get; set; }
        public string datecreated { get; set; }
        public string expiretime { get; set; }
        public int branchid { get; set; }
        public int? deptid { get; set; }
        public int? userlevel { get; set; }
        public string coreuserid { get; set; }
        public string corelgname { get; set; }
        public string productid { get; set; }
        public bool? isshow { get; set; }
        public int? policyid { get; set; }
        public int? failnumber { get; set; }
        public string token { get; set; }
        public string token_type { get; set; }
        public string fastmode { get; set; }
        public JObject cdlist { get; set; }
        public JObject searchfunc { get; set; }
        public JObject form { get; set; }
        public JArray menu { get; set; }
    }
}
