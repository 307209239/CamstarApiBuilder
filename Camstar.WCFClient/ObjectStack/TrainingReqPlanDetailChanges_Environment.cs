// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingReqPlanDetailChanges_Environment
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
  public class TrainingReqPlanDetailChanges_Environment : TrainingPlanDetailChanges_Environment
  {
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirement", false, true, false, "RevisionedObjectRef", 1050485, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqPlanDetailChanges_Environment_TrainingRequirement")]
    protected Environment _TrainingRequirement;
    [Metadata("Training plan detail record composed of a training requirement, along with a target date for completing training for that requirement.", "TrainingReqPlanDetail", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqPlanDetailChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public Environment TrainingRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingRequirement));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
