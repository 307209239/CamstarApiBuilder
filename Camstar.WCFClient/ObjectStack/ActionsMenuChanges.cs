// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuChanges
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
  public class ActionsMenuChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuChanges_MenuItems")]
    protected ActionsMenuItemChanges[] _MenuItems;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActionsMenuChanges && object.Equals((object) this._ObjectToChange, (object) ((ActionsMenuChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._MenuItems, (Array) ((ActionsMenuChanges) obj)._MenuItems) && object.Equals((object) this._Name, (object) ((ActionsMenuChanges) obj)._Name)) && base.Equals(obj);
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

    public ActionsMenuItemChanges[] MenuItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItems), (object) value);
      }
      get
      {
        return (ActionsMenuItemChanges[]) this.PropertyGet(nameof (MenuItems));
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
