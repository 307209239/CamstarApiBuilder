// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuSubMenuChanges
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
  public class PortalMenuSubMenuChanges : PortalMenuItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuSubMenuChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuSubMenuChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuSubMenuChanges_MenuDefinition")]
    protected NamedObjectRef _MenuDefinition;

    public override bool Equals(object obj)
    {
      return obj is PortalMenuSubMenuChanges && object.Equals((object) this._ObjectToChange, (object) ((PortalMenuSubMenuChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((PortalMenuSubMenuChanges) obj)._ListItemToChange) && object.Equals((object) this._MenuDefinition, (object) ((PortalMenuSubMenuChanges) obj)._MenuDefinition)) && base.Equals(obj);
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

    public NamedObjectRef MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MenuDefinition));
      }
    }
  }
}
