﻿using System;
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Data;
using Entity;

namespace Business.BN
{
    //se
    public class USERINFO_BN
    {

        public bool Exists(string F_ACCOUNT)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select count(1) from USERINFO");
            strSql.Append(" where ");
            strSql.Append(" F_ACCOUNT = :F_ACCOUNT  ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36)			};
            parameters[0].Value = F_ACCOUNT;

            if (dbHelper.ExecuteNonQuery(strSql.ToString(), parameters) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Entity.USERINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("insert into USERINFO(");
            strSql.Append("F_ACCOUNT,F_NAME,F_PASSWORD,F_EMAIL,F_PHONE,F_TEL,F_DESCRIPTION,F_PHOTO,F_ADDRESS,F_REALNAME");
            strSql.Append(") values (");
            strSql.Append(":F_ACCOUNT,:F_NAME,:F_PASSWORD,:F_EMAIL,:F_PHONE,:F_TEL,:F_DESCRIPTION,:F_PHOTO,:F_ADDRESS,:F_REALNAME");
            strSql.Append(") ");

            OracleParameter[] parameters = {
			            new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_NAME", OracleType.VarChar,64) ,            
                        new OracleParameter(":F_PASSWORD", OracleType.VarChar,128) ,            
                        new OracleParameter(":F_EMAIL", OracleType.VarChar,128) ,            
                        new OracleParameter(":F_PHONE", OracleType.VarChar,16) ,            
                        new OracleParameter(":F_TEL", OracleType.VarChar,16) ,            
                        new OracleParameter(":F_DESCRIPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_PHOTO", OracleType.Blob) ,            
                        new OracleParameter(":F_ADDRESS", OracleType.NVarChar) ,            
                        new OracleParameter(":F_REALNAME", OracleType.NVarChar)             
              
            };

            parameters[0].Value = model.F_ACCOUNT;
            parameters[1].Value = model.F_NAME;
            parameters[2].Value = model.F_PASSWORD;
            parameters[3].Value = model.F_EMAIL;
            parameters[4].Value = model.F_PHONE;
            parameters[5].Value = model.F_TEL;
            parameters[6].Value = model.F_DESCRIPTION;
            parameters[7].Value = model.F_PHOTO;
            parameters[8].Value = model.F_ADDRESS;
            parameters[9].Value = model.F_REALNAME;
            dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Entity.USERINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("update USERINFO set ");

            strSql.Append(" F_ACCOUNT = :F_ACCOUNT , ");
            strSql.Append(" F_NAME = :F_NAME , ");
            strSql.Append(" F_PASSWORD = :F_PASSWORD , ");
            strSql.Append(" F_EMAIL = :F_EMAIL , ");
            strSql.Append(" F_PHONE = :F_PHONE , ");
            strSql.Append(" F_TEL = :F_TEL , ");
            strSql.Append(" F_DESCRIPTION = :F_DESCRIPTION , ");
            strSql.Append(" F_PHOTO = :F_PHOTO , ");
            strSql.Append(" F_ADDRESS = :F_ADDRESS , ");
            strSql.Append(" F_REALNAME = :F_REALNAME  ");
            strSql.Append(" where F_ACCOUNT=:F_ACCOUNT  ");

            OracleParameter[] parameters = {
			            new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_NAME", OracleType.VarChar,64) ,            
                        new OracleParameter(":F_PASSWORD", OracleType.VarChar,128) ,            
                        new OracleParameter(":F_EMAIL", OracleType.VarChar,128) ,            
                        new OracleParameter(":F_PHONE", OracleType.VarChar,16) ,            
                        new OracleParameter(":F_TEL", OracleType.VarChar,16) ,            
                        new OracleParameter(":F_DESCRIPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_PHOTO", OracleType.Blob) ,            
                        new OracleParameter(":F_ADDRESS", OracleType.NVarChar) ,            
                        new OracleParameter(":F_REALNAME", OracleType.NVarChar)             
              
            };

            parameters[0].Value = model.F_ACCOUNT;
            parameters[1].Value = model.F_NAME;
            parameters[2].Value = model.F_PASSWORD;
            parameters[3].Value = model.F_EMAIL;
            parameters[4].Value = model.F_PHONE;
            parameters[5].Value = model.F_TEL;
            parameters[6].Value = model.F_DESCRIPTION;
            parameters[7].Value = model.F_PHOTO;
            parameters[8].Value = model.F_ADDRESS;
            parameters[9].Value = model.F_REALNAME;
            int rows = dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_ACCOUNT)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("delete from USERINFO ");
            strSql.Append(" where F_ACCOUNT=:F_ACCOUNT ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36)			};
            parameters[0].Value = F_ACCOUNT;


            int rows = dbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Entity.USERINFO GetModel(string F_ACCOUNT)
        {

            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            strSql.Append("select F_ACCOUNT, F_NAME, F_PASSWORD, F_EMAIL, F_PHONE, F_TEL, F_DESCRIPTION, F_PHOTO, F_ADDRESS, F_REALNAME  ");
            strSql.Append("  from USERINFO ");
            strSql.Append(" where F_ACCOUNT=:F_ACCOUNT ");
            OracleParameter[] parameters = {
					new OracleParameter(":F_ACCOUNT", OracleType.VarChar,36)			};
            parameters[0].Value = F_ACCOUNT;

            dbHelper.OpenConn("");
            Entity.USERINFO model = new Entity.USERINFO();
            DataTable ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

            if (ds.Rows.Count > 0)
            {
                model.F_ACCOUNT = ds.Rows[0]["F_ACCOUNT"].ToString();
                model.F_NAME = ds.Rows[0]["F_NAME"].ToString();
                model.F_PASSWORD = ds.Rows[0]["F_PASSWORD"].ToString();
                model.F_EMAIL = ds.Rows[0]["F_EMAIL"].ToString();
                model.F_PHONE = ds.Rows[0]["F_PHONE"].ToString();
                model.F_TEL = ds.Rows[0]["F_TEL"].ToString();
                model.F_DESCRIPTION = ds.Rows[0]["F_DESCRIPTION"].ToString();
                if (ds.Rows[0]["F_PHOTO"].ToString() != "")
                {
                    model.F_PHOTO = (byte[])ds.Rows[0]["F_PHOTO"];
                }
                model.F_ADDRESS = ds.Rows[0]["F_ADDRESS"].ToString();
                model.F_REALNAME = ds.Rows[0]["F_REALNAME"].ToString();

                dbHelper.CloseConn();
                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            OracleParameter[] parameters = null;
            strSql.Append("select * ");
            strSql.Append(" FROM USERINFO ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataTable GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            DbAPI dbHelper = new DbAPI();
            OracleParameter[] parameters = null;
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM USERINFO ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbHelper.GetDataTable(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 根据用户名、密码查询用户是否存在
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetUserList(Entity.USERINFO user)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT F_ACCOUNT,F_NAME,F_REALNAME FROM USERINFO WHERE 1=1 AND F_NAME=:F_NAME AND F_PASSWORD=:F_PASSWORD ");

            DbAPI dbHelper = new DbAPI();
            List<OracleParameter> list = new List<OracleParameter>();
            list.Add(new OracleParameter(":F_NAME", user.F_NAME));
            list.Add(new OracleParameter(":F_PASSWORD", user.F_PASSWORD));

            dbHelper.OpenConn("");
            DataTable dt = dbHelper.GetDataTable(strSql.ToString(), list.ToArray());
            dbHelper.CloseConn();

            return dt;
        }

        /// <summary>
        /// (分页查询)从数据库中获取用户列表
        /// </summary>
        /// <param name="queryModel">查询条件</param>
        /// <returns>返回用户列表</returns>
        public DataTable GetUsersList(Entity.System.view.QueryModelUser queryModel)
        {
            try
            {
                var userName = queryModel.userName ?? "";
                var pageNumber = queryModel.offset / queryModel.limit + 1;
                var pageSize = queryModel.limit;

                var strSql = new StringBuilder();
                strSql.Append("select t.*,COUNT(*) OVER () RESULT_COUNT from userinfo t where t.f_name like '%'||:userName||'%'");

                OracleParameter[] parameters =
                {
                    new OracleParameter(":userName", userName)
                };
                var dbapi = new DbAPI();
                dbapi.OpenConn("");
                var rst = dbapi.GetDataTable(DbAPI.GeneratePagingSql(strSql.ToString(), pageNumber, pageSize), parameters);
                dbapi.CloseConn();
                return rst;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(USERINFO_BN), "(分页查询)从数据库中获取用户列表GetUsersList 程序段的异常" + ex);
                return null;
            }

        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns>是否成功的JSON结果</returns>
        public bool DeleteUser(string id)
        {
            try
            {
                OracleParameter[] parameters =
                {
                    new OracleParameter("p_userAccount", id)
                };

                var dbapi = new DbAPI();
                dbapi.OpenConn("");
                var rst = dbapi.ExecuteNonQueryByProcedure("DeleteUser", parameters);
                dbapi.CloseConn();

                return rst > 0;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(MonitorLog), "删除用户DeleteUser 程序段的异常" + ex);
                return false;
            }

        }


        /// <summary>
        /// 导出用户列表到Excel
        /// </summary>
        /// <param name="queryModel">查询参数</param>
        public DataTable GetExcelListUsers(Entity.System.view.QueryModelUser queryModel)
        {
            try
            {
                var userName = string.IsNullOrWhiteSpace(queryModel.userName) ? "" : queryModel.userName;
                var strSql = "SELECT f_name \"用户名\", f_realname \"真实姓名\", f_email \"邮箱\", f_phone \"固话\", f_tel \"手机\", f_description \"说明\", f_address \"住址\" FROM userinfo where f_name like '%' || :userName || '%'";

                OracleParameter[] parameters =
                {
                    new OracleParameter(":userName", userName)
                };
                var dbapi = new DbAPI();
                dbapi.OpenConn("");
                var rst = dbapi.GetDataTable(strSql, parameters);
                dbapi.CloseConn();
                return rst;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(MonitorLog), "导出用户列表到Excel方法GetExcelList 程序段的异常" + ex);
                return null;
            }

        }


        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="userinfo">用户实体类</param>
        /// <returns>是否成功</returns>
        public bool AddUserMain(USERINFO userinfo)
        {
            var listTrans = new List<Entity.OracleTransaction>();

            // USERINFO
            var newAccount = Guid.NewGuid().ToString();
            var strSql = new StringBuilder();
            strSql.Append(
                "INSERT INTO USERINFO(F_ACCOUNT, F_NAME, F_PASSWORD, F_EMAIL, F_PHONE, F_TEL, F_DESCRIPTION, F_ADDRESS, F_REALNAME)VALUES");
            strSql.Append(
                "(:F_ACCOUNT,:F_NAME, :F_PASSWORD, :F_EMAIL, :F_PHONE, :F_TEL, :F_DESCRIPTION, :F_ADDRESS,:F_REALNAME)");
            var parms = new Dictionary<string, object>
            {
                {"F_ACCOUNT", newAccount},
                {"F_NAME", userinfo.F_NAME},
                {"F_PASSWORD", userinfo.F_PASSWORD},
                {"F_EMAIL", userinfo.F_EMAIL ?? ""},
                {"F_PHONE", userinfo.F_PHONE ?? ""},
                {"F_TEL", userinfo.F_TEL ?? ""},
                {"F_DESCRIPTION", userinfo.F_DESCRIPTION ?? ""},
                {"F_ADDRESS", userinfo.F_ADDRESS ?? ""},
                {"F_REALNAME", userinfo.F_REALNAME ?? ""}
            };
            listTrans.Add(new Entity.OracleTransaction
            {
                SqlString = strSql.ToString(),
                Parameters = parms
            });

            // DEPARTMENTUSER
            strSql = new StringBuilder();
            strSql.Append(
                "INSERT INTO DEPARTMENTUSER(F_ID, F_DEPARTMENTCODE, F_ACCOUNT)VALUES");
            strSql.Append(
                "(SYS_GUID(),:F_DEPARTMENTCODE,:F_ACCOUNT)");
            parms = new Dictionary<string, object>
            {
                {"F_DEPARTMENTCODE", userinfo.F_DEPARTMENTCODE},
                {"F_ACCOUNT", newAccount}
            };
            listTrans.Add(new Entity.OracleTransaction
            {
                SqlString = strSql.ToString(),
                Parameters = parms
            });

            // USERROLE
            if (userinfo.Roleinfos != null && userinfo.Roleinfos.Length > 0)
            {
                foreach (var roleinfo in userinfo.Roleinfos)
                {
                    strSql = new StringBuilder();
                    strSql.Append(
                        "INSERT INTO USERROLE(F_ID, F_ACCOUNT, F_ROLECODE)VALUES");
                    strSql.Append(
                        "(SYS_GUID(),:F_ACCOUNT,:F_ROLECODE)");
                    parms = new Dictionary<string, object>
                    {
                        {"F_ACCOUNT", newAccount},
                        {"F_ROLECODE", roleinfo}
                    };
                    listTrans.Add(new Entity.OracleTransaction
                    {
                        SqlString = strSql.ToString(),
                        Parameters = parms
                    });
                }
            }

            var dbHelper = new DbAPI();
            try
            {
                dbHelper.RunOracleTransaction(listTrans);
                return true;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(ROLEINFO_BN), "新增用户AddRoleMain 程序段的异常" + ex);
                return false;
            }

        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="userinfo">用户实体类</param>
        /// <returns>是否成功</returns>
        public bool EditUserMain(USERINFO userinfo)
        {
            var listTrans = new List<Entity.OracleTransaction>();

            // USERINFO
            var account = userinfo.F_ACCOUNT;
            var strSql = new StringBuilder();
            strSql.Append("UPDATE USERINFO SET F_NAME=:F_NAME, F_PASSWORD=:F_PASSWORD, F_EMAIL=:F_EMAIL, F_PHONE=:F_PHONE, F_TEL=:F_TEL,");
            strSql.Append(" F_DESCRIPTION=:F_DESCRIPTION, F_ADDRESS=:F_ADDRESS, F_REALNAME=:F_REALNAME WHERE F_ACCOUNT=:F_ACCOUNT");
            var parms = new Dictionary<string, object>
            {
                {"F_ACCOUNT", account},
                {"F_NAME", userinfo.F_NAME},
                {"F_PASSWORD", userinfo.F_PASSWORD},
                {"F_EMAIL", userinfo.F_EMAIL ?? ""},
                {"F_PHONE", userinfo.F_PHONE ?? ""},
                {"F_TEL", userinfo.F_TEL ?? ""},
                {"F_DESCRIPTION", userinfo.F_DESCRIPTION ?? ""},
                {"F_ADDRESS", userinfo.F_ADDRESS ?? ""},
                {"F_REALNAME", userinfo.F_REALNAME ?? ""}
            };
            listTrans.Add(new Entity.OracleTransaction
            {
                SqlString = strSql.ToString(),
                Parameters = parms
            });

            // DEPARTMENTUSER
            strSql = new StringBuilder();
            strSql.Append(
                "UPDATE DEPARTMENTUSER SET F_DEPARTMENTCODE = :F_DEPARTMENTCODE");
            strSql.Append(
                " WHERE F_ACCOUNT = :F_ACCOUNT");
            parms = new Dictionary<string, object>
            {
                {"F_DEPARTMENTCODE", userinfo.F_DEPARTMENTCODE},
                {"F_ACCOUNT", account}
            };
            listTrans.Add(new Entity.OracleTransaction
            {
                SqlString = strSql.ToString(),
                Parameters = parms
            });

            // USERROLE
            if (userinfo.Roleinfos != null && userinfo.Roleinfos.Length > 0)
            {
                strSql = new StringBuilder();
                strSql.Append("DELETE USERROLE");
                strSql.Append(" WHERE F_ACCOUNT = :F_ACCOUNT");
                parms = new Dictionary<string, object>
                    {
                        {"F_ACCOUNT", account}
                    };
                listTrans.Add(new Entity.OracleTransaction
                {
                    SqlString = strSql.ToString(),
                    Parameters = parms
                });
                foreach (var roleinfo in userinfo.Roleinfos)
                {
                    strSql = new StringBuilder();
                    strSql.Append(
                        "INSERT INTO USERROLE(F_ID, F_ACCOUNT, F_ROLECODE)VALUES");
                    strSql.Append(
                        "(SYS_GUID(),:F_ACCOUNT,:F_ROLECODE)");
                    parms = new Dictionary<string, object>
                    {
                        {"F_ACCOUNT", account},
                        {"F_ROLECODE", roleinfo}
                    };
                    listTrans.Add(new Entity.OracleTransaction
                    {
                        SqlString = strSql.ToString(),
                        Parameters = parms
                    });
                }
            }

            var dbHelper = new DbAPI();
            try
            {
                dbHelper.RunOracleTransaction(listTrans);
                return true;
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(ROLEINFO_BN), "修改用户EditUserMain 程序段的异常" + ex);
                return false;
            }

        }

        /// <summary>
        /// 根据user account得到一个对象实体
        /// </summary>
        public Entity.USERINFO GetUserinforModel(string account)
        {

            var strSql = new StringBuilder();
            var dbHelper = new DbAPI();

            strSql.Append("select a.F_ACCOUNT,a.F_NAME,a.F_PASSWORD,a.F_EMAIL,a.F_PHONE,a.F_TEL,a.F_DESCRIPTION,a.F_ADDRESS,a.F_REALNAME,d.f_name as F_DEPARTMENTCODE,C.Roleinfos");
            strSql.Append("  from USERINFO a");
            strSql.Append("  left join departmentuser b");
            strSql.Append("    on a.f_account = b.f_account");
            strSql.Append("  left join departmentinfo d on b.f_departmentcode = d.f_departmentcode");
            strSql.Append("  LEFT JOIN (SELECT A.F_ACCOUNT,");
            strSql.Append("                    LISTAGG(TO_CHAR(B.F_NAME), ',') WITHIN GROUP(ORDER BY A.F_ACCOUNT) AS Roleinfos");
            strSql.Append("               FROM USERROLE A");
            strSql.Append("               LEFT JOIN ROLEINFO B");
            strSql.Append("                 ON A.F_ROLECODE = B.F_ROLECODE");
            strSql.Append("              GROUP BY A.F_ACCOUNT) C");
            strSql.Append("    ON A.F_ACCOUNT = C.F_ACCOUNT");
            strSql.Append(" where a.F_ACCOUNT = :F_ACCOUNT and rownum = 1");
            OracleParameter[] parameters =
            {
                new OracleParameter(":F_ACCOUNT", account)
            };

            dbHelper.OpenConn("");

            var ds = dbHelper.GetDataTable(strSql.ToString(), parameters);

            if (ds == null || ds.Rows.Count <= 0) return null;

            var row0 = ds.Rows[0];
            var model = new Entity.USERINFO
            {
                F_ACCOUNT = row0["F_ACCOUNT"].ToString(),
                F_NAME = row0["F_NAME"].ToString(),
                F_PASSWORD = row0["F_PASSWORD"].ToString(),
                F_EMAIL = row0["F_EMAIL"].ToString(),
                F_PHONE = row0["F_PHONE"].ToString(),
                F_TEL = row0["F_TEL"].ToString(),
                F_DESCRIPTION = row0["F_DESCRIPTION"].ToString(),
                F_ADDRESS = row0["F_ADDRESS"].ToString(),
                F_REALNAME = row0["F_REALNAME"].ToString(),
                DepartmentNames = row0["F_DEPARTMENTCODE"].ToString(),
                RoleNames = row0["Roleinfos"].ToString()
            };

            dbHelper.CloseConn();

            return model;

        }

        /// <summary>
        /// 获取用户头像(数据库中存储的是BLOB格式图片数据)
        /// </summary>
        /// <param name="userAccount">用户ID</param>
        public byte[] GetUserLogo(string userAccount)
        {
            var sql = "select f_photo from USERINFO WHERE F_ACCOUNT=:F_ACCOUNT";
            OracleParameter[] parameters =
            {
                new OracleParameter(":F_ACCOUNT", userAccount)
            };

            var dbapi = new DbAPI();
            dbapi.OpenConn("");
            var rst = dbapi.ExecuteOracleScalar(sql, parameters) as System.Data.OracleClient.OracleLob;

            if (rst != null)
            {
                byte[] bytes = new byte[rst.Length];
                rst.Read(bytes, 0, bytes.Length);
                dbapi.CloseConn();
                return bytes;

            }
            dbapi.CloseConn();
            return null;
        }


    }
}

