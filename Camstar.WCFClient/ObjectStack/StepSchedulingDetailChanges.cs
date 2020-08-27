// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StepSchedulingDetailChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SubWFStepSchedDetailChanges))]
  [KnownType(typeof (SpecStepSchedulingDetailChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class StepSchedulingDetailChanges : SchedulingDetailChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_ForwardYield")]
    protected Primitive<double> _ForwardYield;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_NormalCycleTime")]
    protected new Primitive<double> _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_FastCycleTime")]
    protected new Primitive<double> _FastCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_ForwardCycleTime")]
    protected Primitive<double> _ForwardCycleTime;

    public override bool Equals(object obj)
    {
      return obj is StepSchedulingDetailChanges && object.Equals((object) this._ListItemToChange, (object) ((StepSchedulingDetailChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((StepSchedulingDetailChanges) obj)._ObjectToChange) && object.Equals((object) this._ForwardYield, (object) ((StepSchedulingDetailChanges) obj)._ForwardYield)) && (object.Equals((object) this._NormalCycleTime, (object) ((StepSchedulingDetailChanges) obj)._NormalCycleTime) && object.Equals((object) this._FastCycleTime, (object) ((StepSchedulingDetailChanges) obj)._FastCycleTime) && object.Equals((object) this._ForwardCycleTime, (object) ((StepSchedulingDetailChanges) obj)._ForwardCycleTime)) && base.Equals(obj);
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

    public Primitive<double> ForwardYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForwardYield), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ForwardYield));
      }
    }

    public new Primitive<double> NormalCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (NormalCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NormalCycleTime));
      }
    }

    public new Primitive<double> FastCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (FastCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (FastCycleTime));
      }
    }

    public Primitive<double> ForwardCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForwardCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ForwardCycleTime));
      }
    }
  }
}
