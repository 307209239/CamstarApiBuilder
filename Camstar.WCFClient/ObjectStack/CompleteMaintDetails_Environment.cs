// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintDetails_Environment
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
  public class CompleteMaintDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, true, "RevisionedObjectRef", 1048868, false, false, false, null)]
    protected Environment _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Environment_MaintenanceReq")]
    [Metadata("Defines maintenance requirements for a Resource or MaintenanceClass.", "MaintenanceReq", false, false, true, "RevisionedObjectRef", 1050704, false, false, false, null)]
    protected Environment _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Environment_MaintenanceStatus")]
    [Metadata("Maintains the current status of the Resources as it applies to maintenance.", "MaintenanceStatus", false, false, false, "SubentityRef", 1050713, false, false, false, null)]
    protected Environment _MaintenanceStatus;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050747, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Environment_LastMaintCompletionDate")]
    protected Environment _LastMaintCompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Environment_DocumentSet")]
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "DocumentSet", 1048646, false, false, false, null)]
    protected DocumentSet_Environment _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Environment_DocumentEntries")]
    [Metadata("A Document Entry is used to include a Document in a Document and provide a description for it within the Document Set. If there is more than one Document within a Document Set when a request is made to display a Document Set, the list of Document Entries is used to build a selection list. (Note that a one-to-one relationship between a Document Set and a Document is likely the common scenario).", "DocumentEntry", false, false, true, "DocumentEntry", 1050452, false, true, false, null)]
    protected DocumentEntry_Environment _DocumentEntries;

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

    public Environment MaintenanceStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceStatus));
      }
    }

    public Environment LastMaintCompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMaintCompletionDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMaintCompletionDate));
      }
    }

    public DocumentSet_Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (DocumentSet_Environment) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public DocumentEntry_Environment DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry_Environment) this.PropertyGet(nameof (DocumentEntries));
      }
    }
  }
}
