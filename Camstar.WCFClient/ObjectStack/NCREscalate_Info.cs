// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCREscalate_Info
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
  public class NCREscalate_Info : NCRTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_CreateEvent")]
    protected CreateEvent_Info _CreateEvent;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_EventDetail")]
    protected EventDetail_Info _EventDetail;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Failures")]
    protected Info _Failures;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_ResolutionCode")]
    protected Info _ResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_CauseCode")]
    protected Info _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_BriefDescription")]
    protected Info _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Submit")]
    protected Info _Submit;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_PlaceOnHold")]
    protected Info _PlaceOnHold;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_OriginalStartDateGMT")]
    protected Info _OriginalStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_OriginalStartDate")]
    protected Info _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_OccurrenceDateGMT")]
    protected Info _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_OccurrenceDate")]
    protected Info _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_WorkflowName")]
    protected Info _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_PreventiveActionComments")]
    protected Info _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_NonconformanceNumber")]
    protected Info _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Factory")]
    protected new Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_UOMName")]
    protected Info _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_CauseCodeName")]
    protected Info _CauseCodeName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_FailureInvestigationComments")]
    protected Info _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_WorkflowRev")]
    protected Info _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Initiator")]
    protected Info _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_ProductRev")]
    protected Info _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_OperationName")]
    protected Info _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_DiscoveryArea")]
    protected Info _DiscoveryArea;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_CorrectiveActionComments")]
    protected Info _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Info_Lot")]
    protected Info _Lot;

    public CreateEvent_Info CreateEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateEvent), (object) value);
      }
      get
      {
        return (CreateEvent_Info) this.PropertyGet(nameof (CreateEvent));
      }
    }

    public Info ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public EventDetail_Info EventDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDetail), (object) value);
      }
      get
      {
        return (EventDetail_Info) this.PropertyGet(nameof (EventDetail));
      }
    }

    public Info Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Failures));
      }
    }

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info ResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolutionCode));
      }
    }

    public Info CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CauseCode));
      }
    }

    public Info PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
      }
    }

    public Info BriefDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (BriefDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BriefDescription));
      }
    }

    public Info SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public Info Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Submit));
      }
    }

    public Info PlaceOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlaceOnHold), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlaceOnHold));
      }
    }

    public Info OriginalStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalStartDateGMT));
      }
    }

    public Info OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Info OccurrenceDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OccurrenceDateGMT));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info OccurrenceDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OccurrenceDate));
      }
    }

    public Info WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowName));
      }
    }

    public Info PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }

    public Info NonconformanceNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NonconformanceNumber));
      }
    }

    public new Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public Info UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOMName));
      }
    }

    public Info CauseCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCodeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CauseCodeName));
      }
    }

    public Info FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public Info ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductName));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info WorkflowRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowRev));
      }
    }

    public Info Initiator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Initiator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Initiator));
      }
    }

    public Info ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Info OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationName));
      }
    }

    public Info DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DiscoveryArea));
      }
    }

    public Info CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Info Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Lot));
      }
    }
  }
}
