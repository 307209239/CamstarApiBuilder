// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCreate
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
  public class NCRCreate : NCRTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_ServiceDetails")]
    protected NCRDefectDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_NCRFailureType")]
    protected NamedObjectRef _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_NCRFailureCodeGroup")]
    protected NamedObjectRef _NCRFailureCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_NonconformanceReport")]
    protected new NamedObjectRef _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_NCRFailureCodes")]
    protected NamedObjectRef[] _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_RelatedNonconformance")]
    protected NamedObjectRef _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_IssueActualsHistory")]
    protected Camstar.WCF.ObjectStack.IssueActualsHistory[] _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_NCRComment")]
    protected Primitive<string> _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_NonconformanceName")]
    protected Primitive<string> _NonconformanceName;

    public override bool Equals(object obj)
    {
      return obj is NCRCreate && this.CompareArrays((Array) this._ServiceDetails, (Array) ((NCRCreate) obj)._ServiceDetails) && (object.Equals((object) this._ChargeToStep, (object) ((NCRCreate) obj)._ChargeToStep) && object.Equals((object) this._NCRFailureType, (object) ((NCRCreate) obj)._NCRFailureType)) && (object.Equals((object) this._NCRFailureCodeGroup, (object) ((NCRCreate) obj)._NCRFailureCodeGroup) && object.Equals((object) this._Task, (object) ((NCRCreate) obj)._Task) && (object.Equals((object) this._NonconformanceReport, (object) ((NCRCreate) obj)._NonconformanceReport) && this.CompareArrays((Array) this._NCRFailureCodes, (Array) ((NCRCreate) obj)._NCRFailureCodes))) && (object.Equals((object) this._RelatedNonconformance, (object) ((NCRCreate) obj)._RelatedNonconformance) && object.Equals((object) this._PrintQueue, (object) ((NCRCreate) obj)._PrintQueue) && (this.CompareArrays((Array) this._IssueActualsHistory, (Array) ((NCRCreate) obj)._IssueActualsHistory) && object.Equals((object) this._Container, (object) ((NCRCreate) obj)._Container)) && (object.Equals((object) this._Factory, (object) ((NCRCreate) obj)._Factory) && object.Equals((object) this._NCRComment, (object) ((NCRCreate) obj)._NCRComment) && object.Equals((object) this._NonconformanceName, (object) ((NCRCreate) obj)._NonconformanceName))) && base.Equals(obj);
    }

    public NCRDefectDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (NCRDefectDetails[]) this.PropertyGet(nameof (ServiceDetails));
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

    public NamedObjectRef NCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRFailureType));
      }
    }

    public NamedObjectRef NCRFailureCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodeGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRFailureCodeGroup));
      }
    }

    public NamedSubentityRef Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Task));
      }
    }

    public new NamedObjectRef NonconformanceReport
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

    public NamedObjectRef[] NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public NamedObjectRef RelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelatedNonconformance), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RelatedNonconformance));
      }
    }

    public new NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
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

    public new NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }

    public Primitive<string> NCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRComment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NCRComment));
      }
    }

    public Primitive<string> NonconformanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NonconformanceName));
      }
    }
  }
}
