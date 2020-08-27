// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FilterTagChanges
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
  public class FilterTagChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "FilterTagChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagChanges_InstanceID")]
    protected NamedObjectRef _InstanceID;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is FilterTagChanges && object.Equals((object) this._ObjectToChange, (object) ((FilterTagChanges) obj)._ObjectToChange) && (object.Equals((object) this._InstanceID, (object) ((FilterTagChanges) obj)._InstanceID) && object.Equals((object) this._Name, (object) ((FilterTagChanges) obj)._Name)) && base.Equals(obj);
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

    public NamedObjectRef InstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceID), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (InstanceID));
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
