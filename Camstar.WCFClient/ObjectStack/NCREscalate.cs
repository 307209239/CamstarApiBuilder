// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCREscalate
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
  public class NCREscalate : NCRTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_CreateEvent")]
    protected CreateEvent _CreateEvent;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_EventDetail")]
    protected EventDetail _EventDetail;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Failures")]
    protected NamedObjectRef[] _Failures;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_ResolutionCode")]
    protected NamedObjectRef _ResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_CauseCode")]
    protected NamedObjectRef _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_BriefDescription")]
    protected Primitive<string> _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Submit")]
    protected Primitive<bool> _Submit;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_PlaceOnHold")]
    protected Primitive<bool> _PlaceOnHold;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_OriginalStartDateGMT")]
    protected Primitive<DateTime> _OriginalStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_OriginalStartDate")]
    protected Primitive<DateTime> _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_OccurrenceDateGMT")]
    protected Primitive<DateTime> _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_OccurrenceDate")]
    protected Primitive<DateTime> _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_WorkflowName")]
    protected Primitive<string> _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_PreventiveActionComments")]
    protected Primitive<string> _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_NonconformanceNumber")]
    protected Primitive<string> _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_CauseCodeName")]
    protected Primitive<string> _CauseCodeName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_FailureInvestigationComments")]
    protected Primitive<string> _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_WorkflowRev")]
    protected Primitive<string> _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Initiator")]
    protected NamedObjectRef _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_ProductRev")]
    protected Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_OperationName")]
    protected Primitive<string> _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_DiscoveryArea")]
    protected Primitive<string> _DiscoveryArea;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_CorrectiveActionComments")]
    protected Primitive<string> _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Lot")]
    protected Primitive<string> _Lot;

    public override bool Equals(object obj)
    {
      return obj is NCREscalate && object.Equals((object) this._CreateEvent, (object) ((NCREscalate) obj)._CreateEvent) && (object.Equals((object) this._ChargeToStep, (object) ((NCREscalate) obj)._ChargeToStep) && object.Equals((object) this._EventDetail, (object) ((NCREscalate) obj)._EventDetail)) && (this.CompareArrays((Array) this._Failures, (Array) ((NCREscalate) obj)._Failures) && object.Equals((object) this._Comments, (object) ((NCREscalate) obj)._Comments) && (object.Equals((object) this._ResolutionCode, (object) ((NCREscalate) obj)._ResolutionCode) && object.Equals((object) this._CauseCode, (object) ((NCREscalate) obj)._CauseCode))) && (object.Equals((object) this._PriorityLevel, (object) ((NCREscalate) obj)._PriorityLevel) && object.Equals((object) this._Classification, (object) ((NCREscalate) obj)._Classification) && (object.Equals((object) this._BriefDescription, (object) ((NCREscalate) obj)._BriefDescription) && object.Equals((object) this._SubClassification, (object) ((NCREscalate) obj)._SubClassification)) && (object.Equals((object) this._Organization, (object) ((NCREscalate) obj)._Organization) && object.Equals((object) this._Submit, (object) ((NCREscalate) obj)._Submit) && (object.Equals((object) this._PlaceOnHold, (object) ((NCREscalate) obj)._PlaceOnHold) && object.Equals((object) this._OriginalStartDateGMT, (object) ((NCREscalate) obj)._OriginalStartDateGMT)))) && (object.Equals((object) this._OriginalStartDate, (object) ((NCREscalate) obj)._OriginalStartDate) && object.Equals((object) this._OccurrenceDateGMT, (object) ((NCREscalate) obj)._OccurrenceDateGMT) && (object.Equals((object) this._Container, (object) ((NCREscalate) obj)._Container) && object.Equals((object) this._OccurrenceDate, (object) ((NCREscalate) obj)._OccurrenceDate)) && (object.Equals((object) this._WorkflowName, (object) ((NCREscalate) obj)._WorkflowName) && object.Equals((object) this._PreventiveActionComments, (object) ((NCREscalate) obj)._PreventiveActionComments) && (object.Equals((object) this._Qty, (object) ((NCREscalate) obj)._Qty) && object.Equals((object) this._NonconformanceNumber, (object) ((NCREscalate) obj)._NonconformanceNumber))) && (object.Equals((object) this._Factory, (object) ((NCREscalate) obj)._Factory) && object.Equals((object) this._UOMName, (object) ((NCREscalate) obj)._UOMName) && (object.Equals((object) this._CauseCodeName, (object) ((NCREscalate) obj)._CauseCodeName) && object.Equals((object) this._FailureInvestigationComments, (object) ((NCREscalate) obj)._FailureInvestigationComments)) && (object.Equals((object) this._ProductName, (object) ((NCREscalate) obj)._ProductName) && object.Equals((object) this._Description, (object) ((NCREscalate) obj)._Description) && (object.Equals((object) this._WorkflowRev, (object) ((NCREscalate) obj)._WorkflowRev) && object.Equals((object) this._Initiator, (object) ((NCREscalate) obj)._Initiator))))) && (object.Equals((object) this._ProductRev, (object) ((NCREscalate) obj)._ProductRev) && object.Equals((object) this._OperationName, (object) ((NCREscalate) obj)._OperationName) && (object.Equals((object) this._DiscoveryArea, (object) ((NCREscalate) obj)._DiscoveryArea) && object.Equals((object) this._CorrectiveActionComments, (object) ((NCREscalate) obj)._CorrectiveActionComments)) && object.Equals((object) this._Lot, (object) ((NCREscalate) obj)._Lot)) && base.Equals(obj);
    }

    public CreateEvent CreateEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateEvent), (object) value);
      }
      get
      {
        return (CreateEvent) this.PropertyGet(nameof (CreateEvent));
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

    public EventDetail EventDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDetail), (object) value);
      }
      get
      {
        return (EventDetail) this.PropertyGet(nameof (EventDetail));
      }
    }

    public NamedObjectRef[] Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Failures));
      }
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public NamedObjectRef ResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResolutionCode));
      }
    }

    public NamedObjectRef CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CauseCode));
      }
    }

    public NamedObjectRef PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public Primitive<string> BriefDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (BriefDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BriefDescription));
      }
    }

    public NamedObjectRef SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassification));
      }
    }

    public NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public Primitive<bool> Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Submit));
      }
    }

    public Primitive<bool> PlaceOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlaceOnHold), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PlaceOnHold));
      }
    }

    public Primitive<DateTime> OriginalStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OriginalStartDateGMT));
      }
    }

    public Primitive<DateTime> OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Primitive<DateTime> OccurrenceDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OccurrenceDateGMT));
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

    public Primitive<DateTime> OccurrenceDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OccurrenceDate));
      }
    }

    public Primitive<string> WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowName));
      }
    }

    public Primitive<string> PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public Primitive<string> NonconformanceNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NonconformanceNumber));
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

    public Primitive<string> UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOMName));
      }
    }

    public Primitive<string> CauseCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCodeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CauseCodeName));
      }
    }

    public Primitive<string> FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public Primitive<string> ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductName));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<string> WorkflowRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowRev));
      }
    }

    public NamedObjectRef Initiator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Initiator), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Initiator));
      }
    }

    public Primitive<string> ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Primitive<string> OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OperationName));
      }
    }

    public Primitive<string> DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DiscoveryArea));
      }
    }

    public Primitive<string> CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Primitive<string> Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Lot));
      }
    }
  }
}
