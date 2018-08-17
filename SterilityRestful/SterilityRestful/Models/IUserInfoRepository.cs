using SterilityRestful.CommonLibrary;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public interface IUserInfoRepository
    {
        int MstUserRegister(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string Password, string TerminalIP, string TerminalName, string revUserId);

        int MstUserLogin(DataConnection pclsCache, string UserId, string InPassword, string TerminalIP, string TerminalName, string revUserId);

        int MstUserChangePassword(DataConnection pclsCache, string UserId, int IfPhone, string OldPassword, string NewPassword, string TerminalIP, string TerminalName, string revUserId);

        int MstUserUpdateUserInfo(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string TerminalIP, string TerminalName, string revUserId);

        GetUserInfo MstUserGetUserInfo(DataConnection pclsCache, string UserId, int Identify, int PhoneNo, int UserName, int Role, int Password, int LastLoginTime, int Token, int LastLogoutTime, int RevisionInfo);

        string MstUserGetUserByPhoneNo(DataConnection pclsCache, long PhoneNo);

        string MstUserCreateNewUserId(DataConnection pclsCache, long PhoneNo);

        List<GetUserInfo> MstUserGetUsersInfoByAnyProperty(DataConnection pclsCache, string UserId, string Identify, string PhoneNo, string UserName, string Role, string Password, string LastLoginTimeS, string LastLoginTimeE, string Token, string LastLogoutTimeS, string LastLogoutTimeE, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetIdentify, int GetPhoneNo, int GetUserName, int GetRole, int GetPassword, int GetLastLoginTime, int GetToken, int GetLastLogoutTime, int GetRevisionInfo);

        List<TypeAndName> MstReagentTypeGetAll(DataConnection pclsCache);

        int MstUserChangeToken(DataConnection pclsCache, string UserId, string Token);
    }
}
