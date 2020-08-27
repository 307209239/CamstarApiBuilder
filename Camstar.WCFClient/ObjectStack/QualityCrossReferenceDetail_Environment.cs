// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCrossReferenceDetail_Environment
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
  public class QualityCrossReferenceDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1049120, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Environment_TrackingId")]
    protected Environment _TrackingId;
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051483, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Environment_CrossReference")]
    protected Environment _CrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051298, false, false, false, null)]
    protected Environment _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Environment_QualityCrossReference")]
    [Metadata("An QualityCrossReference is used to store the current cross refrences between different QualityObjects. There is no hierarchy.\r\n", "QualityCrossReference", false, false, false, "BaseObjectRef", 1052979, false, false, false, null)]
    protected Environment _QualityCrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossReferenceDetail_Environment_QualityObjectDetail")]
    [Metadata("The detail information for the QualityObject.", "QualityObjectStatusDetail", false, false, false, "QualityObjectStatusDetail", 1051467, true, false, false, null)]
    protected QualityObjectStatusDetail_Environment _QualityObjectDetail;

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

    public Environment QualityCrossReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossReference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityCrossReference));
      }
    }

    public QualityObjectStatusDetail_Environment QualityObjectDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail_Environment) this.PropertyGet(nameof (QualityObjectDetail));
      }
    }
  }
}
