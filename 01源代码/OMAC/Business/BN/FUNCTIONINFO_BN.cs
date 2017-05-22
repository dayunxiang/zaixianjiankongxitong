﻿using System; 
using System.Text;
using System.Data.OracleClient;
using System.Collections.Generic; 
using System.Data;

namespace Business.BN  
{
		public class FUNCTIONINFO_BN
	{
   		     
		public bool Exists(string F_FUNCTIONCODE)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("select count(1) from FUNCTIONINFO");
			strSql.Append(" where ");
			                                       strSql.Append(" F_FUNCTIONCODE = :F_FUNCTIONCODE  ");
                            						OracleParameter[] parameters = {
					new OracleParameter(":F_FUNCTIONCODE", OracleType.VarChar,36)			};
			parameters[0].Value = F_FUNCTIONCODE;

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
		public void Add(Entity.FUNCTIONINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("insert into FUNCTIONINFO(");			
            strSql.Append("F_FUNCTIONCODE,F_NAME,F_DESCRIPTION,F_CAPTION,F_PRIORITY,F_PARENTID,URL");
			strSql.Append(") values (");
            strSql.Append(":F_FUNCTIONCODE,:F_NAME,:F_DESCRIPTION,:F_CAPTION,:F_PRIORITY,:F_PARENTID,:URL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_FUNCTIONCODE", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_NAME", OracleType.NVarChar) ,            
                        new OracleParameter(":F_DESCRIPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_CAPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_PRIORITY", OracleType.Number,22) ,            
                        new OracleParameter(":F_PARENTID", OracleType.VarChar,36) ,            
                        new OracleParameter(":URL", OracleType.NVarChar)             
              
            };
			            
            parameters[0].Value = model.F_FUNCTIONCODE;                        
            parameters[1].Value = model.F_NAME;                        
            parameters[2].Value = model.F_DESCRIPTION;                        
            parameters[3].Value = model.F_CAPTION;                        
            parameters[4].Value = model.F_PRIORITY;                        
            parameters[5].Value = model.F_PARENTID;                        
            parameters[6].Value = model.URL;                        
			            dbHelper.ExecuteNonQuery(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Entity.FUNCTIONINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("update FUNCTIONINFO set ");
			                        
            strSql.Append(" F_FUNCTIONCODE = :F_FUNCTIONCODE , ");                                    
            strSql.Append(" F_NAME = :F_NAME , ");                                    
            strSql.Append(" F_DESCRIPTION = :F_DESCRIPTION , ");                                    
            strSql.Append(" F_CAPTION = :F_CAPTION , ");                                    
            strSql.Append(" F_PRIORITY = :F_PRIORITY , ");                                    
            strSql.Append(" F_PARENTID = :F_PARENTID , ");                                    
            strSql.Append(" URL = :URL  ");            			
			strSql.Append(" where F_FUNCTIONCODE=:F_FUNCTIONCODE  ");
						
OracleParameter[] parameters = {
			            new OracleParameter(":F_FUNCTIONCODE", OracleType.VarChar,36) ,            
                        new OracleParameter(":F_NAME", OracleType.NVarChar) ,            
                        new OracleParameter(":F_DESCRIPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_CAPTION", OracleType.NVarChar) ,            
                        new OracleParameter(":F_PRIORITY", OracleType.Number,22) ,            
                        new OracleParameter(":F_PARENTID", OracleType.VarChar,36) ,            
                        new OracleParameter(":URL", OracleType.NVarChar)             
              
            };
						            
            parameters[0].Value = model.F_FUNCTIONCODE;                        
            parameters[1].Value = model.F_NAME;                        
            parameters[2].Value = model.F_DESCRIPTION;                        
            parameters[3].Value = model.F_CAPTION;                        
            parameters[4].Value = model.F_PRIORITY;                        
            parameters[5].Value = model.F_PARENTID;                        
            parameters[6].Value = model.URL;                        
            int rows=dbHelper.ExecuteNonQuery(strSql.ToString(),parameters);
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
		public bool Delete(string F_FUNCTIONCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("delete from FUNCTIONINFO ");
			strSql.Append(" where F_FUNCTIONCODE=:F_FUNCTIONCODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_FUNCTIONCODE", OracleType.VarChar,36)			};
			parameters[0].Value = F_FUNCTIONCODE;


			int rows=dbHelper.ExecuteNonQuery(strSql.ToString(),parameters);
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
		public Entity.FUNCTIONINFO GetModel(string F_FUNCTIONCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			strSql.Append("select F_FUNCTIONCODE, F_NAME, F_DESCRIPTION, F_CAPTION, F_PRIORITY, F_PARENTID, URL  ");			
			strSql.Append("  from FUNCTIONINFO ");
			strSql.Append(" where F_FUNCTIONCODE=:F_FUNCTIONCODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_FUNCTIONCODE", OracleType.VarChar,36)			};
			parameters[0].Value = F_FUNCTIONCODE;

			
			Entity.FUNCTIONINFO model=new Entity.FUNCTIONINFO();
			DataTable ds=dbHelper.GetDataTable(strSql.ToString(),parameters);
			
			if(ds.Rows.Count>0)
			{
                model.F_FUNCTIONCODE = ds.Rows[0]["F_FUNCTIONCODE"].ToString();
                model.F_NAME = ds.Rows[0]["F_NAME"].ToString();
                model.F_DESCRIPTION = ds.Rows[0]["F_DESCRIPTION"].ToString();
                model.F_CAPTION = ds.Rows[0]["F_CAPTION"].ToString();
                if (ds.Rows[0]["F_PRIORITY"].ToString() != "")
                {
                    model.F_PRIORITY = decimal.Parse(ds.Rows[0]["F_PRIORITY"].ToString());
                }
                model.F_PARENTID = ds.Rows[0]["F_PARENTID"].ToString();
                model.URL = ds.Rows[0]["URL"].ToString();

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
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			OracleParameter[] parameters = null;
			strSql.Append("select * ");
			strSql.Append(" FROM FUNCTIONINFO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            try { 
                dbHelper.OpenConn("");
                DataTable dt = new DataTable();
                dt = dbHelper.GetDataTable(strSql.ToString(), parameters);
                dbHelper.CloseConn();
                return dt;

            }catch(Exception ex){
                LogBN.WriteLog(typeof(FUNCTIONINFO_BN), "GetDataTable 程序段的异常" + ex);
                return null;
            }
			
		}
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataTable GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			DbAPI dbHelper = new DbAPI();
			OracleParameter[] parameters = null;
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM FUNCTIONINFO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return dbHelper.GetDataTable(strSql.ToString(),parameters);
		}

        public string GetFunctionTree(string part)
        {
            try
            {
                DataTable dataTable = GetList("F_PART = " + part);
                DataRow[] rows = dataTable.Select("F_PARENTID='#'");
                StringBuilder funTree = new StringBuilder();
                funTree.Append("[");
                for (int i = 0; i < rows.Length; i++)
                {
                    if (i == rows.Length - 1)
                    {
                        CreatFunctionTree(dataTable, rows[i], ref funTree, false);
                    }
                    else
                    {
                        CreatFunctionTree(dataTable, rows[i], ref funTree, true);
                    }
                }
                funTree.Append("]");
                return funTree.ToString();
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(FUNCTIONINFO_BN), "GetFunctionTree 程序段的异常" + ex);
                return null;
            }
        }

        public string GetMinitorFunctionTree(string parent, string type, string parentId)
        {
            try
            {
                DataTable dataTable = GetList("F_PART = '1'");
                DataRow[] rows = dataTable.Select("F_PARENTID='#'");
                StringBuilder funTree = new StringBuilder();
                funTree.Append("[");
                for (int i = 0; i < rows.Length; i++)
                {
                    if (i == rows.Length - 1)
                    {
                        CreatMinitorFunctionTree(dataTable, rows[i], ref funTree, false, parent, type, parentId);
                    }
                    else
                    {
                        CreatMinitorFunctionTree(dataTable, rows[i], ref funTree, true, parent, type, parentId);
                    }
                }
                funTree.Append("]");
                return funTree.ToString();
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(FUNCTIONINFO_BN), "GetFunctionTree 程序段的异常" + ex);
                return null;
            }
            
        }
        private void CreatMinitorFunctionTree(DataTable dt, DataRow dr, ref StringBuilder funTree, bool bl, string parent, string type, string parentId)
        {
            string selectName = "";
            switch(type)
            {
                case "21":
                    selectName = "yewu";
                    break;
                case "22":
                    selectName = "yewu";
                    break;
                case "31":
                    selectName = "jushusheshi";
                    break;
                case "32":
                    selectName = "difangsheshi";
                    break;
                case "41":
                    selectName = "haiqu";
                    break;
                case "42":
                    selectName = "shengfen";
                    break;
                case "43":
                    selectName = "haiwan";
                    break;
            }            
            funTree.Append("{");
            funTree.Append("\"id\":" + Convert.ToInt32(parentId + dr["F_FUNCTIONCODE"].ToString()) + ",");
            funTree.Append("\"text\":\"" + dr["F_NAME"] + "\",");
            funTree.Append("\"icon\":\"" + dr["F_ICON"] + "\",");
            funTree.Append("\"tag\":\"" + dr["F_PARENTID"] + "\",");
            DataRow[] rows = dt.Select("F_PARENTID='" + dr["F_FUNCTIONCODE"] + "'");
            int i = 0;
            if (rows.Length > 0)
            {
                funTree.Append("\"nodes\":");
                funTree.Append("[");
                for (i = 0; i < rows.Length; i++)
                {
                    if (i == rows.Length - 1)
                    {
                        CreatMinitorFunctionTree(dt, rows[i], ref funTree, false, parent, type, parentId);
                    }
                    else
                    {
                        CreatMinitorFunctionTree(dt, rows[i], ref funTree, true, parent, type, parentId);
                    }
                }

                funTree.Append("],");
            }
            if (bl)
            {
                funTree.Append("\"href\":\"" + dr["URL"] + "&" + selectName + "=" + System.Web.HttpUtility.UrlEncode(parent) + "\"");
                funTree.Append("},");
            }
            else
            {
                funTree.Append("\"href\":\"" + dr["URL"] + "&" + selectName + "=" + System.Web.HttpUtility.UrlEncode(parent) + "\"");
                funTree.Append("}");
            }
        }

        private void CreatFunctionTree(DataTable dt, DataRow dr, ref StringBuilder funTree, bool bl)
        {
            funTree.Append("{");
            funTree.Append("\"id\":" + dr["F_FUNCTIONCODE"] + ",");
            funTree.Append("\"text\":\"" + dr["F_NAME"] + "\",");
            funTree.Append("\"icon\":\"" + dr["F_ICON"] + "\",");
            funTree.Append("\"tag\":\"" + dr["F_PARENTID"] + "\",");
            DataRow[] rows = dt.Select("F_PARENTID='" + dr["F_FUNCTIONCODE"] + "'");
            int i = 0;
            if (rows.Length == 0 && dr["F_LEAF"].ToString() == "1")
            {
                funTree.Append("\"nodes\":");
                funTree.Append(GetMinitorFunctionTree(dr["F_NAME"].ToString(), dr["F_PARENTID"].ToString(), dr["F_FUNCTIONCODE"].ToString()));
                funTree.Append(",");
            }
            if (rows.Length > 0)
            {
                funTree.Append("\"nodes\":");
                funTree.Append("[");
                for (i = 0; i < rows.Length; i++)
                {
                    if (i == rows.Length - 1)
                    {
                        CreatFunctionTree(dt, rows[i], ref funTree, false);
                    }
                    else
                    {
                        CreatFunctionTree(dt, rows[i], ref funTree, true);
                    }
                }

                funTree.Append("],");
            }
            if (bl)
            {
                funTree.Append("\"href\":\"" + dr["URL"] + "\"");
                funTree.Append("},");
            }
            else
            {
                funTree.Append("\"href\":\"" + dr["URL"] + "\"");
                funTree.Append("}");
            }
        }

        public string GetFunctionTree2(string part)
        {
            if (part == "1")
            {
                return GetMinitorFunctionTree2("", "", "");
            }
            try
            {
                DataTable dataTable = GetList("F_PART = " + part);
                DataRow[] rows = dataTable.Select("F_PARENTID='#'");
                StringBuilder funTree = new StringBuilder();
                funTree.Append("[");
                for (int i = 0; i < rows.Length; i++)
                {
                    if (i == rows.Length - 1)
                    {
                        CreatFunctionTree2(dataTable, rows[i], ref funTree, false);
                    }
                    else
                    {
                        CreatFunctionTree2(dataTable, rows[i], ref funTree, true);
                    }
                }
                funTree.Append("]");
                return funTree.ToString();
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(FUNCTIONINFO_BN), "GetFunctionTree 程序段的异常" + ex);
                return null;
            }
        }

        public string GetMinitorFunctionTree2(string parent, string type, string parentId)
        {                    
            try
            {
                DataTable dataTable = GetList("F_PART = '1'");
                DataRow[] rows = dataTable.Select("F_PARENTID='#'");
                StringBuilder funTree = new StringBuilder();
                funTree.Append("[");
                for (int i = 0; i < rows.Length; i++)
                {
                    if (i == rows.Length - 1)
                    {
                        switch (rows[i]["F_FUNCTIONCODE"].ToString()) 
                        { 
                            case "11":
                                CreatMinitorFunctionTree2(rows[i], ref funTree, false, parent, type, parentId);
                                break;
                            case "12":
                                CreatMinitorFunctionTree2(rows[i], ref funTree, false, parent, type, parentId);
                                break;
                            case "13":
                                CreatMinitorFunctionTree(dataTable, rows[i], ref funTree, false, parent, type, parentId);
                                break;
                            case "14":
                                CreatMinitorFunctionTree(dataTable, rows[i], ref funTree, false, parent, type, parentId);
                                break;
                        }
                        
                    }
                    else
                    {
                        switch (rows[i]["F_FUNCTIONCODE"].ToString())
                        {
                            case "11":
                                CreatMinitorFunctionTree2(rows[i], ref funTree, true, parent, type, parentId);
                                break;
                            case "12":
                                CreatMinitorFunctionTree2(rows[i], ref funTree, true, parent, type, parentId);
                                break;
                            case "13":
                                CreatMinitorFunctionTree(dataTable, rows[i], ref funTree, true, parent, type, parentId);
                                break;
                            case "14":
                                CreatMinitorFunctionTree(dataTable, rows[i], ref funTree, true, parent, type, parentId);
                                break;
                        }
                    }
                }
                funTree.Append("]");
                return funTree.ToString();
            }
            catch (Exception ex)
            {
                LogBN.WriteLog(typeof(FUNCTIONINFO_BN), "GetFunctionTree 程序段的异常" + ex);
                return null;
            }

        }
        private void CreatMinitorFunctionTree2(DataRow dr, ref StringBuilder funTree, bool bl, string parent, string type, string parentId)
        {
            string selectName = "";
            switch (type)
            {
                case "21":
                    selectName = "SERVICE";
                    break;
                case "22":
                    selectName = "SERVICE";
                    break;
                case "31":
                    selectName = "BUREAUDEVICE";
                    break;
                case "32":
                    selectName = "LOCALDEVICE";
                    break;
                case "41":
                    selectName = "SEAAREA";
                    break;
                case "42":
                    selectName = "PROVINCE";
                    break;
                case "43":
                    selectName = "BAY";
                    break;
            }   
            funTree.Append("{");
            funTree.Append("\"id\":" +  dr["F_FUNCTIONCODE"].ToString() + ",");
            funTree.Append("\"text\":\"" + dr["F_NAME"] + "\",");
            funTree.Append("\"icon\":\"" + dr["F_ICON"] + "\",");
            funTree.Append("\"tag\":\"" + dr["F_PARENTID"] + "\",");
            DEVICEINFO_BN dev_bn = new DEVICEINFO_BN();
            string whr = "";
            if (selectName == "")
            {
                whr =  " DEVICETYPE = " + dr["F_FUNCTIONCODE"].ToString().Substring(dr["F_FUNCTIONCODE"].ToString().Length - 1);
            }
            else 
            {
                whr = selectName + " = '" + parent + "' AND " + " DEVICETYPE = " + dr["F_FUNCTIONCODE"].ToString().Substring(dr["F_FUNCTIONCODE"].ToString().Length - 1);
            }
            DataTable dt = dev_bn.GetList(whr);
            DataRow[] rows = dt.Select(" 1=1 ");
            int i = 0;
            if (rows.Length > 0)
            {
                funTree.Append("\"nodes\":");
                funTree.Append("[");
                for (i = 0; i < rows.Length; i++)
                {
                    if (i == rows.Length - 1)
                    {
                        funTree.Append("{");
                        funTree.Append("\"id\":\"" + rows[i]["DEVICECODE"].ToString() + "\",");
                        funTree.Append("\"text\":\"" + rows[i]["DEVICENAME"] + "\",");
                        funTree.Append("\"icon\":\" \",");
                        funTree.Append("\"tag\":\" \",");
                        DataTable dataTable = this.GetList(" F_PRIORITY = " + dr["F_FUNCTIONCODE"].ToString().Substring(dr["F_FUNCTIONCODE"].ToString().Length - 1));
                        DataRow[] rowss = dataTable.Select(" 1=1 ");
                        int j = 0;
                        if (rowss.Length > 0)
                        {
                            funTree.Append("\"nodes\":");
                            funTree.Append("[");
                            for (j = 0; j < rowss.Length; j++)
                            {
                                if (j == rowss.Length - 1)
                                {
                                    funTree.Append("{");
                                    funTree.Append("\"id\":" + rowss[j]["F_FUNCTIONCODE"].ToString() + ",");
                                    funTree.Append("\"text\":\"" + rowss[j]["F_NAME"] + "\",");
                                    funTree.Append("\"icon\":\" " + rowss[j]["F_ICON"] + "\",");
                                    funTree.Append("\"tag\":\" \",");
                                    funTree.Append("\"href\":\"" + rowss[j]["URL"] + "\"");
                                    funTree.Append("}");

                                }
                                else
                                {
                                    funTree.Append("{");
                                    funTree.Append("\"id\":" + rowss[j]["F_FUNCTIONCODE"].ToString() + ",");
                                    funTree.Append("\"text\":\"" + rowss[j]["F_NAME"] + "\",");
                                    funTree.Append("\"icon\":\" " + rowss[j]["F_ICON"] + "\",");
                                    funTree.Append("\"tag\":\"\",");
                                    funTree.Append("\"href\":\"" + rowss[j]["URL"] + "\"");
                                    funTree.Append("},");
                                }
                            }

                            funTree.Append("],");
                        }
                        funTree.Append("\"href\":\"#\"");
                        funTree.Append("}");
                    }
                    else
                    {
                        funTree.Append("{");
                        funTree.Append("\"id\":\"" + rows[i]["DEVICECODE"].ToString() + "\",");
                        funTree.Append("\"text\":\"" + rows[i]["DEVICENAME"] + "\",");
                        funTree.Append("\"icon\":\"\",");
                        funTree.Append("\"tag\":\"\",");
                        DataTable dataTable = this.GetList(" F_PRIORITY = " + dr["F_FUNCTIONCODE"].ToString().Substring(dr["F_FUNCTIONCODE"].ToString().Length - 1));
                        DataRow[] rowss = dataTable.Select(" 1=1 ");
                        int j = 0;
                        if (rowss.Length > 0)
                        {
                            funTree.Append("\"nodes\":");
                            funTree.Append("[");
                            for (j = 0; j < rowss.Length; j++)
                            {
                                if (j == rowss.Length - 1)
                                {
                                    funTree.Append("{");
                                    funTree.Append("\"id\":" + rowss[j]["F_FUNCTIONCODE"].ToString() + ",");
                                    funTree.Append("\"text\":\"" + rowss[j]["F_NAME"] + "\",");
                                    funTree.Append("\"icon\":\" " + rowss[j]["F_ICON"] + "\",");
                                    funTree.Append("\"tag\":\"\",");
                                    funTree.Append("\"href\":\"" + rowss[j]["URL"] + "\"");
                                    funTree.Append("}");

                                }
                                else
                                {
                                    funTree.Append("{");
                                    funTree.Append("\"id\":" + rowss[j]["F_FUNCTIONCODE"].ToString() + ",");
                                    funTree.Append("\"text\":\"" + rowss[j]["F_NAME"] + "\",");
                                    funTree.Append("\"icon\":\" " + rowss[j]["F_ICON"] + "\",");
                                    funTree.Append("\"tag\":\"\",");
                                    funTree.Append("\"href\":\"" + rowss[j]["URL"] + "\"");
                                    funTree.Append("},");
                                }
                            }

                            funTree.Append("],");
                        }
                        funTree.Append("\"href\":\"#\"");
                        funTree.Append("},");
                    }
                }

                funTree.Append("],");
            }
            else if (rows.Length == 0)
            {
                funTree.Append("\"nodes\":");
                funTree.Append("[");
                funTree.Append("{");
                funTree.Append("\"id\":\"\",");
                funTree.Append("\"text\":\"暂无设备\",");
                funTree.Append("\"icon\":\"\",");
                funTree.Append("\"tag\":\"\",");
                funTree.Append("\"href\":\"null\"");
                funTree.Append("}");
                funTree.Append("],");
            }
            if (bl)
            {
                funTree.Append("\"href\":\"" + dr["URL"] + "\"");
                funTree.Append("},");
            }
            else
            {
                funTree.Append("\"href\":\"" + dr["URL"] +  "\"");
                funTree.Append("}");
            }
        }

        private void CreatFunctionTree2(DataTable dt, DataRow dr, ref StringBuilder funTree, bool bl)
        {
            funTree.Append("{");
            funTree.Append("\"id\":" + dr["F_FUNCTIONCODE"] + ",");
            funTree.Append("\"text\":\"" + dr["F_NAME"] + "\",");
            funTree.Append("\"icon\":\"" + dr["F_ICON"] + "\",");
            funTree.Append("\"tag\":\"" + dr["F_PARENTID"] + "\",");
            DataRow[] rows = dt.Select("F_PARENTID='" + dr["F_FUNCTIONCODE"] + "'");
            int i = 0;
            if (rows.Length == 0 && dr["F_LEAF"].ToString() == "1")
            {
                funTree.Append("\"nodes\":");
                funTree.Append(GetMinitorFunctionTree2(dr["F_NAME"].ToString(), dr["F_PARENTID"].ToString(), dr["F_FUNCTIONCODE"].ToString()));
                funTree.Append(",");
            }
            if (rows.Length > 0)
            {
                funTree.Append("\"nodes\":");
                funTree.Append("[");
                for (i = 0; i < rows.Length; i++)
                {
                    if (i == rows.Length - 1)
                    {
                        CreatFunctionTree2(dt, rows[i], ref funTree, false);
                    }
                    else
                    {
                        CreatFunctionTree2(dt, rows[i], ref funTree, true);
                    }                 
                }               
                
                funTree.Append("],");
            }
            if (bl)
            {
                funTree.Append("\"href\":\"" + dr["URL"] + "\"");
                funTree.Append("},");
            }
            else
            {
                funTree.Append("\"href\":\"" + dr["URL"] + "\"");
                funTree.Append("}");
            }
        }

   
	}
}

