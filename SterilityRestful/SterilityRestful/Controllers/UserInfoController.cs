using SterilityRestful.CommonLibrary;
using SterilityRestful.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SterilityRestful.DataModels;
using System;

namespace SterilityRestful.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*"), WebApiTracker]
    public class UserInfoController : ApiController
    {
        static readonly IUserInfoRepository repository = new UserInfoRepository();
        DataConnection pclsCache = new DataConnection();
        
        /// <summary>
        /// 注册 注册 -2：连接数据库失败 -1：同一用户名的同一角色已经存在 0：注册失败 1：注册成功
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserRegister")]
        public HttpResponseMessage MstUserRegister(Register register)
        {
            int ret = repository.MstUserRegister(pclsCache, register.UserId, register.Identify, register.PhoneNo, register.UserName, register.Role, register.Password, register.TerminalIP, register.TerminalName, register.revUserId);
            return new ExceptionHandler().Register(Request, ret);
        }

        /// <summary>
        /// 登录 -2：连接数据库失败 -1：密码错误 0：用户不存在 1：登录成功
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserLogin")]
        public HttpResponseMessage MstUserLogin(Login login)
        {
            int ret = repository.MstUserLogin(pclsCache, login.UserId, login.InPassword, login.TerminalIP, login.TerminalName, login.revUserId);
            return new ExceptionHandler().Login(Request, ret, login);
        }

        /// <summary>
        /// 修改密码 -2：连接数据库失败 -1：旧密码错误 0：修改失败 1：修改成功
        /// </summary>
        /// <param name="changePassword"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserChangePassword")]
        public object MstUserChangePassword(ChangePassword changePassword)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            int ret = repository.MstUserChangePassword(pclsCache, changePassword.UserId, changePassword.IfPhone, changePassword.OldPassword, changePassword.NewPassword, changePassword.TerminalIP, changePassword.TerminalName, changePassword.revUserId);
            return new ExceptionHandler().ChangePassword(Request, ret);
        }

        /// <summary>
        /// 修改个人信息 -2：连接数据库失败 0：修改失败 1：修改成功
        /// </summary>
        /// <param name="updateUserInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserUpdateUserInfo")]
        public object MstUserUpdateUserInfo(UpdateUserInfo updateUserInfo)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            int ret = repository.MstUserUpdateUserInfo(pclsCache, updateUserInfo.UserId, updateUserInfo.Identify, updateUserInfo.PhoneNo, updateUserInfo.UserName, updateUserInfo.Role, updateUserInfo.TerminalIP, updateUserInfo.TerminalName, updateUserInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }
        
        /// <summary>
        /// 得到用户信息
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="Identify"></param>
        /// <param name="PhoneNo"></param>
        /// <param name="UserName"></param>
        /// <param name="Role"></param>
        /// <param name="Password"></param>
        /// <param name="LastLoginTime"></param>
        /// <param name="RevisionInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserGetUserInfo")]
        [HttpGet]
        public object MstUserGetUserInfo(string UserId, int Identify, int PhoneNo, int UserName, int Role, int Password, int LastLoginTime, int Token, int LastLogoutTime, int RevisionInfo)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            return repository.MstUserGetUserInfo(pclsCache, UserId, Identify, PhoneNo, UserName, Role, Password, LastLoginTime, Token, LastLogoutTime, RevisionInfo);
        }

        /// <summary>
        /// 根据手机号获取用户唯一标识符
        /// </summary>
        /// <param name="PhoneNo"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserGetUserByPhoneNo")]
        [HttpGet]
        public Result MstUserGetUserByPhoneNo(long PhoneNo)
        {
            return new Result(){
                result = repository.MstUserGetUserByPhoneNo(pclsCache, PhoneNo)
            };
        }

        /// <summary>
        /// 创建新的UserId
        /// </summary>
        /// <param name="PhoneNo"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserCreateNewUserId")]
        [HttpGet]
        public Result MstUserCreateNewUserId(long PhoneNo)
        {
            return new Result(){
                result = repository.MstUserCreateNewUserId(pclsCache, PhoneNo)
            };
        }

        /// <summary>
        /// 根据任何筛选条件得到用户们的信息
        /// </summary>
        /// <param name="queryUserInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserGetUsersInfoByAnyProperty")]
        public object MstUserGetUsersInfoByAnyProperty(QueryUserInfo queryUserInfo)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            return repository.MstUserGetUsersInfoByAnyProperty(pclsCache, queryUserInfo.UserId, queryUserInfo.Identify, queryUserInfo.PhoneNo, queryUserInfo.UserName, queryUserInfo.Role, queryUserInfo.Password, queryUserInfo.LastLoginTimeS, queryUserInfo.LastLoginTimeE, queryUserInfo.Token, queryUserInfo.LastLogoutTimeS, queryUserInfo.LastLogoutTimeE, queryUserInfo.ReDateTimeS, queryUserInfo.ReDateTimeE, queryUserInfo.ReTerminalIP, queryUserInfo.ReTerminalName, queryUserInfo.ReUserId, queryUserInfo.ReIdentify, queryUserInfo.GetIdentify, queryUserInfo.GetPhoneNo, queryUserInfo.GetUserName, queryUserInfo.GetRole, queryUserInfo.GetPassword, queryUserInfo.GetLastLoginTime, queryUserInfo.GetToken, queryUserInfo.GetLastLogoutTime, queryUserInfo.GetRevisionInfo);
        }

        /// <summary>
        /// 得到所有试剂类型
        /// </summary>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstReagentTypeGetAll")]
        [HttpGet]
        public object MstReagentTypeGetAll()
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            return repository.MstReagentTypeGetAll(pclsCache);
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserLogout")]
        public object Logout(string UserId)
        {
            string token = Request.Headers.Authorization.ToString();
            int valid = new ExceptionHandler().TokenCheck(token);
            if (valid == 0)
            {
                return "Token has expired";
            }
            if (valid == -1)
            {
                return "Token has invalid signature";
            }
            return repository.MstUserChangeToken(pclsCache, UserId, "");
        }

        /// <summary>
        /// 获取当前时间
        /// </summary>
        /// <returns></returns>
        [Route("Api/v1/Common/CurrentTime")]
        [HttpGet]
        public ServerTime CurrentTime()
        {
            return new ServerTime(){
                time = DateTime.Now
            };
        }
    }
}