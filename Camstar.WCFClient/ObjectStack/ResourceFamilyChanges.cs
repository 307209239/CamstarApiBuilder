// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceFamilyChanges
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
  public class ResourceFamilyChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyChanges_UIPreference")]
    protected NamedObjectRef _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ResourceFamilyChanges && object.Equals((object) this._UIPreference, (object) ((ResourceFamilyChanges) obj)._UIPreference) && (object.Equals((object) this._ObjectToChange, (object) ((ResourceFamilyChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((ResourceFamilyChanges) obj)._Name)) && base.Equals(obj);
    }

    public NamedObjectRef UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UIPreference));
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
