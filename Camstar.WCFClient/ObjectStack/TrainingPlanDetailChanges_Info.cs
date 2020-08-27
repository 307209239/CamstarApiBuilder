// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingPlanDetailChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (TrainingReqPlanDetailChanges_Info))]
  [KnownType(typeof (SubTrainingPlanDetailChanges_Info))]
  [Serializable]
  public class TrainingPlanDetailChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Info_Parent")]
    protected new Info _Parent;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Info_TargetTrainingDate")]
    protected Info _TargetTrainingDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Parent));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info TargetTrainingDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetTrainingDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetTrainingDate));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
