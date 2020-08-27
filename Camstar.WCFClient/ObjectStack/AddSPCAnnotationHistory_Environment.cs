// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AddSPCAnnotationHistory_Environment
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
  public class AddSPCAnnotationHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("DisplayName", "", false, false, true, "String", 1052992, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_DataCollectionName")]
    protected Environment _DataCollectionName;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_CustomSPCDataId")]
    [Metadata("Comments", "", false, false, true, "String", 1053051, false, false, false, null)]
    protected Environment _CustomSPCDataId;
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, true, "String", 1052600, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_Annotation")]
    protected Environment _Annotation;
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, true, "RevisionedObjectRef", 1048868, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_DataCollectionDef")]
    protected Environment _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_DataPoint")]
    [Metadata("The history of the DataPoints collected for a DataPointCollectionDef.", "DataPointHistoryDetail", false, true, false, "SubentityRef", 1050537, false, false, false, null)]
    protected Environment _DataPoint;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_Exclude")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052601, false, false, false, "0")]
    protected Environment _Exclude;
    [DataMember(EmitDefaultValue = false, Name = "AddSPCAnnotationHistory_Environment_DataPointName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050528, false, false, false, null)]
    protected Environment _DataPointName;

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

    public Environment DataCollectionDef
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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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
