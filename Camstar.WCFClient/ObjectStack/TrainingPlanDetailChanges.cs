// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingPlanDetailChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SubTrainingPlanDetailChanges))]
  [KnownType(typeof (TrainingReqPlanDetailChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class TrainingPlanDetailChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_Parent")]
    protected NamedObjectRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_TargetTrainingDate")]
    protected Primitive<DateTime> _TargetTrainingDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingPlanDetailChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is TrainingPlanDetailChanges && object.Equals((object) this._Parent, (object) ((TrainingPlanDetailChanges) obj)._Parent) && (object.Equals((object) this._ObjectToChange, (object) ((TrainingPlanDetailChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((TrainingPlanDetailChanges) obj)._ListItemToChange)) && (object.Equals((object) this._TargetTrainingDate, (object) ((TrainingPlanDetailChanges) obj)._TargetTrainingDate) && object.Equals((object) this._IsFrozen, (object) ((TrainingPlanDetailChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public NamedObjectRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Parent));
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

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<DateTime> TargetTrainingDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetTrainingDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TargetTrainingDate));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
