// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetAttachedDocuments_Environment
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
  public class GetAttachedDocuments_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_FileNameProxy")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 16777550, false, true, false, null)]
    protected Environment _FileNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_AttachmentType")]
    [Metadata("Enumeration used to indicate what type of document attachment will be perfomed:\r\n1 - Attach a new document that will not be reused (no Revision needed)\r\n2 - Attach a new document that will be reused (Revision must be provided)\r\n3 - Attach an existing document", "AttachmentTypeEnum", true, false, false, "Integer", 1049908, false, false, true, null)]
    protected Environment _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ObjectTypeProxy")]
    [Metadata("Enumeration used to identify what type of object a document is being attached to", "ObjectTypeEnum", false, false, false, "Integer", 16777562, false, true, false, null)]
    protected Environment _ObjectTypeProxy;
    [Metadata("Enumeration used to identify what type of object a document is being attached to", "ObjectTypeEnum", false, false, false, "Integer", 16777526, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ObjectType")]
    protected Environment _ObjectType;
    [Metadata("Enumeration used to classify attached Documents, base on if they were attached as attachments or reusable documents \r\n1 - Attachment\r\n2 - Reusable Document", "DocumentTypeEnum", false, false, false, "Integer", 1049908, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_DocumentType")]
    protected Environment _DocumentType;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_AttachedDocuments")]
    [Metadata("List of Attached Documents retrieved by Get Attached Documents inquiry", "AttachedDocuments", false, false, false, "AttachedDocuments", 1052207, false, true, false, null)]
    protected AttachedDocuments_Environment _AttachedDocuments;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777531, false, true, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_AttachAsRORProxy")]
    protected Environment _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_DocTransactionDateProxy")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777543, false, true, false, null)]
    protected Environment _DocTransactionDateProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_FromTimeStamp")]
    [Metadata("Generic TimeStamp", "", true, false, false, "TimeStamp", 16777551, false, false, false, null)]
    protected Environment _FromTimeStamp;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ObjectTypeIdProxy")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 16777560, false, true, false, null)]
    protected Environment _ObjectTypeIdProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_IsRDO")]
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 16777530, false, false, false, "0")]
    protected Environment _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_IsNDO")]
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 16777529, false, false, false, "0")]
    protected Environment _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ObjectTypeId")]
    [Metadata("CDO Definition Id", "", true, false, false, "Integer", 1050572, false, false, true, null)]
    protected Environment _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_DocumentRevisionProxy")]
    [Metadata("Generic String", "", false, false, false, "String", 16777545, false, true, false, null)]
    protected Environment _DocumentRevisionProxy;
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 16777563, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ShowOnlyROR")]
    protected Environment _ShowOnlyROR;
    [Metadata("Generic String", "", false, false, false, "String", 16777559, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ObjectInstanceRevisionProxy")]
    protected Environment _ObjectInstanceRevisionProxy;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777533, false, true, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_UseRORProxy")]
    protected Environment _UseRORProxy;
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 16777552, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_IncludeAttached")]
    protected Environment _IncludeAttached;
    [Metadata("Generic String", "", true, false, false, "String", 1053078, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_InstanceRevision")]
    protected Environment _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_IsContainer")]
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 16777528, false, false, false, "0")]
    protected Environment _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_EmployeeNameProxy")]
    [Metadata("Generic String", "", false, false, false, "String", 16777548, false, true, false, null)]
    protected Environment _EmployeeNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_DocumentNameProxy")]
    [Metadata("Generic String", "", false, false, false, "String", 16777544, false, true, false, null)]
    protected Environment _DocumentNameProxy;
    [Metadata("Generic TimeStamp", "", true, false, false, "TimeStamp", 16777564, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ToTimestamp")]
    protected Environment _ToTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_IncludeDetached")]
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 16777553, false, false, false, "0")]
    protected Environment _IncludeDetached;
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 16777554, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_InstanceIsROR")]
    protected Environment _InstanceIsROR;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ContainerInstance")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 16777541, false, false, false, null)]
    protected Environment _ContainerInstance;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777557, false, true, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_IsDetachedProxy")]
    protected Environment _IsDetachedProxy;
    [Metadata("Generic String", "", false, false, false, "String", 16777558, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ObjectInstanceNameProxy")]
    protected Environment _ObjectInstanceNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_IsAttachmentProxy")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777555, false, true, false, "0")]
    protected Environment _IsAttachmentProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ObjectInstance")]
    [Metadata("BaseObject", "BaseObject", true, false, false, "BaseObjectRef", 1053199, false, false, false, null)]
    protected Environment _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_IsDetached")]
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 16777556, false, false, false, "0")]
    protected Environment _IsDetached;
    [Metadata("Generic String", "", true, false, false, "String", 1051132, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_FileExtension")]
    protected Environment _FileExtension;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 16777542, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_DescriptionProxy")]
    protected Environment _DescriptionProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_EmployeeProxy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16777549, false, true, false, null)]
    protected Environment _EmployeeProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_DocumentsProxy")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 16777546, false, true, false, null)]
    protected Environment _DocumentsProxy;
    [Metadata("Unique name for this instance", "", true, false, false, "String", 1053067, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_InstanceName")]
    protected Environment _InstanceName;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 16777540, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_AttachedDocumentInHistoryProxy")]
    protected Environment _AttachedDocumentInHistoryProxy;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", true, false, false, "NamedObjectRef", 16777547, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_EmployeeFilter")]
    protected Environment _EmployeeFilter;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16777561, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_ObjectTypeNameProxy")]
    protected Environment _ObjectTypeNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Environment_DocumentName")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", true, false, false, "RevisionedObjectRef", 1050228, false, false, true, null)]
    protected Environment _DocumentName;

    public Environment FileNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileNameProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileNameProxy));
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

    public Environment ObjectTypeProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeProxy));
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

    public AttachedDocuments_Environment AttachedDocuments
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocuments), (object) value);
      }
      get
      {
        return (AttachedDocuments_Environment) this.PropertyGet(nameof (AttachedDocuments));
      }
    }

    public Environment AttachAsRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsRORProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachAsRORProxy));
      }
    }

    public Environment DocTransactionDateProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocTransactionDateProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocTransactionDateProxy));
      }
    }

    public Environment FromTimeStamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromTimeStamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromTimeStamp));
      }
    }

    public Environment ObjectTypeIdProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeIdProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeIdProxy));
      }
    }

    public Environment IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Environment IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsNDO));
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

    public Environment DocumentRevisionProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevisionProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentRevisionProxy));
      }
    }

    public Environment ShowOnlyROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowOnlyROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowOnlyROR));
      }
    }

    public Environment ObjectInstanceRevisionProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceRevisionProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceRevisionProxy));
      }
    }

    public Environment UseRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseRORProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseRORProxy));
      }
    }

    public Environment IncludeAttached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeAttached), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeAttached));
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

    public Environment IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Environment EmployeeNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeNameProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmployeeNameProxy));
      }
    }

    public Environment DocumentNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentNameProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentNameProxy));
      }
    }

    public Environment ToTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToTimestamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToTimestamp));
      }
    }

    public Environment IncludeDetached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeDetached), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeDetached));
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

    public Environment ContainerInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerInstance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerInstance));
      }
    }

    public Environment IsDetachedProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDetachedProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsDetachedProxy));
      }
    }

    public Environment ObjectInstanceNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceNameProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceNameProxy));
      }
    }

    public Environment IsAttachmentProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachmentProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsAttachmentProxy));
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

    public Environment FileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileExtension), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileExtension));
      }
    }

    public Environment DescriptionProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DescriptionProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DescriptionProxy));
      }
    }

    public Environment EmployeeProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmployeeProxy));
      }
    }

    public Environment DocumentsProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentsProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentsProxy));
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

    public Environment AttachedDocumentInHistoryProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocumentInHistoryProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedDocumentInHistoryProxy));
      }
    }

    public Environment EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmployeeFilter));
      }
    }

    public Environment ObjectTypeNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeNameProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeNameProxy));
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
  }
}
