// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEvent
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
  public class UpdateEvent : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_ServiceDetail")]
    protected EventDetail _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_QualityCrossReferences")]
    protected QualityCrossReferenceDetail[] _QualityCrossReferences;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_QualityCrossRefDetails")]
    protected QualityCrossRefDetail[] _QualityCrossRefDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_ApprovalSheetDetails")]
    protected ApprovalSheetDetails _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_AssignedLots")]
    protected AvailableLotDetail[] _AssignedLots;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_ExecuteChecklist")]
    protected ExecuteChecklist _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_ActionSelectedTab")]
    protected Primitive<int> _ActionSelectedTab;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEvent_Submit")]
    protected Primitive<bool> _Submit;

    public override bool Equals(object obj)
    {
      return obj is UpdateEvent && object.Equals((object) this._QualityObject, (object) ((UpdateEvent) obj)._QualityObject) && (object.Equals((object) this._ServiceDetail, (object) ((UpdateEvent) obj)._ServiceDetail) && object.Equals((object) this._SubClassification, (object) ((UpdateEvent) obj)._SubClassification)) && (this.CompareArrays((Array) this._QualityCrossReferences, (Array) ((UpdateEvent) obj)._QualityCrossReferences) && object.Equals((object) this._Classification, (object) ((UpdateEvent) obj)._Classification) && (this.CompareArrays((Array) this._QualityCrossRefDetails, (Array) ((UpdateEvent) obj)._QualityCrossRefDetails) && object.Equals((object) this._ApprovalSheetDetails, (object) ((UpdateEvent) obj)._ApprovalSheetDetails))) && (object.Equals((object) this._ApprovalSheetTemplate, (object) ((UpdateEvent) obj)._ApprovalSheetTemplate) && this.CompareArrays((Array) this._AssignedLots, (Array) ((UpdateEvent) obj)._AssignedLots) && (object.Equals((object) this._ExecuteChecklist, (object) ((UpdateEvent) obj)._ExecuteChecklist) && object.Equals((object) this._ActionSelectedTab, (object) ((UpdateEvent) obj)._ActionSelectedTab)) && object.Equals((object) this._Submit, (object) ((UpdateEvent) obj)._Submit)) && base.Equals(obj);
    }

    public new NamedObjectRef QualityObject
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

    public EventDetail ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (EventDetail) this.PropertyGet(nameof (ServiceDetail));
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

    public QualityCrossReferenceDetail[] QualityCrossReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossReferences), (object) value);
      }
      get
      {
        return (QualityCrossReferenceDetail[]) this.PropertyGet(nameof (QualityCrossReferences));
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

    public QualityCrossRefDetail[] QualityCrossRefDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefDetails), (object) value);
      }
      get
      {
        return (QualityCrossRefDetail[]) this.PropertyGet(nameof (QualityCrossRefDetails));
      }
    }

    public ApprovalSheetDetails ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public NamedObjectRef ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalSheetTemplate));
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

    public ExecuteChecklist ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public Primitive<int> ActionSelectedTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionSelectedTab), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ActionSelectedTab));
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
  }
}
