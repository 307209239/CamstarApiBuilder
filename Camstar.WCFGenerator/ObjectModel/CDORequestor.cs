// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.ObjectModel.CDORequestor
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;
using Camstar.WCF.Generator.ObjectModel.ModelDataSetTableAdapters;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace Camstar.WCF.Generator.ObjectModel
{
  internal class CDORequestor : RequestorBase
  {
    private readonly CDOChildrenTableAdapter _CDOChildrenTableAdapter = new CDOChildrenTableAdapter();
    private readonly CDOMethodsTableAdapter _CDOMethodsTableAdapter = new CDOMethodsTableAdapter();
    private readonly CDOFieldsTableAdapter _CDOFieldsTableAdapter = new CDOFieldsTableAdapter();
    private readonly WCFWorkspacesTableAdapter _WCFWorkspacesTableAdapter = new WCFWorkspacesTableAdapter();
    private static List<CDODefinition> _Cdos;
    private static List<CDOMethod> _Methods;
    private static List<CDOField> _Fields;
    private static CDORequestor _currentRequestor;
    private const string REGISTRY_VALUE = "TemplateDatabaseFileCompiled";

    public CDORequestor(string connectionString)
    {
      if (RequestorBase.IsGetFromRegistry)
      {
        string str = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Camstar\\Camstar InSite Common", "TemplateDatabaseFileCompiled", (object) string.Empty) as string;
        if (string.IsNullOrEmpty(str))
          str = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Camstar\\Camstar InSite Common", "TemplateDatabaseFileCompiled", (object) string.Empty) as string;
        Hashtable connectionString1 = this.ParseConnectionString(connectionString);
        if (string.IsNullOrEmpty(str))
          connectionString1[(object) "data source"] = (object) "Compiled.mdb";
        else
          connectionString1[(object) "data source"] = (object) str;
        connectionString = this.ParseHashtable(connectionString1);
      }
      OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
      this._CDOChildrenTableAdapter.Connection = oleDbConnection;
      this._CDOMethodsTableAdapter.Connection = oleDbConnection;
      this._CDOFieldsTableAdapter.Connection = oleDbConnection;
      this._WCFWorkspacesTableAdapter.Connection = oleDbConnection;
    }

    public static CDORequestor CurrentRequestor
    {
      get
      {
        return CDORequestor._currentRequestor ?? (CDORequestor._currentRequestor = new CDORequestor(RequestorBase.ConnectionString));
      }
      set
      {
        CDORequestor._currentRequestor = value;
      }
    }

    public List<CDODefinition> GetChildren(int id)
    {
      if (CDORequestor._Cdos == null)
      {
        CDORequestor._Cdos = new List<CDODefinition>();
        foreach (ModelDataSet.CDOChildrenRow row in (InternalDataCollectionBase) this._CDOChildrenTableAdapter.GetData().Rows)
          CDORequestor._Cdos.Add(new CDODefinition(row));
      }
      return CDORequestor._Cdos.Where<CDODefinition>((Func<CDODefinition, bool>) (cdo => id == cdo.CDOParentTypeID)).ToList<CDODefinition>();
    }

    public List<CDOMethod> GetMethods(int id)
    {
      if (CDORequestor._Methods == null)
      {
        CDORequestor._Methods = new List<CDOMethod>();
        foreach (ModelDataSet.CDOMethodsRow row in (InternalDataCollectionBase) this._CDOMethodsTableAdapter.GetData().Rows)
          CDORequestor._Methods.Add(new CDOMethod(row));
      }
      return CDORequestor._Methods.Where<CDOMethod>((Func<CDOMethod, bool>) (method => id == method.CDOId)).ToList<CDOMethod>();
    }

    public List<CDOField> GetFields(int id)
    {
      if (CDORequestor._Fields == null)
      {
        CDORequestor._Fields = new List<CDOField>();
        foreach (ModelDataSet.CDOFieldsRow row in (InternalDataCollectionBase) this._CDOFieldsTableAdapter.GetData().Rows)
          CDORequestor._Fields.Add(new CDOField(row));
      }
      return CDORequestor._Fields.Where<CDOField>((Func<CDOField, bool>) (field => id == field.CDOID)).ToList<CDOField>();
    }

    public List<ModelDataSet.WCFWorkspacesRow> GetWorkspaces()
    {
      try
      {
        ModelDataSet.WCFWorkspacesDataTable workspacesDataTable = new ModelDataSet.WCFWorkspacesDataTable();
        this._WCFWorkspacesTableAdapter.Fill(workspacesDataTable);
        return workspacesDataTable.OrderBy<ModelDataSet.WCFWorkspacesRow, int>((Func<ModelDataSet.WCFWorkspacesRow, int>) (w => w.Sequence)).ToList<ModelDataSet.WCFWorkspacesRow>();
      }
      catch (Exception ex)
      {
        throw new WCFGeneratorException(ex);
      }
    }
  }
}
