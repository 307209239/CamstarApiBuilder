// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RolePermissionChanges_Info
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
  public class RolePermissionChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Info_PermissionType")]
    protected Info _PermissionType;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Info_Modes")]
    protected Info _Modes;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Info_ObjectMetaId")]
    protected Info _ObjectMetaId;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Info_ObjectInstanceIdString")]
    protected Info _ObjectInstanceIdString;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

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

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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

    public Info Modes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Modes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Modes));
      }
    }

    public Info ObjectMetaId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectMetaId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectMetaId));
      }
    }

    public Info ObjectInstanceIdString
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceIdString), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceIdString));
      }
    }

    public Info ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }
  }
}
