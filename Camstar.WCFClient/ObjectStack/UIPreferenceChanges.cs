// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPreferenceChanges
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
  public class UIPreferenceChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceChanges_UIPrefFieldDefs")]
    protected UIPrefFieldDefChanges[] _UIPrefFieldDefs;
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIPreferenceChanges && this.CompareArrays((Array) this._UIPrefFieldDefs, (Array) ((UIPreferenceChanges) obj)._UIPrefFieldDefs) && (object.Equals((object) this._ObjectToChange, (object) ((UIPreferenceChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((UIPreferenceChanges) obj)._Name)) && base.Equals(obj);
    }

    public UIPrefFieldDefChanges[] UIPrefFieldDefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPrefFieldDefs), (object) value);
      }
      get
      {
        return (UIPrefFieldDefChanges[]) this.PropertyGet(nameof (UIPrefFieldDefs));
      }
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
