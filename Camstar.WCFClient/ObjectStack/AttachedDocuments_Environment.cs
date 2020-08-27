// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachedDocuments_Environment
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
  public class AttachedDocuments_Environment : ServiceData_Environment
  {
    [Metadata("FileName - used for fields that specify files.", "", true, false, true, "String", 1051133, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_FileName")]
    protected Environment _FileName;
    [Metadata("DisplayName", "", false, false, false, "String", 16777587, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_DocumentDisplayName")]
    protected Environment _DocumentDisplayName;
    [Metadata("DisplayName", "", false, false, false, "String", 1053076, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_InstanceDisplayName")]
    protected Environment _InstanceDisplayName;
    [Metadata("Enumeration used to identify what type of object a document is being attached to", "ObjectTypeEnum", false, false, false, "Integer", 16777526, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_ObjectType")]
    protected Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_DocumentType")]
    [Metadata("Enumeration used to classify attached Documents, base on if they were attached as attachments or reusable documents \r\n1 - Attachment\r\n2 - Reusable Document", "DocumentTypeEnum", false, false, false, "Integer", 1049908, false, false, false, null)]
    protected Environment _DocumentType;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777584, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_AttachAsROR")]
    protected Environment _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_EmployeeName")]
    [Metadata("Generic String", "", false, false, true, "String", 1049932, false, false, false, null)]
    protected Environment _EmployeeName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_IsAttachment")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777539, false, false, false, "0")]
    protected Environment _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_ObjectInstanceRevision")]
    [Metadata("Generic String", "", false, false, true, "String", 16777591, false, false, false, null)]
    protected Environment _ObjectInstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_UseROR")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777532, false, false, false, "0")]
    protected Environment _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_ObjectInstanceID")]
    [Metadata("Generic String", "", false, false, false, "String", 1050773, false, false, false, null)]
    protected Environment _ObjectInstanceID;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_AttachmentType")]
    [Metadata("Generic String", "", false, false, false, "String", 16777572, false, false, false, null)]
    protected Environment _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_DocumentName")]
    [Metadata("Generic String", "", false, false, true, "String", 1050228, false, false, false, null)]
    protected Environment _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_ObjectTypeId")]
    [Metadata("CDO Definition Id", "", true, false, false, "Integer", 1050784, false, false, true, null)]
    protected Environment _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_DocumentRevision")]
    [Metadata("Generic String", "", false, false, true, "String", 16777566, false, false, false, null)]
    protected Environment _DocumentRevision;
    [Metadata("Generic String", "", false, false, false, "String", 16777589, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_DocumentTypeValue")]
    protected Environment _DocumentTypeValue;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1053198, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_ObjectInstance")]
    protected Environment _ObjectInstance;
    [Metadata("Generic String", "", false, false, true, "String", 16777590, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_ObjectInstanceName")]
    protected Environment _ObjectInstanceName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_DocTransactionDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777574, false, false, false, null)]
    protected Environment _DocTransactionDate;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777556, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_IsDetached")]
    protected Environment _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_DocumentInHistoryRevision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 16777588, false, false, false, null)]
    protected Environment _DocumentInHistoryRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_AttachedDocumentInHistory")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 16777585, false, false, false, null)]
    protected Environment _AttachedDocumentInHistory;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048861, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_Employee")]
    protected Environment _Employee;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_Document")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", true, false, false, "RevisionedObjectRef", 16777586, false, false, false, null)]
    protected Environment _Document;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Environment_ObjectTypeName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050572, false, false, false, null)]
    protected Environment _ObjectTypeName;

    public Environment FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileName));
      }
    }

    public Environment DocumentDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentDisplayName));
      }
    }

    public Environment InstanceDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceDisplayName));
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

    public Environment DocumentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentType));
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

    public Environment EmployeeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmployeeName));
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

    public Environment ObjectInstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceRevision));
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

    public Environment ObjectInstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceID));
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

    public Environment DocumentTypeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentTypeValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentTypeValue));
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

    public Environment ObjectInstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceName));
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

    public Environment Description
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

    public Environment DocumentInHistoryRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentInHistoryRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentInHistoryRevision));
      }
    }

    public Environment AttachedDocumentInHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocumentInHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedDocumentInHistory));
      }
    }

    public Environment Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Employee));
      }
    }

    public Environment Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Document));
      }
    }

    public Environment ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
