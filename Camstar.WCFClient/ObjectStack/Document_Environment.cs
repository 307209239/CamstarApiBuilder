// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Document_Environment
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
  public class Document_Environment : RevisionedObject_Environment
  {
    [Metadata("URL", "", false, false, true, "String", 1049620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_Identifier")]
    protected Environment _Identifier;
    [Metadata("Attached Document", "AttachedDoc", false, false, true, "NamedSubentityRef", 1052146, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_Attachment")]
    protected Environment _Attachment;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_AuthenticationType")]
    [Metadata("Enumeration for the Authentication Type:\r\n10 = Basic\r\n20 = None", "AuthenticationTypeEnum", false, false, true, "Integer", 16778999, false, false, false, null)]
    protected Environment _AuthenticationType;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_FilterTags")]
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    protected new Environment _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_ModelingInstanceLocks")]
    [Metadata("A listing of a change package where modeling instance is assigned.", "ModelingInstanceLock", false, false, true, "SubentityRef", 16777683, false, true, false, null)]
    protected new Environment _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_BrowseMode")]
    [Metadata("BrowseMode", "BrowseModeEnum", false, false, true, "Integer", 16779316, false, false, false, null)]
    protected Environment _BrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_ECO")]
    [Metadata("Generic String", "", false, false, true, "String", 1050862, false, false, false, null)]
    protected new Environment _ECO;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_InstanceLocked")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777984, false, false, false, "0")]
    protected new Environment _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_AssociatedPackages")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777948, false, false, false, null)]
    protected new Environment _AssociatedPackages;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777539, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_IsAttachment")]
    protected Environment _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050228, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_Viewer")]
    [Metadata("Document Viewer allows you to specify the application to use to view the documents that are defined within InSite. A Document Viewer definition contains the location of the application and a command line string that launches the program to display the document. For example, you may define Document Viewers that use Word, Excel, or Portable Document Format (PDF) to view various documents.", "DocumentViewer", false, false, true, "NamedObjectRef", 1048893, false, false, false, null)]
    protected Environment _Viewer;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_ChangeHistory")]
    protected new ChangeHistory_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_Status")]
    protected new Environment _Status;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1052148, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_FileVersion")]
    protected Environment _FileVersion;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_IconId")]
    protected new Environment _IconId;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_Base")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "DocumentBase", false, false, true, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_Revision")]
    protected new Environment _Revision;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    protected new Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_WIPMsgDefMgr")]
    [Metadata("Attached to an instance of a modeling entity, this contains the messages that apply to the entity.  When asked to supply its WIP Messages, a modeling entity will ask its WIPMsgDefMgr to supply a list of WIP Messages that have been filtered to include only the messages that apply to the current circumstances (step, operation and label).\r\nThe WIPMsgDefMgr will check the AllKey WIPMsgKey (which contains a message that applies to all steps) if specified, and run through the entries in the OperationKeys and LabelKeys lists and filter each message found.", "WIPMsgDefMgr", false, false, true, "WIPMsgDefMgr", 1048768, false, false, false, null)]
    protected new WIPMsgDefMgr_Environment _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "Document_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected new Environment _Description;

    public Environment Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Identifier));
      }
    }

    public Environment Attachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Attachment));
      }
    }

    public Environment AuthenticationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuthenticationType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AuthenticationType));
      }
    }

    public new Environment FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new Environment ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public Environment BrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrowseMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BrowseMode));
      }
    }

    public new Environment ECO
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ECO));
      }
    }

    public new Environment InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Environment AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public Environment IsAttachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsAttachment));
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

    public Environment Viewer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Viewer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Viewer));
      }
    }

    public new ChangeHistory_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment FileVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileVersion), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileVersion));
      }
    }

    public new Environment IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IconId));
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

    public new Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
      }
    }

    public new Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }

    public new WIPMsgDefMgr_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgr_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public new Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
