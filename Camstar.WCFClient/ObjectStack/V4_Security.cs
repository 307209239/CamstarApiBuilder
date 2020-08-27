// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_Security
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
  public class V4_Security : Update
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_MaintenanceLevel")]
    protected Primitive<int> _MaintenanceLevel;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_GroupName")]
    protected Primitive<string> _GroupName;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_PermissionItem")]
    protected V4_PermissionEntry _PermissionItem;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Permissions")]
    protected V4_PermissionEntry[] _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_AuditTrail")]
    protected SubentityRef[] _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_UserName")]
    protected Primitive<string> _UserName;

    public override bool Equals(object obj)
    {
      return obj is V4_Security && object.Equals((object) this._MaintenanceLevel, (object) ((V4_Security) obj)._MaintenanceLevel) && (object.Equals((object) this._GroupName, (object) ((V4_Security) obj)._GroupName) && object.Equals((object) this._PermissionItem, (object) ((V4_Security) obj)._PermissionItem)) && (this.CompareArrays((Array) this._Permissions, (Array) ((V4_Security) obj)._Permissions) && this.CompareArrays((Array) this._AuditTrail, (Array) ((V4_Security) obj)._AuditTrail) && object.Equals((object) this._UserName, (object) ((V4_Security) obj)._UserName)) && base.Equals(obj);
    }

    public Primitive<int> MaintenanceLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceLevel), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MaintenanceLevel));
      }
    }

    public Primitive<string> GroupName
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GroupName));
      }
    }

    public V4_PermissionEntry PermissionItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionItem), (object) value);
      }
      get
      {
        return (V4_PermissionEntry) this.PropertyGet(nameof (PermissionItem));
      }
    }

    public V4_PermissionEntry[] Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (V4_PermissionEntry[]) this.PropertyGet(nameof (Permissions));
      }
    }

    public SubentityRef[] AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Primitive<string> UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserName));
      }
    }
  }
}
