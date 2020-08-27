// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportTxns_Environment
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
  public class ExportImportTxns_Environment : Update_Environment
  {
    [Metadata("ExportImportType", "ExportImportTypeEnum", false, false, true, "Integer", 1050845, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportTxns_Environment_ExportImportType")]
    protected Environment _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportTxns_Environment_Details")]
    [Metadata("Export Import Item details", "ExportImportItem", false, false, false, "ExportImportItem", 1050823, false, true, false, null)]
    protected ExportImportItem_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportTxns_Environment_ExportImportName")]
    [Metadata("ExportImportName", "", false, false, false, "String", 1050821, false, false, false, null)]
    protected Environment _ExportImportName;

    public Environment ExportImportType
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

    public ExportImportItem_Environment Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ExportImportItem_Environment) this.PropertyGet(nameof (Details));
      }
    }

    public Environment ExportImportName
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
  }
}
