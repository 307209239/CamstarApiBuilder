// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintHistoryDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CompleteRecurDateHistDetails_Environment))]
  [KnownType(typeof (CompleteThruputHistoryDetails_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CompleteDateHistoryDetails_Environment))]
  [Serializable]
  public class CompleteMaintHistoryDetails_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, true, "RevisionedObjectRef", 1048868, false, false, false, null)]
    protected Environment _DataCollectionDef;
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("Defines maintenance requirements for a Resource or MaintenanceClass.", "MaintenanceReq", false, false, true, "RevisionedObjectRef", 1050704, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Environment_MaintenanceReq")]
    protected Environment _MaintenanceReq;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Environment_DocumentSet")]
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "NamedObjectRef", 1048646, false, false, false, null)]
    protected Environment _DocumentSet;

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

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReq));
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

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
      }
    }
  }
}
