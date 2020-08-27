// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionDefinitionChanges
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
  public class PermissionDefinitionChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_DisplayMode")]
    protected Enumeration<PermissionDisplayModeEnum, int> _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_ServicePermission")]
    protected Primitive<bool> _ServicePermission;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_PagePermission")]
    protected Primitive<bool> _PagePermission;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is PermissionDefinitionChanges && object.Equals((object) this._DisplayMode, (object) ((PermissionDefinitionChanges) obj)._DisplayMode) && (object.Equals((object) this._ObjectToChange, (object) ((PermissionDefinitionChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((PermissionDefinitionChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ServicePermission, (object) ((PermissionDefinitionChanges) obj)._ServicePermission) && object.Equals((object) this._PagePermission, (object) ((PermissionDefinitionChanges) obj)._PagePermission) && object.Equals((object) this._IsFrozen, (object) ((PermissionDefinitionChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public Enumeration<PermissionDisplayModeEnum, int> DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Enumeration<PermissionDisplayModeEnum, int>) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<bool> ServicePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServicePermission), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ServicePermission));
      }
    }

    public Primitive<bool> PagePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (PagePermission), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PagePermission));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
