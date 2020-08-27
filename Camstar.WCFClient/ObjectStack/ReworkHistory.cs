// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (TransferReworkHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ReworkHistory : MoveHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkHistory_ReEntryStep")]
    protected NamedSubentityRef _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkHistory_CumulativeReworkStepCount")]
    protected Primitive<int> _CumulativeReworkStepCount;
    [DataMember(EmitDefaultValue = false, Name = "ReworkHistory_ReworkReason")]
    protected NamedObjectRef _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ReworkHistory_EndReworkStep")]
    protected NamedSubentityRef _EndReworkStep;

    public override bool Equals(object obj)
    {
      return obj is ReworkHistory && object.Equals((object) this._ReEntryStep, (object) ((ReworkHistory) obj)._ReEntryStep) && (object.Equals((object) this._CumulativeReworkStepCount, (object) ((ReworkHistory) obj)._CumulativeReworkStepCount) && object.Equals((object) this._ReworkReason, (object) ((ReworkHistory) obj)._ReworkReason)) && object.Equals((object) this._EndReworkStep, (object) ((ReworkHistory) obj)._EndReworkStep) && base.Equals(obj);
    }

    public NamedSubentityRef ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public Primitive<int> CumulativeReworkStepCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CumulativeReworkStepCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CumulativeReworkStepCount));
      }
    }

    public NamedObjectRef ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public NamedSubentityRef EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (EndReworkStep));
      }
    }
  }
}
