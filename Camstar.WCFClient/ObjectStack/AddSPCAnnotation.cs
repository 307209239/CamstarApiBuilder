// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AddSPCAnnotation
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
  public class AddSPCAnnotation : SPCTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Annotation")]
    protected Primitive<string> _Annotation;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_DataPoint")]
    protected SubentityRef _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_DataCollectionName")]
    protected Primitive<string> _DataCollectionName;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_DataCollectionDef")]
    protected new RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_CustomSPCDataId")]
    protected Primitive<string> _CustomSPCDataId;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Annotations")]
    protected AddSPCAnnotationHistory[] _Annotations;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Exclude")]
    protected Primitive<bool> _Exclude;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_DataPointName")]
    protected Primitive<string> _DataPointName;

    public override bool Equals(object obj)
    {
      return obj is AddSPCAnnotation && object.Equals((object) this._Annotation, (object) ((AddSPCAnnotation) obj)._Annotation) && (object.Equals((object) this._DataPoint, (object) ((AddSPCAnnotation) obj)._DataPoint) && object.Equals((object) this._DataCollectionName, (object) ((AddSPCAnnotation) obj)._DataCollectionName)) && (object.Equals((object) this._DataCollectionDef, (object) ((AddSPCAnnotation) obj)._DataCollectionDef) && object.Equals((object) this._CustomSPCDataId, (object) ((AddSPCAnnotation) obj)._CustomSPCDataId) && (this.CompareArrays((Array) this._Annotations, (Array) ((AddSPCAnnotation) obj)._Annotations) && object.Equals((object) this._Exclude, (object) ((AddSPCAnnotation) obj)._Exclude))) && object.Equals((object) this._DataPointName, (object) ((AddSPCAnnotation) obj)._DataPointName) && base.Equals(obj);
    }

    public Primitive<string> Annotation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Annotation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Annotation));
      }
    }

    public SubentityRef DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Primitive<string> DataCollectionName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DataCollectionName));
      }
    }

    public new RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Primitive<string> CustomSPCDataId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomSPCDataId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomSPCDataId));
      }
    }

    public AddSPCAnnotationHistory[] Annotations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Annotations), (object) value);
      }
      get
      {
        return (AddSPCAnnotationHistory[]) this.PropertyGet(nameof (Annotations));
      }
    }

    public Primitive<bool> Exclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (Exclude), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Exclude));
      }
    }

    public Primitive<string> DataPointName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DataPointName));
      }
    }
  }
}
