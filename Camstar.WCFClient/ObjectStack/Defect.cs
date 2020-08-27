// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Defect
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
  public class Defect : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Defect_Qty2Inspected")]
    protected Primitive<double> _Qty2Inspected;
    [DataMember(EmitDefaultValue = false, Name = "Defect_ServiceDetails")]
    protected DefectDetail[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "Defect_IssueActualsHistory")]
    protected Camstar.WCF.ObjectStack.IssueActualsHistory[] _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "Defect_ContainersInspected")]
    protected Primitive<int> _ContainersInspected;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "Defect_QtyInspected")]
    protected Primitive<double> _QtyInspected;
    [DataMember(EmitDefaultValue = false, Name = "Defect_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "Defect_ContainerLevelInspected")]
    protected NamedObjectRef _ContainerLevelInspected;

    public override bool Equals(object obj)
    {
      return obj is Defect && object.Equals((object) this._Qty2Inspected, (object) ((Defect) obj)._Qty2Inspected) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((Defect) obj)._ServiceDetails) && this.CompareArrays((Array) this._IssueActualsHistory, (Array) ((Defect) obj)._IssueActualsHistory)) && (object.Equals((object) this._ContainersInspected, (object) ((Defect) obj)._ContainersInspected) && object.Equals((object) this._Resource, (object) ((Defect) obj)._Resource) && (object.Equals((object) this._QtyInspected, (object) ((Defect) obj)._QtyInspected) && object.Equals((object) this._ChargeToStep, (object) ((Defect) obj)._ChargeToStep))) && object.Equals((object) this._ContainerLevelInspected, (object) ((Defect) obj)._ContainerLevelInspected) && base.Equals(obj);
    }

    public Primitive<double> Qty2Inspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Inspected), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Inspected));
      }
    }

    public DefectDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DefectDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Camstar.WCF.ObjectStack.IssueActualsHistory[] IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.IssueActualsHistory[]) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Primitive<int> ContainersInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainersInspected), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ContainersInspected));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public Primitive<double> QtyInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyInspected), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyInspected));
      }
    }

    public NamedSubentityRef ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public NamedObjectRef ContainerLevelInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelInspected), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerLevelInspected));
      }
    }
  }
}
