// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Import_Info
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
  public class Import_Info : ExportImportTxns_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Import_Info_ExportImportType")]
    protected new Info _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "Import_Info_ImportActionIfModified")]
    protected Info _ImportActionIfModified;
    [DataMember(EmitDefaultValue = false, Name = "Import_Info_ImportContents")]
    protected ImportContent_Info _ImportContents;
    [DataMember(EmitDefaultValue = false, Name = "Import_Info_ExportImportName")]
    protected new Info _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "Import_Info_ImportSetName")]
    protected Info _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "Import_Info_ImportIfExists")]
    protected Info _ImportIfExists;
    [DataMember(EmitDefaultValue = false, Name = "Import_Info_AutoBuildImportDetails")]
    protected Info _AutoBuildImportDetails;

    public new Info ExportImportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportType));
      }
    }

    public Info ImportActionIfModified
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportActionIfModified), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImportActionIfModified));
      }
    }

    public ImportContent_Info ImportContents
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportContents), (object) value);
      }
      get
      {
        return (ImportContent_Info) this.PropertyGet(nameof (ImportContents));
      }
    }

    public new Info ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public Info ImportSetName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImportSetName));
      }
    }

    public Info ImportIfExists
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportIfExists), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImportIfExists));
      }
    }

    public Info AutoBuildImportDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoBuildImportDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoBuildImportDetails));
      }
    }
  }
}
