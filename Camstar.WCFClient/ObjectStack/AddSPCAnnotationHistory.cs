// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AddSPCAnnotationHistory
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
  public class AddSPCAnnotationHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_DataCollectionName")]
    protected Primitive<string> _DataCollectionName;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_CustomSPCDataId")]
    protected Primitive<string> _CustomSPCDataId;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Annotation")]
    protected Primitive<string> _Annotation;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_DataPoint")]
    protected SubentityRef _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Exclude")]
    protected Primitive<bool> _Exclude;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_DataPointName")]
    protected Primitive<string> _DataPointName;

    public override bool Equals(object obj)
    {
      return obj is AddSPCAnnotationHistory && object.Equals((object) this._DataCollectionName, (object) ((AddSPCAnnotationHistory) obj)._DataCollectionName) && (object.Equals((object) this._CustomSPCDataId, (object) ((AddSPCAnnotationHistory) obj)._CustomSPCDataId) && object.Equals((object) this._Annotation, (object) ((AddSPCAnnotationHistory) obj)._Annotation)) && (object.Equals((object) this._DataCollectionDef, (object) ((AddSPCAnnotationHistory) obj)._DataCollectionDef) && object.Equals((object) this._ExportImportKey, (object) ((AddSPCAnnotationHistory) obj)._ExportImportKey) && (object.Equals((object) this._DataPoint, (object) ((AddSPCAnnotationHistory) obj)._DataPoint) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((AddSPCAnnotationHistory) obj)._HistoryDetails))) && (object.Equals((object) this._HistoryId, (object) ((AddSPCAnnotationHistory) obj)._HistoryId) && object.Equals((object) this._Exclude, (object) ((AddSPCAnnotationHistory) obj)._Exclude) && object.Equals((object) this._DataPointName, (object) ((AddSPCAnnotationHistory) obj)._DataPointName)) && base.Equals(obj);
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

    public RevisionedObjectRef DataCollectionDef
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
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

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
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
