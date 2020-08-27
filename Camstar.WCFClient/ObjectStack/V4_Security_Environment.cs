// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_Security_Environment
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
  public class V4_Security_Environment : Update_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Environment_MaintenanceLevel")]
    [Metadata("MaintenanceLevel", "", false, false, false, "Integer", 1049443, false, false, false, "1")]
    protected Environment _MaintenanceLevel;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Environment_GroupName")]
    [Metadata("Name for user security group.", "", false, false, false, "String", 1049445, false, false, true, null)]
    protected Environment _GroupName;
    [Metadata("Detail permission entry for defining function security. Each entry defines the access allowed for a specific function within a given Service", "V4_PermissionEntry", false, false, false, "V4_PermissionEntry", 1049468, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Environment_PermissionItem")]
    protected V4_PermissionEntry_Environment _PermissionItem;
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Environment_Permissions")]
    [Metadata("Detail permission entry for defining function security. Each entry defines the access allowed for a specific function within a given Service", "V4_PermissionEntry", false, false, false, "V4_PermissionEntry", 1049448, false, true, false, null)]
    protected V4_PermissionEntry_Environment _Permissions;
    [Metadata("Security Audit Trail Header encapsulates the header information captured during security maintenance transactions", "V4_SecurityAuditTrailHeader", false, false, true, "SubentityRef", 1050769, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Environment_AuditTrail")]
    protected Environment _AuditTrail;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049444, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_Security_Environment_UserName")]
    protected Environment _UserName;

    public Environment MaintenanceLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceLevel));
      }
    }

    public Environment GroupName
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GroupName));
      }
    }

    public V4_PermissionEntry_Environment PermissionItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionItem), (object) value);
      }
      get
      {
        return (V4_PermissionEntry_Environment) this.PropertyGet(nameof (PermissionItem));
      }
    }

    public V4_PermissionEntry_Environment Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (V4_PermissionEntry_Environment) this.PropertyGet(nameof (Permissions));
      }
    }

    public Environment AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Environment UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserName));
      }
    }
  }
}
