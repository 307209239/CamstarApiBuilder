// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachDocumentHistory_Environment
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
  public class AttachDocumentHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 16777570, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_AttachedFileExtension")]
    protected Environment _AttachedFileExtension;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 16777571, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_AttachedFileName")]
    protected Environment _AttachedFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("Enumeration used to indicate what type of document attachment will be perfomed:\r\n1 - Attach a new document that will not be reused (no Revision needed)\r\n2 - Attach a new document that will be reused (Revision must be provided)\r\n3 - Attach an existing document", "AttachmentTypeEnum", false, false, false, "Integer", 16777572, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_AttachmentType")]
    protected Environment _AttachmentType;
    [Metadata("Enumeration used to identify what type of object a document is being attached to", "ObjectTypeEnum", false, false, false, "Integer", 1050572, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_ObjectType")]
    protected Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_DocTransactionDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777574, false, false, false, null)]
    protected Environment _DocTransactionDate;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777554, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_InstanceIsROR")]
    protected Environment _InstanceIsROR;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1053199, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_ObjectInstance")]
    protected Environment _ObjectInstance;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777556, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_IsDetached")]
    protected Environment _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_UseROR")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777583, false, false, false, "0")]
    protected Environment _UseROR;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050784, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_ObjectTypeId")]
    protected Environment _ObjectTypeId;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777568, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_AttachAsROR")]
    protected Environment _AttachAsROR;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 16777566, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_DocumentRevision")]
    protected Environment _DocumentRevision;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048864, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_User")]
    protected Environment _User;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_InstanceRevision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1053078, false, false, false, null)]
    protected Environment _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_InstanceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1053067, false, false, false, null)]
    protected Environment _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_FilePath")]
    [Metadata("External identifier for a document (Path and file name, URL, etc.)", "", false, false, false, "String", 16777579, false, false, false, null)]
    protected Environment _FilePath;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 16777575, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_DocumentDescription")]
    protected Environment _DocumentDescription;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050228, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_DocumentName")]
    protected Environment _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Environment_AttachedDocument")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 16777569, false, false, true, null)]
    protected Environment _AttachedDocument;

    public Environment AttachedFileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileExtension), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedFileExtension));
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

    public Environment AttachedFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedFileName));
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

    public Environment AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachmentType));
      }
    }

    public Environment ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Environment DocTransactionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocTransactionDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocTransactionDate));
      }
    }

    public Environment InstanceIsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceIsROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceIsROR));
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

    public Environment ObjectInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstance));
      }
    }

    public Environment IsDetached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDetached), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsDetached));
      }
    }

    public Environment UseROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseROR));
      }
    }

    public Environment ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public Environment AttachAsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachAsROR));
      }
    }

    public Environment DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentRevision));
      }
    }

    public Environment User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (User));
      }
    }

    public Environment InstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceRevision));
      }
    }

    public Environment InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceName));
      }
    }

    public Environment FilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilePath), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilePath));
      }
    }

    public Environment DocumentDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentDescription));
      }
    }

    public Environment DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentName));
      }
    }

    public Environment AttachedDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocument), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedDocument));
      }
    }
  }
}
