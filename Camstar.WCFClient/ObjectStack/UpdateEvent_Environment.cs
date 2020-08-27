// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEvent_Environment
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
  public class UpdateEvent_Environment : QualityTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_QualityObject")]
    [Metadata("An Event identifies something suspect for which more investigation must be done.  Events may be escalated to an NCR or attached to CAPAs.", "Event", false, false, false, "NamedObjectRef", 1051042, false, false, true, null)]
    protected new Environment _QualityObject;
    [Metadata("The EventDetail service detail is used for creating and updating events", "EventDetail", false, false, false, "EventDetail", 1051208, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_ServiceDetail")]
    protected EventDetail_Environment _ServiceDetail;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, true, "NamedObjectRef", 1051146, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_SubClassification")]
    protected Environment _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_QualityCrossReferences")]
    [Metadata("New structure for CrossReference processing.", "QualityCrossReferenceDetail", false, false, false, "QualityCrossReferenceDetail", 1052980, false, true, false, null)]
    protected QualityCrossReferenceDetail_Environment _QualityCrossReferences;
    [Metadata("Used to classify QualityObjects", "Classification", false, false, true, "NamedObjectRef", 1051055, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_Classification")]
    protected Environment _Classification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_QualityCrossRefDetails")]
    [Metadata("Quality Cross Ref Detail", "QualityCrossRefDetail", false, false, false, "QualityCrossRefDetail", 1052082, false, true, false, null)]
    protected QualityCrossRefDetail_Environment _QualityCrossRefDetails;
    [Metadata("Used to update an ApprovalSheet for a parent object", "ApprovalSheetDetails", false, false, false, "ApprovalSheetDetails", 1051619, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_ApprovalSheetDetails")]
    protected ApprovalSheetDetails_Environment _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_ApprovalSheetTemplate")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051645, false, false, true, null)]
    protected Environment _ApprovalSheetTemplate;
    [Metadata("Service details for available lots", "AvailableLotDetail", false, false, false, "AvailableLotDetail", 1052032, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_AssignedLots")]
    protected AvailableLotDetail_Environment _AssignedLots;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_ExecuteChecklist")]
    [Metadata("Execute Checklist transaction is used to complete assigned checklist.", "ExecuteChecklist", false, false, false, "ExecuteChecklist", 1052417, true, false, false, null)]
    protected ExecuteChecklist_Environment _ExecuteChecklist;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053049, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_ActionSelectedTab")]
    protected Environment _ActionSelectedTab;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Environment_Submit")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051062, false, false, false, "0")]
    protected Environment _Submit;

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public EventDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (EventDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public QualityCrossReferenceDetail_Environment QualityCrossReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossReferences), (object) value);
      }
      get
      {
        return (QualityCrossReferenceDetail_Environment) this.PropertyGet(nameof (QualityCrossReferences));
      }
    }

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
      }
    }

    public QualityCrossRefDetail_Environment QualityCrossRefDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefDetails), (object) value);
      }
      get
      {
        return (QualityCrossRefDetail_Environment) this.PropertyGet(nameof (QualityCrossRefDetails));
      }
    }

    public ApprovalSheetDetails_Environment ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails_Environment) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public Environment ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public AvailableLotDetail_Environment AssignedLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedLots), (object) value);
      }
      get
      {
        return (AvailableLotDetail_Environment) this.PropertyGet(nameof (AssignedLots));
      }
    }

    public ExecuteChecklist_Environment ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Environment) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public Environment ActionSelectedTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionSelectedTab), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionSelectedTab));
      }
    }

    public Environment Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Submit));
      }
    }
  }
}
