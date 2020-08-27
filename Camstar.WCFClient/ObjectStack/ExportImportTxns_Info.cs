// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportTxns_Info
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
  public class ExportImportTxns_Info : Update_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportTxns_Info_ExportImportType")]
    protected Info _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportTxns_Info_Details")]
    protected ExportImportItem_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportTxns_Info_ExportImportName")]
    protected Info _ExportImportName;

    public Info ExportImportType
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

    public ExportImportItem_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ExportImportItem_Info) this.PropertyGet(nameof (Details));
      }
    }

    public Info ExportImportName
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
  }
}
