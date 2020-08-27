// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.ObjectModel.SiteInfoRequestor
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;
using Camstar.WCF.Generator.ObjectModel.ModelDataSetTableAdapters;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace Camstar.WCF.Generator.ObjectModel
{
  internal class SiteInfoRequestor : RequestorBase
  {
    private readonly UserTableAdapter _userTableAdapter = new UserTableAdapter();
    private static SiteInfoRequestor _currentRequestor;
    private const string REGISTRY_VALUE = "SiteInfoDatabaseFile";

    public SiteInfoRequestor(string connectionString)
    {
      string str = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Camstar\\Camstar InSite Common", "SiteInfoDatabaseFile", (object) string.Empty) as string;
      if (string.IsNullOrEmpty(str))
        str = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Camstar\\Camstar InSite Common", "SiteInfoDatabaseFile", (object) string.Empty) as string;
      Hashtable connectionString1 = this.ParseConnectionString(connectionString);
      if (string.IsNullOrEmpty(str))
        connectionString1[(object) "data source"] = (object) "SiteInfo.mdb";
      else
        connectionString1[(object) "data source"] = (object) str;
      connectionString = this.ParseHashtable(connectionString1);
      this._userTableAdapter.Connection = new OleDbConnection(connectionString);
    }

    public List<ModelDataSet.UserRow> GetUsers()
    {
      try
      {
        ModelDataSet.UserDataTable userDataTable = new ModelDataSet.UserDataTable();
        this._userTableAdapter.Fill(userDataTable);
        return userDataTable.ToList<ModelDataSet.UserRow>();
      }
      catch (Exception ex)
      {
        throw new WCFGeneratorException(ex);
      }
    }

    public static SiteInfoRequestor CurrentRequestor
    {
      get
      {
        return SiteInfoRequestor._currentRequestor ?? (SiteInfoRequestor._currentRequestor = new SiteInfoRequestor(RequestorBase.ConnectionString));
      }
      set
      {
        SiteInfoRequestor._currentRequestor = value;
      }
    }
  }
}
