// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Import_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Import_Environment : ExportImportTxns_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Import_Environment_ExportImportType")]
    [Metadata("ExportImportType", "ExportImportTypeEnum", false, false, true, "Integer", 1050845, false, false, false, null)]
    protected new Environment _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "Import_Environment_ImportActionIfModified")]
    [Metadata("ImportAction", "ImportActionEnum", false, false, false, "Integer", 1050830, false, false, true, null)]
    protected Environment _ImportActionIfModified;
    [DataMember(EmitDefaultValue = false, Name = "Import_Environment_ImportContents")]
    [Metadata("Import Content details", "ImportContent", false, false, true, "ImportContent", 1050827, false, true, false, null)]
    protected ImportContent_Environment _ImportContents;
    [DataMember(EmitDefaultValue = false, Name = "Import_Environment_ExportImportName")]
    [Metadata("ExportImportName", "", false, true, false, "String", 1050821, false, false, false, null)]
    protected new Environment _ExportImportName;
    [Metadata("ExportImportName", "", false, true, false, "String", 1050828, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Import_Environment_ImportSetName")]
    protected Environment _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "Import_Environment_ImportIfExists")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050829, false, false, false, "0")]
    protected Environment _ImportIfExists;
    [DataMember(EmitDefaultValue = false, Name = "Import_Environment_AutoBuildImportDetails")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777442, false, false, false, "0")]
    protected Environment _AutoBuildImportDetails;

    public new Environment ExportImportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportType));
      }
    }

    public Environment ImportActionIfModified
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportActionIfModified), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImportActionIfModified));
      }
    }

    public ImportContent_Environment ImportContents
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportContents), (object) value);
      }
      get
      {
        return (ImportContent_Environment) this.PropertyGet(nameof (ImportContents));
      }
    }

    public new Environment ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public Environment ImportSetName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImportSetName));
      }
    }

    public Environment ImportIfExists
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportIfExists), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImportIfExists));
      }
    }

    public Environment AutoBuildImportDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoBuildImportDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoBuildImportDetails));
      }
    }
  }
}
