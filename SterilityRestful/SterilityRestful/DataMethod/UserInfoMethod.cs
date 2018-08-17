using SterilityRestful.CommonLibrary;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;
using System.Text;
using SterilityRestful.CommonLibrary;

namespace SterilityRestful.DataMethod
{
    public class UserInfoMethod
    {
        /// <summary>
        /// 注册 -2：连接数据库失败 -1：同一用户名的同一角色已经存在 0：注册失败 1：注册成功
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="Identify"></param>
        /// <param name="PhoneNo"></param>
        /// <param name="UserName"></param>
        /// <param name="Role"></param>
        /// <param name="Password"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int MstUserRegister(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string Password, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try 
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstUser.Register(pclsCache.CacheConnectionObject, UserId, Identify, PhoneNo, UserName, Role, Password, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserRegister", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 登录 -2：连接数据库失败 -1：密码错误 0：用户不存在 1：登录成功
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="InPassword"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int MstUserLogin(DataConnection pclsCache, string UserId, string InPassword, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstUser.Login(pclsCache.CacheConnectionObject, UserId, InPassword, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserLogin", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 修改密码 -2：连接数据库失败 -1：旧密码错误 0：修改失败 1：修改成功
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="IfPhone"></param>
        /// <param name="OldPassword"></param>
        /// <param name="NewPassword"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int MstUserChangePassword(DataConnection pclsCache, string UserId, int IfPhone, string OldPassword, string NewPassword, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstUser.ChangePassword(pclsCache.CacheConnectionObject, UserId, IfPhone, OldPassword, NewPassword, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserChangePassword", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 修改个人信息 -2：连接数据库失败 0：修改失败 1：修改成功
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="Identify"></param>
        /// <param name="PhoneNo"></param>
        /// <param name="UserName"></param>
        /// <param name="Role"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int MstUserUpdateUserInfo(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstUser.UpdateUserInfo(pclsCache.CacheConnectionObject, UserId, Identify, PhoneNo, UserName, Role, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserUpdateUserInfo", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 得到用户信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="Identify"></param>
        /// <param name="PhoneNo"></param>
        /// <param name="UserName"></param>
        /// <param name="Role"></param>
        /// <param name="Password"></param>
        /// <param name="LastLoginTime"></param>
        /// <param name="RevisionInfo"></param>
        /// <returns></returns>
        public GetUserInfo MstUserGetUserInfo(DataConnection pclsCache, string UserId, int Identify, int PhoneNo, int UserName, int Role, int Password, int LastLoginTime, int Token, int LastLogoutTime, int RevisionInfo)
        {
            GetUserInfo Result = new GetUserInfo();
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                string[] ret = Cm.MstUser.GetUserInfo(pclsCache.CacheConnectionObject, UserId, Identify, PhoneNo, UserName, Role, Password, LastLoginTime, Token, LastLogoutTime, RevisionInfo).Split('|');
                Result.UserId = UserId;
                if (ret[0] != "")
                {
                    Result.Identify = ret[0];
                }
                if (ret[1] != "")
                {
                    Result.PhoneNo = Convert.ToInt64(ret[1]);
                }
                if (ret[2] != "")
                {
                    Result.UserName = ret[2];
                }
                if (ret[3] != "")
                {
                    Result.Role = ret[3];
                }
                if (ret[4] != "")
                {
                    Result.Password = ret[4];
                }
                if (ret[5] != "")
                {
                    Result.LastLoginTime = Convert.ToDateTime(ret[5]);
                }
                if (ret[6] != "")
                {
                    Result.Token = ret[6];
                }
                if (ret[7] != "")
                {
                    Result.LastLogoutTime = Convert.ToDateTime(ret[7]);
                }
                if (ret[8] != "")
                {
                    Result.revDateTime = Convert.ToDateTime(ret[8]);
                }
                if (ret[9] != "")
                {
                    Result.TerminalIP = ret[9];
                }
                if (ret[10] != "")
                {
                    Result.TerminalName = ret[10];
                }
                if (ret[11] != "")
                {
                    Result.revUserId = ret[11];
                }
                if (ret[12] != "")
                {
                    Result.revIdentify = ret[12];
                }
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserGetUserInfo", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据手机号获取用户唯一标识符
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="PhoneNo"></param>
        /// <returns></returns>
        public string MstUserGetUserByPhoneNo(DataConnection pclsCache, long PhoneNo)
        {
            string Result = "";
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Cm.MstUser.GetUserByPhoneNo(pclsCache.CacheConnectionObject, PhoneNo);
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserGetUserByPhoneNo", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 创建UserId
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="PhoneNo"></param>
        /// <returns></returns>
        public string MstUserCreateNewUserId(DataConnection pclsCache, long PhoneNo)
        {
            string Result = "";
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Cm.MstUser.CreateNewUserId(pclsCache.CacheConnectionObject, PhoneNo);
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserCreateNewUserId", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据任何筛选条件得到用户们的信息
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="Identify"></param>
        /// <param name="PhoneNo"></param>
        /// <param name="UserName"></param>
        /// <param name="Role"></param>
        /// <param name="Password"></param>
        /// <param name="LastLoginTimeS"></param>
        /// <param name="LastLoginTimeE"></param>
        /// <param name="ReDateTimeS"></param>
        /// <param name="ReDateTimeE"></param>
        /// <param name="ReTerminalIP"></param>
        /// <param name="ReTerminalName"></param>
        /// <param name="ReUserId"></param>
        /// <param name="ReIdentify"></param>
        /// <param name="GetIdentify"></param>
        /// <param name="GetPhoneNo"></param>
        /// <param name="GetUserName"></param>
        /// <param name="GetRole"></param>
        /// <param name="GetPassword"></param>
        /// <param name="GetLastLoginTime"></param>
        /// <param name="GetRevisionInfo"></param>
        /// <returns></returns>
        public List<GetUserInfo> MstUserGetUsersInfoByAnyProperty(DataConnection pclsCache, string UserId, string Identify, string PhoneNo, string UserName, string Role, string Password, string LastLoginTimeS, string LastLoginTimeE, string Token, string LastLogoutTimeS, string LastLogoutTimeE, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetIdentify, int GetPhoneNo, int GetUserName, int GetRole, int GetPassword, int GetLastLoginTime, int GetToken, int GetLastLogoutTime, int GetRevisionInfo)
        {
            List<GetUserInfo> list = new List<GetUserInfo>();
            try
            {
                if(!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Cm.MstUser.GetUsersInfoByAnyProperty(pclsCache.CacheConnectionObject, UserId, Identify, PhoneNo, UserName, Role, Password, LastLoginTimeS, LastLoginTimeE, Token, LastLogoutTimeS, LastLogoutTimeE, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetIdentify, GetPhoneNo, GetUserName, GetRole, GetPassword, GetLastLoginTime, GetToken, GetLastLogoutTime, GetRevisionInfo);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    GetUserInfo userInfo = new GetUserInfo();
                    if (ret[0] != "")
                    {
                        userInfo.UserId = ret[0];
                    }
                    if (ret[1] != "")
                    {
                        userInfo.Identify = ret[1];
                    }
                    if (ret[2] != "")
                    {
                        userInfo.PhoneNo = Convert.ToInt64(ret[2]);
                    }
                    if (ret[3] != "")
                    {
                        userInfo.UserName = ret[3];
                    }
                    if (ret[4] != "")
                    {
                        userInfo.Role = ret[4];
                    }
                    if (ret[5] != "")
                    {
                        userInfo.Password = ret[5];
                    }
                    if (ret[6] != "")
                    {
                        userInfo.LastLoginTime = Convert.ToDateTime(ret[6]);
                    }
                    if (ret[7] != "")
                    {
                        userInfo.Token = ret[7];
                    }
                    if (ret[8] != "")
                    {
                        userInfo.LastLogoutTime = Convert.ToDateTime(ret[8]);
                    }
                    if (ret[9] != "")
                    {
                        userInfo.revDateTime = Convert.ToDateTime(ret[9]);
                    }
                    if (ret[10] != "")
                    {
                        userInfo.TerminalIP = ret[10];
                    }
                    if (ret[11] != "")
                    {
                        userInfo.TerminalName = ret[11];
                    }
                    if (ret[12] != "")
                    {
                        userInfo.revUserId = ret[12];
                    }
                    if (ret[13] != "")
                    {
                        userInfo.revIdentify = ret[13];
                    }
                    list.Add(userInfo);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserGetUsersInfoByAnyProperty", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 得到所有试剂类型
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <returns></returns>
        public List<TypeAndName> MstReagentTypeGetAll(DataConnection pclsCache)
        {
            List<TypeAndName> list = new List<TypeAndName>();
            try
            {
                if (!pclsCache.Connect())
                {
                    return list;
                }
                InterSystems.Data.CacheTypes.CacheSysList Result = Cm.MstReagentType.GetAll(pclsCache.CacheConnectionObject);
                int count = Result.Count;
                int i = 1;
                while (i < count)
                {
                    string[] ret = Result[i].Split('|');
                    TypeAndName info = new TypeAndName();
                    info.Type = ret[0];
                    info.Name = ret[1];
                    list.Add(info);
                    i++;
                }
                return list;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstReagentTypeGetAll", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return list;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// Token改变
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="Token"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int MstUserChangeToken(DataConnection pclsCache, string UserId, string Token)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstUser.ChangeToken(pclsCache.CacheConnectionObject, UserId, Token));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserChangeToken", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }
    }
}
