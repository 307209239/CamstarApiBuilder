// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AddSPCAnnotation_Environment
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
  public class AddSPCAnnotation_Environment : SPCTxn_Environment
  {
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, true, false, "String", 1052600, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Environment_Annotation")]
    protected Environment _Annotation;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Environment_DataPoint")]
    [Metadata("The history of the DataPoints collected for a DataPointCollectionDef.", "DataPointHistoryDetail", false, false, false, "SubentityRef", 1050537, false, false, false, null)]
    protected Environment _DataPoint;
    [Metadata("DisplayName", "", false, false, false, "String", 1052992, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Environment_DataCollectionName")]
    protected Environment _DataCollectionName;
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, true, "RevisionedObjectRef", 1048868, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Environment_DataCollectionDef")]
    protected new Environment _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Environment_CustomSPCDataId")]
    [Metadata("Comments", "", false, false, false, "String", 1053051, false, false, false, null)]
    protected Environment _CustomSPCDataId;
    [Metadata("History for SPC Annotations.", "AddSPCAnnotationHistory", false, false, true, "AddSPCAnnotationHistory", 1052991, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Environment_Annotations")]
    protected AddSPCAnnotationHistory_Environment _Annotations;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Environment_Exclude")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052601, false, false, false, "0")]
    protected Environment _Exclude;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050528, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotation_Environment_DataPointName")]
    protected Environment _DataPointName;

    public Environment Annotation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Annotation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Annotation));
      }
    }

    public Environment DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Environment DataCollectionName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionName));
      }
    }

    public new Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Environment CustomSPCDataId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomSPCDataId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomSPCDataId));
      }
    }

    public AddSPCAnnotationHistory_Environment Annotations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Annotations), (object) value);
      }
      get
      {
        return (AddSPCAnnotationHistory_Environment) this.PropertyGet(nameof (Annotations));
      }
    }

    public Environment Exclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (Exclude), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Exclude));
      }
    }

    public Environment DataPointName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPointName));
      }
    }
  }
}
