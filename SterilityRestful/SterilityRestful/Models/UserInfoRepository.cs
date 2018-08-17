using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public class UserInfoRepository : IUserInfoRepository
    {
        UserInfoMethod UserInfoMethod = new UserInfoMethod();
        public int MstUserRegister(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string Password, string TerminalIP, string TerminalName, string revUserId)
        {
            return UserInfoMethod.MstUserRegister(pclsCache, UserId, Identify, PhoneNo, UserName, Role, Password, TerminalIP, TerminalName, revUserId);
        }

        public int MstUserLogin(DataConnection pclsCache, string UserId, string InPassword, string TerminalIP, string TerminalName, string revUserId)
        {
            return UserInfoMethod.MstUserLogin(pclsCache, UserId, InPassword, TerminalIP, TerminalName, revUserId);
        }

        public int MstUserChangePassword(DataConnection pclsCache, string UserId, int IfPhone, string OldPassword, string NewPassword, string TerminalIP, string TerminalName, string revUserId)
        {
            return UserInfoMethod.MstUserChangePassword(pclsCache, UserId, IfPhone, OldPassword, NewPassword, TerminalIP, TerminalName, revUserId);
        }

        public int MstUserUpdateUserInfo(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string TerminalIP, string TerminalName, string revUserId)
        {
            return UserInfoMethod.MstUserUpdateUserInfo(pclsCache, UserId, Identify, PhoneNo, UserName, Role, TerminalIP, TerminalName, revUserId);
        }

        public GetUserInfo MstUserGetUserInfo(DataConnection pclsCache, string UserId, int Identify, int PhoneNo, int UserName, int Role, int Password, int LastLoginTime, int Token, int LastLogoutTime, int RevisionInfo)
        {
            return UserInfoMethod.MstUserGetUserInfo(pclsCache, UserId, Identify, PhoneNo, UserName, Role, Password, LastLoginTime, Token, LastLogoutTime, RevisionInfo);
        }

        public string MstUserGetUserByPhoneNo(DataConnection pclsCache, long PhoneNo)
        {
            return UserInfoMethod.MstUserGetUserByPhoneNo(pclsCache, PhoneNo);
        }

        public string MstUserCreateNewUserId(DataConnection pclsCache, long PhoneNo)
        {
            return UserInfoMethod.MstUserCreateNewUserId(pclsCache, PhoneNo);
        }

        public List<GetUserInfo> MstUserGetUsersInfoByAnyProperty(DataConnection pclsCache, string UserId, string Identify, string PhoneNo, string UserName, string Role, string Password, string LastLoginTimeS, string LastLoginTimeE, string Token, string LastLogoutTimeS, string LastLogoutTimeE, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetIdentify, int GetPhoneNo, int GetUserName, int GetRole, int GetPassword, int GetLastLoginTime, int GetToken, int GetLastLogoutTime, int GetRevisionInfo)
        {
            return UserInfoMethod.MstUserGetUsersInfoByAnyProperty(pclsCache, UserId, Identify, PhoneNo, UserName, Role, Password, LastLoginTimeS, LastLoginTimeE, Token, LastLogoutTimeS, LastLogoutTimeE, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetIdentify, GetPhoneNo, GetUserName, GetRole, GetPassword, GetLastLoginTime, GetToken, GetLastLogoutTime, GetRevisionInfo);
        }

        public List<TypeAndName> MstReagentTypeGetAll(DataConnection pclsCache)
        {
            return UserInfoMethod.MstReagentTypeGetAll(pclsCache);
        }

        public int MstUserChangeToken(DataConnection pclsCache, string UserId, string Token)
        {
            return UserInfoMethod.MstUserChangeToken(pclsCache, UserId, Token);
        }
    }
}
