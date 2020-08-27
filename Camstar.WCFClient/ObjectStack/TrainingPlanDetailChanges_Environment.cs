// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingPlanDetailChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (TrainingReqPlanDetailChanges_Environment))]
  [KnownType(typeof (SubTrainingPlanDetailChanges_Environment))]
  [Serializable]
  public class TrainingPlanDetailChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Environment_Parent")]
    [Metadata("A training plan defines a schedule of training requirements (certifications) and target dates for when employees should be trained on the listed requirement.  Training plans can also be used as components in larger training plans.", "TrainingPlan", false, false, false, "NamedObjectRef", 1050487, false, false, false, null)]
    protected new Environment _Parent;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Environment_ObjectToChange")]
    [Metadata("Training plan detail record composed of a training requirement or another training plan, along with a target date for completing that training.", "TrainingPlanDetail", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Environment_ListItemToChange")]
    [Metadata("Training Plan Detail", "TrainingPlanDetailChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050486, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Environment_TargetTrainingDate")]
    protected Environment _TargetTrainingDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public new Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment TargetTrainingDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetTrainingDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetTrainingDate));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
