// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ClassificationChanges
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
  public class ClassificationChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ClassificationChanges_EventClassification")]
    protected Enumeration<ClassificationEnum, int> _EventClassification;
    [DataMember(EmitDefaultValue = false, Name = "ClassificationChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ClassificationChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ClassificationChanges && object.Equals((object) this._EventClassification, (object) ((ClassificationChanges) obj)._EventClassification) && (object.Equals((object) this._ObjectToChange, (object) ((ClassificationChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((ClassificationChanges) obj)._Name)) && base.Equals(obj);
    }

    public Enumeration<ClassificationEnum, int> EventClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventClassification), (object) value);
      }
      get
      {
        return (Enumeration<ClassificationEnum, int>) this.PropertyGet(nameof (EventClassification));
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
