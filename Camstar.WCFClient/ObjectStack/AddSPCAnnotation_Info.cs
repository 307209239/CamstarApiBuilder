// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AddSPCAnnotation_Info
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
  public class AddSPCAnnotation_Info : SPCTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Info_Annotation")]
    protected Info _Annotation;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Info_DataPoint")]
    protected Info _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Info_DataCollectionName")]
    protected Info _DataCollectionName;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Info_DataCollectionDef")]
    protected new Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Info_CustomSPCDataId")]
    protected Info _CustomSPCDataId;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Info_Annotations")]
    protected AddSPCAnnotationHistory_Info _Annotations;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Info_Exclude")]
    protected Info _Exclude;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Info_DataPointName")]
    protected Info _DataPointName;

    public Info Annotation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Annotation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Annotation));
      }
    }

    public Info DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Info DataCollectionName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionName));
      }
    }

    public new Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Info CustomSPCDataId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomSPCDataId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomSPCDataId));
      }
    }

    public AddSPCAnnotationHistory_Info Annotations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Annotations), (object) value);
      }
      get
      {
        return (AddSPCAnnotationHistory_Info) this.PropertyGet(nameof (Annotations));
      }
    }

    public Info Exclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (Exclude), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Exclude));
      }
    }

    public Info DataPointName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPointName));
      }
    }
  }
}
