// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEvent_Info
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
  public class UpdateEvent_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_ServiceDetail")]
    protected EventDetail_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_QualityCrossReferences")]
    protected QualityCrossReferenceDetail_Info _QualityCrossReferences;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_QualityCrossRefDetails")]
    protected QualityCrossRefDetail_Info _QualityCrossRefDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_ApprovalSheetDetails")]
    protected ApprovalSheetDetails_Info _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_ApprovalSheetTemplate")]
    protected Info _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_AssignedLots")]
    protected AvailableLotDetail_Info _AssignedLots;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_ExecuteChecklist")]
    protected ExecuteChecklist_Info _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_ActionSelectedTab")]
    protected Info _ActionSelectedTab;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Info_Submit")]
    protected Info _Submit;

    public new Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public EventDetail_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (EventDetail_Info) this.PropertyGet(nameof (ServiceDetail));
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

    public QualityCrossReferenceDetail_Info QualityCrossReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossReferences), (object) value);
      }
      get
      {
        return (QualityCrossReferenceDetail_Info) this.PropertyGet(nameof (QualityCrossReferences));
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

    public QualityCrossRefDetail_Info QualityCrossRefDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefDetails), (object) value);
      }
      get
      {
        return (QualityCrossRefDetail_Info) this.PropertyGet(nameof (QualityCrossRefDetails));
      }
    }

    public ApprovalSheetDetails_Info ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails_Info) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public Info ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public AvailableLotDetail_Info AssignedLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedLots), (object) value);
      }
      get
      {
        return (AvailableLotDetail_Info) this.PropertyGet(nameof (AssignedLots));
      }
    }

    public ExecuteChecklist_Info ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Info) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public Info ActionSelectedTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionSelectedTab), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionSelectedTab));
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
  }
}
