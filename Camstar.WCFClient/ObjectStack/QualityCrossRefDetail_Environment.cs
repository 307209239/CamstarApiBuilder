// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCrossRefDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ResolveCARRefDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class QualityCrossRefDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_TrackingId")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051484, false, false, false, null)]
    protected Environment _TrackingId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051346, false, false, false, null)]
    protected Environment _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_CrossReference")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051488, false, false, false, null)]
    protected Environment _CrossReference;
    [Metadata("Enumeration for the Resolution Action:\r\n1 = Close", "ResolutionActionEnum", false, false, false, "Integer", 1051644, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_ResolutionAction")]
    protected Environment _ResolutionAction;
    [Metadata("Identifies the valid resolution codes for closing an Event or CAPA.", "QualityResolutionCode", false, false, false, "NamedObjectRef", 1051418, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_QualityResolutionCode")]
    protected Environment _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_ApprovalSheetMap")]
    [Metadata("The ApprovalSheetMap sets up that relationship of the ResolutionAction to the ApprovalSheetTemplate.", "ApprovalSheetMap", false, false, false, "SubentityRef", 1051999, false, false, false, null)]
    protected Environment _ApprovalSheetMap;
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_ApprovalSheetStatus")]
    protected Environment _ApprovalSheetStatus;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_QualityObjectStatusDetail")]
    [Metadata("The detail information for the QualityObject.", "QualityObjectStatusDetail", false, false, true, "QualityObjectStatusDetail", 1051467, true, false, false, null)]
    protected QualityObjectStatusDetail_Environment _QualityObjectStatusDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_ApprovalSheetTemplate")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, true, "NamedObjectRef", 1051618, false, false, false, null)]
    protected Environment _ApprovalSheetTemplate;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048872, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_ExecuteAction")]
    protected Environment _ExecuteAction;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051526, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_CloseReference")]
    protected Environment _CloseReference;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051371, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_ApprovalRequired")]
    protected Environment _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Environment_CloseDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1051694, false, false, false, null)]
    protected Environment _CloseDescription;

    public Environment TrackingId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackingId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackingId));
      }
    }

    public Environment QualityObject
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

    public Environment CrossReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossReference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CrossReference));
      }
    }

    public Environment ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public Environment QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Environment ApprovalSheetMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetMap), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetMap));
      }
    }

    public Environment ApprovalSheetStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetStatus));
      }
    }

    public QualityObjectStatusDetail_Environment QualityObjectStatusDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectStatusDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail_Environment) this.PropertyGet(nameof (QualityObjectStatusDetail));
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

    public Environment ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public Environment CloseReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseReference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseReference));
      }
    }

    public Environment ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Environment CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
