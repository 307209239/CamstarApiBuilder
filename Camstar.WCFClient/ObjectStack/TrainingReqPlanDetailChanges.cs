// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingReqPlanDetailChanges
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
  public class TrainingReqPlanDetailChanges : TrainingPlanDetailChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqPlanDetailChanges_TrainingRequirement")]
    protected RevisionedObjectRef _TrainingRequirement;
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqPlanDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is TrainingReqPlanDetailChanges && object.Equals((object) this._TrainingRequirement, (object) ((TrainingReqPlanDetailChanges) obj)._TrainingRequirement) && object.Equals((object) this._ObjectToChange, (object) ((TrainingReqPlanDetailChanges) obj)._ObjectToChange) && base.Equals(obj);
    }

    public RevisionedObjectRef TrainingRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirement), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TrainingRequirement));
      }
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
  }
}
