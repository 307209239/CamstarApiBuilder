// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingPlanChanges
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
  public class TrainingPlanChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanChanges_Details")]
    protected TrainingPlanDetailChanges[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TrainingPlanChanges && this.CompareArrays((Array) this._Details, (Array) ((TrainingPlanChanges) obj)._Details) && (object.Equals((object) this._ObjectToChange, (object) ((TrainingPlanChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((TrainingPlanChanges) obj)._Name)) && base.Equals(obj);
    }

    public TrainingPlanDetailChanges[] Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (TrainingPlanDetailChanges[]) this.PropertyGet(nameof (Details));
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
