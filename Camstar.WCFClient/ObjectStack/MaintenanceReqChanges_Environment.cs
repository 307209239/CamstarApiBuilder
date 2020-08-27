// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintenanceReqChanges_Environment
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
  public class MaintenanceReqChanges_Environment : RevisionedObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048868, false, false, true, null)]
    protected Environment _DataCollectionDef;
    [Metadata("Defines maintenance requirements for a Resource or MaintenanceClass.", "MaintenanceReq", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Defines maintenance requirements for a Resource or MaintenanceClass.", "MaintenanceReqBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_Base")]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_MaintenanceReason")]
    [Metadata("Reason for maintence on a Resource.", "MaintenanceReason", false, true, false, "NamedObjectRef", 1050675, false, false, true, null)]
    protected Environment _MaintenanceReason;
    [Metadata("A subclass of a NotificationTarget that sends its information by e-mail.", "EMailNotification", false, false, false, "NamedObjectRef", 1050678, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_PendingEmailTarget")]
    protected Environment _PendingEmailTarget;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_DueEmailTarget")]
    [Metadata("A subclass of a NotificationTarget that sends its information by e-mail.", "EMailNotification", false, false, false, "NamedObjectRef", 1050673, false, true, true, null)]
    protected Environment _DueEmailTarget;
    [Metadata("A subclass of a NotificationTarget that sends its information by e-mail.", "EMailNotification", false, false, false, "NamedObjectRef", 1050676, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_PastDueEmailTarget")]
    protected Environment _PastDueEmailTarget;
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1050417, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_ESigRequirement")]
    protected Environment _ESigRequirement;
    [Metadata("Message text.", "", false, false, false, "String", 1050674, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_DueEmailText")]
    protected Environment _DueEmailText;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048646, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_DocumentSet")]
    protected Environment _DocumentSet;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050680, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Message text.", "", false, false, false, "String", 1050679, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_PendingEmailText")]
    protected Environment _PendingEmailText;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Environment_PastDueEmailText")]
    [Metadata("Message text.", "", false, false, false, "String", 1050677, false, false, false, null)]
    protected Environment _PastDueEmailText;

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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment MaintenanceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReason));
      }
    }

    public Environment PendingEmailTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (PendingEmailTarget), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PendingEmailTarget));
      }
    }

    public Environment DueEmailTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueEmailTarget), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueEmailTarget));
      }
    }

    public Environment PastDueEmailTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (PastDueEmailTarget), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PastDueEmailTarget));
      }
    }

    public Environment ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public Environment DueEmailText
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueEmailText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueEmailText));
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

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment PendingEmailText
    {
      [param: In] set
      {
        this.PropertySet(nameof (PendingEmailText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PendingEmailText));
      }
    }

    public Environment PastDueEmailText
    {
      [param: In] set
      {
        this.PropertySet(nameof (PastDueEmailText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PastDueEmailText));
      }
    }
  }
}
