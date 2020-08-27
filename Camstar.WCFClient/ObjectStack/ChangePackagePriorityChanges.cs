// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackagePriorityChanges
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
  public class ChangePackagePriorityChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackagePriorityChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackagePriorityChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackagePriorityChanges_RelativePriority")]
    protected Primitive<int> _RelativePriority;

    public override bool Equals(object obj)
    {
      return obj is ChangePackagePriorityChanges && object.Equals((object) this._ObjectToChange, (object) ((ChangePackagePriorityChanges) obj)._ObjectToChange) && (object.Equals((object) this._Name, (object) ((ChangePackagePriorityChanges) obj)._Name) && object.Equals((object) this._RelativePriority, (object) ((ChangePackagePriorityChanges) obj)._RelativePriority)) && base.Equals(obj);
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

    public Primitive<int> RelativePriority
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelativePriority), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RelativePriority));
      }
    }
  }
}
