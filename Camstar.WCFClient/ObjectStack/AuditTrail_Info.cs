// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (V4_SecurityAuditTrail_Info))]
  [KnownType(typeof (ModelingAuditTrail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class AuditTrail_Info : HistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrail_Info_Header")]
    protected Info _Header;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrail_Info_HistoryId")]
    protected new Info _HistoryId;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Header
    {
      [param: In] set
      {
        this.PropertySet(nameof (Header), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Header));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
