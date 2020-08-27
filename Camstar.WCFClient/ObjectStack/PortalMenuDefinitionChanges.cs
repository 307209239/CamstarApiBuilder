// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuDefinitionChanges
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
  public class PortalMenuDefinitionChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_MenuItems")]
    protected PortalMenuItemChanges[] _MenuItems;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_PortalTab")]
    protected NamedObjectRef _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_PortalTabOption")]
    protected Enumeration<PortalTabOptionEnum, int> _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is PortalMenuDefinitionChanges && object.Equals((object) this._ObjectToChange, (object) ((PortalMenuDefinitionChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._MenuItems, (Array) ((PortalMenuDefinitionChanges) obj)._MenuItems) && object.Equals((object) this._PortalTab, (object) ((PortalMenuDefinitionChanges) obj)._PortalTab)) && (object.Equals((object) this._PortalTabOption, (object) ((PortalMenuDefinitionChanges) obj)._PortalTabOption) && object.Equals((object) this._Name, (object) ((PortalMenuDefinitionChanges) obj)._Name)) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public PortalMenuItemChanges[] MenuItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItems), (object) value);
      }
      get
      {
        return (PortalMenuItemChanges[]) this.PropertyGet(nameof (MenuItems));
      }
    }

    public NamedObjectRef PortalTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTab), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PortalTab));
      }
    }

    public Enumeration<PortalTabOptionEnum, int> PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Enumeration<PortalTabOptionEnum, int>) this.PropertyGet(nameof (PortalTabOption));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
