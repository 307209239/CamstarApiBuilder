// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionDefinitionChanges_Info
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
  public class PermissionDefinitionChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Info_DisplayMode")]
    protected Info _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Info_ServicePermission")]
    protected Info _ServicePermission;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Info_PagePermission")]
    protected Info _PagePermission;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDefinitionChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayMode));
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

    public Info ServicePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServicePermission), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServicePermission));
      }
    }

    public Info PagePermission
    {
      [param: In] set
      {
        this.PropertySet(nameof (PagePermission), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PagePermission));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
