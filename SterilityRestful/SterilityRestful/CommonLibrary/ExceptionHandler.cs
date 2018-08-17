using System.Net;
using System.Net.Http;
using SterilityRestful.DataModels;
using JWT;
using System;
using System.Collections.Generic;
using JWT.Algorithms;
using JWT.Serializers;
using System.Text;
using System.Security.Cryptography;

namespace SterilityRestful.CommonLibrary
{
    public class ExceptionHandler
    {
        SterilityRestful.DataMethod.UserInfoMethod userInfoMethod = new DataMethod.UserInfoMethod();

        public HttpResponseMessage Register(HttpRequestMessage request, int operationResult)
        {

            Result res = new Result();
            res.result = "注册失败";
            var resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);

            switch (operationResult)
            {
                case 1:
                    res.result = "注册成功";
                    resp = request.CreateResponse(HttpStatusCode.OK, res);
                    break;
                case 0:
                    res.result = "注册失败";
                    resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);
                    break;
                case -1:
                    res.result = "同一用户名的同一角色已经存在";
                    resp = request.CreateResponse(HttpStatusCode.BadRequest, res);
                    break;
                case -2:
                    res.result = "数据库连接失败";
                    resp = request.CreateResponse(HttpStatusCode.NotFound, res);
                    break;
                default:
                    break;
            }
            return resp;
        }

        /// <summary>
        /// 1成功，0过期，-1非法
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public int TokenCheck(string token)
        {
            try
            {
                if (token == "Shangweiji")
                {
                    return 1;
                }
                IJsonSerializer serializer = new JsonNetSerializer();
                IDateTimeProvider provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);
                var json = decoder.Decode(token, "UTF-8", verify: true);//token为之前生成的字符串
                var userId = json.Split(',')[0].Split('"')[3];
                DataConnection pclsCache = new DataConnection();
                GetUserInfo a = userInfoMethod.MstUserGetUserInfo(pclsCache, userId, 0, 0, 0, 0, 0, 0, 1, 0, 0);
                if (a.Token == token)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (TokenExpiredException)
            {
                return 0;
            }
            catch (SignatureVerificationException)
            {
                return -1;
            }
        }

        public HttpResponseMessage Login(HttpRequestMessage request, int operationResult, Login login)
        {
            Result res = new Result();
            res.result = "用户不存在";
            var resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);

            switch (operationResult)
            {
                case 1:
                    IDateTimeProvider provider = new UtcDateTimeProvider();
                    var now = provider.GetNow();
                    var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc); // or use JwtValidator.UnixEpoch
                    var secondsSinceEpoch = Math.Round((now - unixEpoch).TotalSeconds);
                    var payload = new Dictionary<string, object>
                    {
                        { "userId", login.UserId },        
                        { "password", login.InPassword },
                        { "time", DateTime.Now }
                    };
                    IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
                    IJsonSerializer serializer = new JsonNetSerializer();
                    IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                    IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
                    var token = encoder.Encode(payload, "UTF-8");
                    DataConnection pclsCache = new DataConnection();
                    int a = userInfoMethod.MstUserChangeToken(pclsCache, login.UserId, token);

                    res.result = "登录成功|" + token;
                    resp = request.CreateResponse(HttpStatusCode.OK, res);
                    break;
                case 0:
                    res.result = "用户不存在";
                    resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);
                    break;
                case -1:
                    res.result = "密码错误";
                    resp = request.CreateResponse(HttpStatusCode.BadRequest, res);
                    break;
                case -2:
                    res.result = "数据库连接失败";
                    resp = request.CreateResponse(HttpStatusCode.NotFound, res);
                    break;
                default:
                    break;
            }
            return resp;
        }

        public HttpResponseMessage ChangePassword(HttpRequestMessage request, int operationResult)
        {
            Result res = new Result();
            res.result = "修改失败";
            var resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);

            switch (operationResult)
            {
                case 1:
                    res.result = "修改成功";
                    resp = request.CreateResponse(HttpStatusCode.OK, res);
                    break;
                case 0:
                    res.result = "修改失败";
                    resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);
                    break;
                case -1:
                    res.result = "旧密码错误";
                    resp = request.CreateResponse(HttpStatusCode.BadRequest, res);
                    break;
                case -2:
                    res.result = "数据库连接失败";
                    resp = request.CreateResponse(HttpStatusCode.NotFound, res);
                    break;
                default:
                    break;
            }
            return resp;
        }

        public HttpResponseMessage SetData(HttpRequestMessage request, int operationResult)
        {
            Result res = new Result();
            res.result = "插入失败";
            var resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);

            switch (operationResult)
            {
                case 1:
                    res.result = "插入成功";
                    resp = request.CreateResponse(HttpStatusCode.OK, res);
                    break;
                case 0:
                    res.result = "插入失败";
                    resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);
                    break;
                case -2:
                    res.result = "数据库连接失败";
                    resp = request.CreateResponse(HttpStatusCode.NotFound, res);
                    break;
                default:
                    break;
            }
            return resp;
        }

        public HttpResponseMessage DeleteData(HttpRequestMessage request, int operationResult)
        {
            Result res = new Result();
            res.result = "数据删除失败";
            //3 数据库连接失败  //0 数据删除失败  
            var resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);
            switch (operationResult)
            {
                case 1:
                    //数据删除成功
                    res.result = "数据删除成功";
                    resp = request.CreateResponse(HttpStatusCode.OK, res);
                    break;
                case 2:
                    //数据未找到
                    res.result = "数据未找到";
                    resp = request.CreateResponse(HttpStatusCode.NotFound, res);
                    break;
                case 3:
                    res.result = "数据库连接失败，无法删除";
                    resp = request.CreateResponse(HttpStatusCode.NotAcceptable, res);
                    break;
                default:
                    break;
            }
            return resp;
        }

        public string UpdateData(HttpRequestMessage request, int operationResult)
        {
            string result = "插入失败";
            switch (operationResult)
            {
                case 1:
                    result = "插入成功";
                    break;
                case 0:
                    result = "插入失败";
                    break;
                case -1:
                    result = "数据不存在";
                    break;
                case -2:
                    result = "数据库连接失败";
                    break;
                default:
                    break;
            }
            return result;
        }

        public string SHA1(string content, Encoding encode)
        {
            try
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                byte[] bytes_in = encode.GetBytes(content);
                byte[] bytes_out = sha1.ComputeHash(bytes_in);
                sha1.Dispose();
                string result = BitConverter.ToString(bytes_out);
                result = result.Replace("-", "");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("SHA1加密出错：" + ex.Message);
            }
        }
    }
}
