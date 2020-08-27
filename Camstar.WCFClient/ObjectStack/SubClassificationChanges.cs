// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubClassificationChanges
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
  public class SubClassificationChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SubClassificationChanges_EventSubClassification")]
    protected Enumeration<SubClassificationEnum, int> _EventSubClassification;
    [DataMember(EmitDefaultValue = false, Name = "SubClassificationChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubClassificationChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is SubClassificationChanges && object.Equals((object) this._EventSubClassification, (object) ((SubClassificationChanges) obj)._EventSubClassification) && (object.Equals((object) this._ObjectToChange, (object) ((SubClassificationChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((SubClassificationChanges) obj)._Name)) && base.Equals(obj);
    }

    public Enumeration<SubClassificationEnum, int> EventSubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventSubClassification), (object) value);
      }
      get
      {
        return (Enumeration<SubClassificationEnum, int>) this.PropertyGet(nameof (EventSubClassification));
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
