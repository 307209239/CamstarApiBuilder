// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RolePermissionChanges_Environment
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
  public class RolePermissionChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Environment_Name")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1051559, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Environment_DisplayName")]
    [Metadata("DisplayName", "", false, false, true, "String", 1051792, false, false, false, null)]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Environment_ObjectToChange")]
    [Metadata("A permission is a positive authorization to perform an action, for example the permission to create an object.", "RolePermission", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Environment_ListItemToChange")]
    [Metadata("A permission is a positive authorization to perform an action, for example the permission to create an object.", "RolePermissionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("RBAC Permission Type", "PermissionTypeEnum", false, false, false, "Integer", 1051556, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Environment_PermissionType")]
    protected Environment _PermissionType;
    [Metadata("RBAC Permission Mode", "", false, false, false, "Integer", 1051561, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Environment_Modes")]
    protected Environment _Modes;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1051558, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Environment_ObjectMetaId")]
    protected Environment _ObjectMetaId;
    [Metadata("Generic String", "", false, false, false, "String", 1050773, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Environment_ObjectInstanceIdString")]
    protected Environment _ObjectInstanceIdString;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051558, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment PermissionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PermissionType));
      }
    }

    public Environment Modes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Modes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Modes));
      }
    }

    public Environment ObjectMetaId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectMetaId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectMetaId));
      }
    }

    public Environment ObjectInstanceIdString
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceIdString), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceIdString));
      }
    }

    public Environment ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }
  }
}
