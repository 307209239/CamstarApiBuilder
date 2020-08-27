// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetNCRs
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
  public class GetNCRs : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_NonconformanceReports")]
    protected Camstar.WCF.ObjectStack.NonconformanceReport[] _NonconformanceReports;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_NCRFailureCode")]
    protected NamedObjectRef _NCRFailureCode;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_NonconformanceReport")]
    protected NamedObjectRef _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_CreateDateEnd")]
    protected Primitive<DateTime> _CreateDateEnd;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_IncludeClosedNCRs")]
    protected Primitive<bool> _IncludeClosedNCRs;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_CreateDateBegin")]
    protected Primitive<DateTime> _CreateDateBegin;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Workcenter")]
    protected NamedObjectRef _Workcenter;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_ChargeToWorkflow")]
    protected RevisionedObjectRef _ChargeToWorkflow;

    public override bool Equals(object obj)
    {
      return obj is GetNCRs && this.CompareArrays((Array) this._NonconformanceReports, (Array) ((GetNCRs) obj)._NonconformanceReports) && (object.Equals((object) this._NCRFailureCode, (object) ((GetNCRs) obj)._NCRFailureCode) && object.Equals((object) this._NonconformanceReport, (object) ((GetNCRs) obj)._NonconformanceReport)) && (object.Equals((object) this._ChargeToStep, (object) ((GetNCRs) obj)._ChargeToStep) && object.Equals((object) this._CreateDateEnd, (object) ((GetNCRs) obj)._CreateDateEnd) && (object.Equals((object) this._IncludeClosedNCRs, (object) ((GetNCRs) obj)._IncludeClosedNCRs) && object.Equals((object) this._CreateDateBegin, (object) ((GetNCRs) obj)._CreateDateBegin))) && (object.Equals((object) this._Container, (object) ((GetNCRs) obj)._Container) && object.Equals((object) this._Operation, (object) ((GetNCRs) obj)._Operation) && (object.Equals((object) this._Workcenter, (object) ((GetNCRs) obj)._Workcenter) && object.Equals((object) this._ChargeToWorkflow, (object) ((GetNCRs) obj)._ChargeToWorkflow))) && base.Equals(obj);
    }

    public Camstar.WCF.ObjectStack.NonconformanceReport[] NonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReports), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.NonconformanceReport[]) this.PropertyGet(nameof (NonconformanceReports));
      }
    }

    public NamedObjectRef NCRFailureCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRFailureCode));
      }
    }

    public NamedObjectRef NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NonconformanceReport));
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

    public Primitive<DateTime> CreateDateEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateDateEnd), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreateDateEnd));
      }
    }

    public Primitive<bool> IncludeClosedNCRs
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeClosedNCRs), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeClosedNCRs));
      }
    }

    public Primitive<DateTime> CreateDateBegin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateDateBegin), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreateDateBegin));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }

    public NamedObjectRef Workcenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workcenter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Workcenter));
      }
    }

    public RevisionedObjectRef ChargeToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ChargeToWorkflow));
      }
    }
  }
}
