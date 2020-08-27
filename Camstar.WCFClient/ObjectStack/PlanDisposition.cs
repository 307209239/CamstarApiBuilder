// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanDisposition
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
  public class PlanDisposition : Plan
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanDisposition_EventLots")]
    protected SubentityRef[] _EventLots;
    [DataMember(EmitDefaultValue = false, Name = "PlanDisposition_AssignedLots")]
    protected AvailableLotDetail[] _AssignedLots;
    [DataMember(EmitDefaultValue = false, Name = "PlanDisposition_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is PlanDisposition && this.CompareArrays((Array) this._EventLots, (Array) ((PlanDisposition) obj)._EventLots) && (this.CompareArrays((Array) this._AssignedLots, (Array) ((PlanDisposition) obj)._AssignedLots) && object.Equals((object) this._Name, (object) ((PlanDisposition) obj)._Name)) && base.Equals(obj);
    }

    public SubentityRef[] EventLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLots), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (EventLots));
      }
    }

    public AvailableLotDetail[] AssignedLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedLots), (object) value);
      }
      get
      {
        return (AvailableLotDetail[]) this.PropertyGet(nameof (AssignedLots));
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
