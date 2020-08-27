// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RolePermissionsMaint_Info
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
  public class RolePermissionsMaint_Info : NamedDataObjectMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Info_PermissionType")]
    protected Info _PermissionType;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Info_ObjectChanges")]
    protected RoleChangesWithPermissions_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Info_PermissionMode")]
    protected Info _PermissionMode;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public Info PermissionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PermissionType));
      }
    }

    public RoleChangesWithPermissions_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RoleChangesWithPermissions_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Info PermissionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PermissionMode));
      }
    }
  }
}
