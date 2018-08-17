using System;

namespace SterilityRestful.DataModels
{
    public class UserInfo
    {
    }

    public class Register
    {
        public string UserId { get; set; }
        public string Identify { get; set; }
        public long PhoneNo { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class Login
    {
        public string UserId { get; set; }
        public string InPassword { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class ChangePassword
    {
        public string UserId { get; set; }
        public int IfPhone { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class UpdateUserInfo
    {
        public string UserId { get; set; }
        public string Identify { get; set; }
        public long PhoneNo { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
    }

    public class GetUserInfo
    {
        public string UserId { get; set; }
        public string Identify { get; set; }
        public long PhoneNo { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public DateTime LastLoginTime { get; set; }
        public string Token { get; set; }
        public DateTime LastLogoutTime { get; set; }
        public DateTime revDateTime { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalName { get; set; }
        public string revUserId { get; set; }
        public string revIdentify { get; set; }
    }

    public class QueryUserInfo
    {
        public string UserId { get; set; }
        public string Identify { get; set; }
        public string PhoneNo { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string LastLoginTimeS { get; set; }
        public string LastLoginTimeE { get; set; }
        public string Token { get; set; }
        public string LastLogoutTimeS { get; set; }
        public string LastLogoutTimeE { get; set; }
        public string ReDateTimeS { get; set; }
        public string ReDateTimeE { get; set; }
        public string ReTerminalIP { get; set; }
        public string ReTerminalName { get; set; }
        public string ReUserId { get; set; }
        public string ReIdentify { get; set; }
        public int GetIdentify { get; set; }
        public int GetPhoneNo { get; set; }
        public int GetUserName { get; set; }
        public int GetRole { get; set; }
        public int GetPassword { get; set; }
        public int GetLastLoginTime { get; set; }
        public int GetToken { get; set; }
        public int GetLastLogoutTime { get; set; }
        public int GetRevisionInfo { get; set; }
    }
}
