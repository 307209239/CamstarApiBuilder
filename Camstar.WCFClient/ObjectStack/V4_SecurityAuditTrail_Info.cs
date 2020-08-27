// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SecurityAuditTrail_Info
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
  public class V4_SecurityAuditTrail_Info : AuditTrail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Info_Header")]
    protected new Info _Header;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Info_Permissions")]
    protected V4_AuditTrailSecPermission_Info _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Info_SecurityUserName")]
    protected Info _SecurityUserName;

    public new Info Header
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

    public V4_AuditTrailSecPermission_Info Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (V4_AuditTrailSecPermission_Info) this.PropertyGet(nameof (Permissions));
      }
    }

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

    public Info SecurityUserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SecurityUserName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SecurityUserName));
      }
    }
  }
}
