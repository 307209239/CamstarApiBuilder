// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_PermissionEntry_Environment
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
  public class V4_PermissionEntry_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Environment_Access")]
    [Metadata("Access", "", false, false, false, "Integer", 1049446, false, false, false, null)]
    protected Environment _Access;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Environment_ListItemToChange")]
    [Metadata("Detail permission entry for defining function security. Each entry defines the access allowed for a specific function within a given Service", "V4_PermissionEntry", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Environment_ResolvedPermission")]
    [Metadata("ResolvedPermission", "", false, false, true, "String", 1049447, false, false, false, null)]
    protected Environment _ResolvedPermission;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049819, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Environment_AccessBit")]
    protected Environment _AccessBit;
    [DataMember(EmitDefaultValue = false, Name = "V4_PermissionEntry_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;

    public Environment Access
    {
      [param: In] set
      {
        this.PropertySet(nameof (Access), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Access));
      }
    }

    public Environment ListItemToChange
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

    public Environment ResolvedPermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedPermission), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolvedPermission));
      }
    }

    public Environment AccessBit
    {
      [param: In] set
      {
        this.PropertySet(nameof (AccessBit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AccessBit));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
