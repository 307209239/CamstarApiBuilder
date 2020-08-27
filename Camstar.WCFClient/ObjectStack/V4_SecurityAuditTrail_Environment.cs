// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SecurityAuditTrail_Environment
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
  public class V4_SecurityAuditTrail_Environment : AuditTrail_Environment
  {
    [Metadata("Security Audit Trail Header encapsulates the header information captured during security maintenance transactions", "V4_SecurityAuditTrailHeader", false, false, true, "SubentityRef", 1050770, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Environment_Header")]
    protected new Environment _Header;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Environment_Permissions")]
    [Metadata("Encapsulation for the security permission values captured for Audit Trail", "V4_AuditTrailSecPermission", false, false, true, "V4_AuditTrailSecPermission", 1050786, false, true, false, null)]
    protected V4_AuditTrailSecPermission_Environment _Permissions;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrail_Environment_SecurityUserName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050781, false, false, false, null)]
    protected Environment _SecurityUserName;

    public new Environment Header
    {
      [param: In] set
      {
        this.PropertySet(nameof (Header), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Header));
      }
    }

    public V4_AuditTrailSecPermission_Environment Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (V4_AuditTrailSecPermission_Environment) this.PropertyGet(nameof (Permissions));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment SecurityUserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SecurityUserName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SecurityUserName));
      }
    }
  }
}
