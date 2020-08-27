// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ImportStatusInquiry_Info
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
  public class ImportStatusInquiry_Info : ExportImportInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ImportStatusInquiry_Info_ImportSetName")]
    protected Info _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "ImportStatusInquiry_Info_ImportSetStatus")]
    protected Info _ImportSetStatus;
    [DataMember(EmitDefaultValue = false, Name = "ImportStatusInquiry_Info_ExportImportType")]
    protected new Info _ExportImportType;

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

    public Info ImportSetStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImportSetStatus));
      }
    }

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
  }
}
