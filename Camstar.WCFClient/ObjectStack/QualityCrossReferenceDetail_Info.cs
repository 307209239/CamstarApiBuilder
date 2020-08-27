// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCrossReferenceDetail_Info
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
  public class QualityCrossReferenceDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Info_TrackingId")]
    protected Info _TrackingId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Info_CrossReference")]
    protected Info _CrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Info_QualityCrossReference")]
    protected Info _QualityCrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Info_QualityObjectDetail")]
    protected QualityObjectStatusDetail_Info _QualityObjectDetail;

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

    public Info QualityCrossReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossReference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityCrossReference));
      }
    }

    public QualityObjectStatusDetail_Info QualityObjectDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail_Info) this.PropertyGet(nameof (QualityObjectDetail));
      }
    }
  }
}
