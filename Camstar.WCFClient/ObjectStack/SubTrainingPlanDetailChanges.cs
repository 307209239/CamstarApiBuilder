// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubTrainingPlanDetailChanges
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
  public class SubTrainingPlanDetailChanges : TrainingPlanDetailChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SubTrainingPlanDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubTrainingPlanDetailChanges_TrainingPlan")]
    protected NamedObjectRef _TrainingPlan;

    public override bool Equals(object obj)
    {
      return obj is SubTrainingPlanDetailChanges && object.Equals((object) this._ObjectToChange, (object) ((SubTrainingPlanDetailChanges) obj)._ObjectToChange) && object.Equals((object) this._TrainingPlan, (object) ((SubTrainingPlanDetailChanges) obj)._TrainingPlan) && base.Equals(obj);
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

    public NamedObjectRef TrainingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingPlan), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingPlan));
      }
    }
  }
}
