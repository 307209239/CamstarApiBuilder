// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCrossRefDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ResolveCARRefDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class QualityCrossRefDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_TrackingId")]
    protected NamedObjectRef _TrackingId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_CrossReference")]
    protected NamedObjectRef _CrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_ResolutionAction")]
    protected Enumeration<ResolutionActionEnum, int> _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_QualityResolutionCode")]
    protected NamedObjectRef _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_ApprovalSheetMap")]
    protected SubentityRef _ApprovalSheetMap;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_ApprovalSheetStatus")]
    protected Enumeration<ApprovalStatusEnum, int> _ApprovalSheetStatus;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_QualityObjectStatusDetail")]
    protected QualityObjectStatusDetail _QualityObjectStatusDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_ExecuteAction")]
    protected Primitive<int> _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_CloseReference")]
    protected Primitive<bool> _CloseReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_ApprovalRequired")]
    protected Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_CloseDescription")]
    protected Primitive<string> _CloseDescription;

    public override bool Equals(object obj)
    {
      return obj is QualityCrossRefDetail && object.Equals((object) this._TrackingId, (object) ((QualityCrossRefDetail) obj)._TrackingId) && (object.Equals((object) this._QualityObject, (object) ((QualityCrossRefDetail) obj)._QualityObject) && object.Equals((object) this._CrossReference, (object) ((QualityCrossRefDetail) obj)._CrossReference)) && (object.Equals((object) this._ResolutionAction, (object) ((QualityCrossRefDetail) obj)._ResolutionAction) && object.Equals((object) this._QualityResolutionCode, (object) ((QualityCrossRefDetail) obj)._QualityResolutionCode) && (object.Equals((object) this._ApprovalSheetMap, (object) ((QualityCrossRefDetail) obj)._ApprovalSheetMap) && object.Equals((object) this._ApprovalSheetStatus, (object) ((QualityCrossRefDetail) obj)._ApprovalSheetStatus))) && (object.Equals((object) this._QualityObjectStatusDetail, (object) ((QualityCrossRefDetail) obj)._QualityObjectStatusDetail) && object.Equals((object) this._ApprovalSheetTemplate, (object) ((QualityCrossRefDetail) obj)._ApprovalSheetTemplate) && (object.Equals((object) this._ExecuteAction, (object) ((QualityCrossRefDetail) obj)._ExecuteAction) && object.Equals((object) this._CloseReference, (object) ((QualityCrossRefDetail) obj)._CloseReference)) && (object.Equals((object) this._ApprovalRequired, (object) ((QualityCrossRefDetail) obj)._ApprovalRequired) && object.Equals((object) this._CloseDescription, (object) ((QualityCrossRefDetail) obj)._CloseDescription))) && base.Equals(obj);
    }

    public NamedObjectRef TrackingId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackingId), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrackingId));
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

    public NamedObjectRef CrossReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossReference), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CrossReference));
      }
    }

    public Enumeration<ResolutionActionEnum, int> ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Enumeration<ResolutionActionEnum, int>) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public NamedObjectRef QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public SubentityRef ApprovalSheetMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetMap), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ApprovalSheetMap));
      }
    }

    public Enumeration<ApprovalStatusEnum, int> ApprovalSheetStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetStatus), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalStatusEnum, int>) this.PropertyGet(nameof (ApprovalSheetStatus));
      }
    }

    public QualityObjectStatusDetail QualityObjectStatusDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectStatusDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail) this.PropertyGet(nameof (QualityObjectStatusDetail));
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

    public Primitive<int> ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public Primitive<bool> CloseReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseReference), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseReference));
      }
    }

    public Primitive<bool> ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Primitive<string> CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
