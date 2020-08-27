// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_Security_Info
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
  public class V4_Security_Info : Update_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Info_MaintenanceLevel")]
    protected Info _MaintenanceLevel;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Info_GroupName")]
    protected Info _GroupName;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Info_PermissionItem")]
    protected V4_PermissionEntry_Info _PermissionItem;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Info_Permissions")]
    protected V4_PermissionEntry_Info _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Info_AuditTrail")]
    protected Info _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Info_UserName")]
    protected Info _UserName;

    public Info MaintenanceLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceLevel));
      }
    }

    public Info GroupName
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GroupName));
      }
    }

    public V4_PermissionEntry_Info PermissionItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionItem), (object) value);
      }
      get
      {
        return (V4_PermissionEntry_Info) this.PropertyGet(nameof (PermissionItem));
      }
    }

    public V4_PermissionEntry_Info Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (V4_PermissionEntry_Info) this.PropertyGet(nameof (Permissions));
      }
    }

    public Info AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Info UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserName));
      }
    }
  }
}
