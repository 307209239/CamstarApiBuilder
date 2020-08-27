// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionDefinitionChanges_Environment
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
  public class PermissionDefinitionChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("PermissionDisplayMode", "PermissionDisplayModeEnum", false, false, false, "Integer", 1050521, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Environment_DisplayMode")]
    protected Environment _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Environment_ObjectToChange")]
    [Metadata("Permission Definition", "PermissionDefinition", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Environment_ListItemToChange")]
    [Metadata("Permission Definition", "PermissionDefinitionChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052817, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Environment_ServicePermission")]
    protected Environment _ServicePermission;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052816, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Environment_PagePermission")]
    protected Environment _PagePermission;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayMode));
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

    public Environment ServicePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServicePermission), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServicePermission));
      }
    }

    public Environment PagePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (PagePermission), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PagePermission));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
