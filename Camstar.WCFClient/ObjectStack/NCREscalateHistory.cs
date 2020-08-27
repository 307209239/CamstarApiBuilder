// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCREscalateHistory
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
  public class NCREscalateHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_NCRFailureCodes")]
    protected NamedObjectRef[] _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_EscalatedEvent")]
    protected NamedObjectRef _EscalatedEvent;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_NCRResolutionCode")]
    protected NamedObjectRef _NCRResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_NCRComment")]
    protected Primitive<string> _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_NonconformanceReport")]
    protected NamedObjectRef _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_NCRCauseCode")]
    protected NamedObjectRef _NCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_EscalationDateGMT")]
    protected Primitive<DateTime> _EscalationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_EscalationDate")]
    protected Primitive<DateTime> _EscalationDate;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_EscalatedBy")]
    protected NamedObjectRef _EscalatedBy;

    public override bool Equals(object obj)
    {
      return obj is NCREscalateHistory && this.CompareArrays((Array) this._NCRFailureCodes, (Array) ((NCREscalateHistory) obj)._NCRFailureCodes) && (object.Equals((object) this._ExportImportKey, (object) ((NCREscalateHistory) obj)._ExportImportKey) && object.Equals((object) this._EscalatedEvent, (object) ((NCREscalateHistory) obj)._EscalatedEvent)) && (object.Equals((object) this._NCRResolutionCode, (object) ((NCREscalateHistory) obj)._NCRResolutionCode) && object.Equals((object) this._NCRComment, (object) ((NCREscalateHistory) obj)._NCRComment) && (object.Equals((object) this._QualityObject, (object) ((NCREscalateHistory) obj)._QualityObject) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((NCREscalateHistory) obj)._HistoryDetails))) && (object.Equals((object) this._NonconformanceReport, (object) ((NCREscalateHistory) obj)._NonconformanceReport) && object.Equals((object) this._NCRCauseCode, (object) ((NCREscalateHistory) obj)._NCRCauseCode) && (object.Equals((object) this._ChargeToStep, (object) ((NCREscalateHistory) obj)._ChargeToStep) && object.Equals((object) this._PriorityLevel, (object) ((NCREscalateHistory) obj)._PriorityLevel)) && (object.Equals((object) this._Organization, (object) ((NCREscalateHistory) obj)._Organization) && object.Equals((object) this._SubClassification, (object) ((NCREscalateHistory) obj)._SubClassification) && (object.Equals((object) this._Classification, (object) ((NCREscalateHistory) obj)._Classification) && object.Equals((object) this._HistoryId, (object) ((NCREscalateHistory) obj)._HistoryId)))) && (object.Equals((object) this._EscalationDateGMT, (object) ((NCREscalateHistory) obj)._EscalationDateGMT) && object.Equals((object) this._EscalationDate, (object) ((NCREscalateHistory) obj)._EscalationDate) && (object.Equals((object) this._Container, (object) ((NCREscalateHistory) obj)._Container) && object.Equals((object) this._EscalatedBy, (object) ((NCREscalateHistory) obj)._EscalatedBy))) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public NamedObjectRef EscalatedEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalatedEvent), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EscalatedEvent));
      }
    }

    public NamedObjectRef NCRResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRResolutionCode));
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

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
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

    public NamedObjectRef NCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRCauseCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRCauseCode));
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<DateTime> EscalationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EscalationDateGMT));
      }
    }

    public Primitive<DateTime> EscalationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EscalationDate));
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

    public NamedObjectRef EscalatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalatedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EscalatedBy));
      }
    }
  }
}
