// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCrossRefDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ResolveCARRefDetail_Info))]
  [Serializable]
  public class QualityCrossRefDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_TrackingId")]
    protected Info _TrackingId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_CrossReference")]
    protected Info _CrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_ResolutionAction")]
    protected Info _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_QualityResolutionCode")]
    protected Info _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_ApprovalSheetMap")]
    protected Info _ApprovalSheetMap;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_ApprovalSheetStatus")]
    protected Info _ApprovalSheetStatus;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_QualityObjectStatusDetail")]
    protected QualityObjectStatusDetail_Info _QualityObjectStatusDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_ApprovalSheetTemplate")]
    protected Info _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_ExecuteAction")]
    protected Info _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_CloseReference")]
    protected Info _CloseReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_ApprovalRequired")]
    protected Info _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefDetail_Info_CloseDescription")]
    protected Info _CloseDescription;

    public Info TrackingId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackingId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackingId));
      }
    }

    public Info QualityObject
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

    public Info CrossReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossReference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CrossReference));
      }
    }

    public Info ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public Info QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Info ApprovalSheetMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetMap), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetMap));
      }
    }

    public Info ApprovalSheetStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetStatus));
      }
    }

    public QualityObjectStatusDetail_Info QualityObjectStatusDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectStatusDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail_Info) this.PropertyGet(nameof (QualityObjectStatusDetail));
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

    public Info ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public Info CloseReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseReference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseReference));
      }
    }

    public Info ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Info CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
