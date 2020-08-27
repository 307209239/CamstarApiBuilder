// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SecurityAuditTrail
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
  public class V4_SecurityAuditTrail : AuditTrail
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Header")]
    protected new SubentityRef _Header;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Permissions")]
    protected V4_AuditTrailSecPermission[] _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_SecurityUserName")]
    protected Primitive<string> _SecurityUserName;

    public override bool Equals(object obj)
    {
      return obj is V4_SecurityAuditTrail && object.Equals((object) this._Header, (object) ((V4_SecurityAuditTrail) obj)._Header) && (this.CompareArrays((Array) this._Permissions, (Array) ((V4_SecurityAuditTrail) obj)._Permissions) && object.Equals((object) this._ExportImportKey, (object) ((V4_SecurityAuditTrail) obj)._ExportImportKey)) && (object.Equals((object) this._HistoryId, (object) ((V4_SecurityAuditTrail) obj)._HistoryId) && object.Equals((object) this._SecurityUserName, (object) ((V4_SecurityAuditTrail) obj)._SecurityUserName)) && base.Equals(obj);
    }

    public new SubentityRef Header
    {
      [param: In] set
      {
        this.PropertySet(nameof (Header), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (Header));
      }
    }

    public V4_AuditTrailSecPermission[] Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (V4_AuditTrailSecPermission[]) this.PropertyGet(nameof (Permissions));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<string> SecurityUserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SecurityUserName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SecurityUserName));
      }
    }
  }
}
