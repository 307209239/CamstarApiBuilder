// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCrossReferenceDetail
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
  public class QualityCrossReferenceDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_TrackingId")]
    protected NamedObjectRef _TrackingId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_CrossReference")]
    protected NamedObjectRef _CrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_QualityCrossReference")]
    protected BaseObjectRef _QualityCrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_QualityObjectDetail")]
    protected QualityObjectStatusDetail _QualityObjectDetail;

    public override bool Equals(object obj)
    {
      return obj is QualityCrossReferenceDetail && object.Equals((object) this._TrackingId, (object) ((QualityCrossReferenceDetail) obj)._TrackingId) && (object.Equals((object) this._CrossReference, (object) ((QualityCrossReferenceDetail) obj)._CrossReference) && object.Equals((object) this._QualityObject, (object) ((QualityCrossReferenceDetail) obj)._QualityObject)) && (object.Equals((object) this._QualityCrossReference, (object) ((QualityCrossReferenceDetail) obj)._QualityCrossReference) && object.Equals((object) this._QualityObjectDetail, (object) ((QualityCrossReferenceDetail) obj)._QualityObjectDetail)) && base.Equals(obj);
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

    public BaseObjectRef QualityCrossReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossReference), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (QualityCrossReference));
      }
    }

    public QualityObjectStatusDetail QualityObjectDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail) this.PropertyGet(nameof (QualityObjectDetail));
      }
    }
  }
}
