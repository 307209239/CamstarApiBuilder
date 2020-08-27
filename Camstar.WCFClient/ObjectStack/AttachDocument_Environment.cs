// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachDocument_Environment
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
  public class AttachDocument_Environment : GenericTxn_Environment
  {
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 16777570, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_AttachedFileExtension")]
    protected Environment _AttachedFileExtension;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_NamedDataObjectMaint")]
    [Metadata("Maint service for NamedDataObject.", "NamedDataObjectMaint", false, false, false, "NamedDataObjectMaint", 16777580, false, false, false, null)]
    protected NamedDataObjectMaint_Environment _NamedDataObjectMaint;
    [Metadata("To create a new Revisionable Object Maintenance,  define a new maint type under this tree.  Then override the required fields.\r\n\r\n", "RevisionedObjectMaint", false, false, false, "RevisionedObjectMaint", 16777582, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_RevisionedObjectMaint")]
    protected RevisionedObjectMaint_Environment _RevisionedObjectMaint;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_DocumentMaint")]
    [Metadata("Maint service for Document.", "DocumentMaint", false, false, false, "DocumentMaint", 16777576, false, false, false, null)]
    protected DocumentMaint_Environment _DocumentMaint;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 16777571, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_AttachedFileName")]
    protected Environment _AttachedFileName;
    [Metadata("File directory path", "", false, false, false, "String", 16777579, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_FilePath")]
    protected Environment _FilePath;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_AttachmentType")]
    [Metadata("Enumeration used to indicate what type of document attachment will be perfomed:\r\n1 - Attach a new document that will not be reused (no Revision needed)\r\n2 - Attach a new document that will be reused (Revision must be provided)\r\n3 - Attach an existing document", "AttachmentTypeEnum", false, false, false, "Integer", 16777572, false, false, true, null)]
    protected Environment _AttachmentType;
    [Metadata("Enumeration used to identify what type of object a document is being attached to", "ObjectTypeEnum", false, false, false, "Integer", 16777526, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_ObjectType")]
    protected Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_DocTransactionDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777574, false, false, false, null)]
    protected Environment _DocTransactionDate;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777529, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_IsNDO")]
    protected Environment _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_ServiceTypeName")]
    [Metadata("Generic String", "", false, false, false, "String", 1049806, false, false, false, null)]
    protected Environment _ServiceTypeName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_InstanceRevision")]
    [Metadata("Generic String", "", false, false, false, "String", 1053078, false, false, false, null)]
    protected Environment _InstanceRevision;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777530, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_IsRDO")]
    protected Environment _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_IsContainer")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777528, false, false, false, "0")]
    protected Environment _IsContainer;
    [Metadata("Generic String", "", false, false, false, "String", 16777581, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_ObjectTypeName")]
    protected Environment _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_IsDetached")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777556, false, false, false, "0")]
    protected Environment _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_AttachAsROR")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777568, false, false, false, "0")]
    protected Environment _AttachAsROR;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 16777541, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_ContainerInstance")]
    protected Environment _ContainerInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_ObjectTypeId")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050572, false, false, true, null)]
    protected Environment _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_ObjectInstance")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1053199, false, false, false, null)]
    protected Environment _ObjectInstance;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777583, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_UseROR")]
    protected Environment _UseROR;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_TrackableObject")]
    protected new Environment _TrackableObject;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777573, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_CalledExternally")]
    protected Environment _CalledExternally;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_InstanceIsROR")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777554, false, false, false, "0")]
    protected Environment _InstanceIsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_DocumentDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 16777575, false, false, false, null)]
    protected Environment _DocumentDescription;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_AttachedDocument")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 16777569, false, false, true, null)]
    protected Environment _AttachedDocument;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_DocumentProxy")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 16777578, false, false, false, null)]
    protected Environment _DocumentProxy;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_DocumentRevision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 16777566, false, false, false, null)]
    protected Environment _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_DocumentName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050228, false, false, false, null)]
    protected Environment _DocumentName;
    [Metadata("External identifier for a document (Path and file name, URL, etc.)", "", false, false, false, "String", 1049620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_Identifier")]
    protected Environment _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, true, "NamedObjectRef", 1048815, false, false, true, null)]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Environment_InstanceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1053067, false, false, true, null)]
    protected Environment _InstanceName;

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

    public NamedDataObjectMaint_Environment NamedDataObjectMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (NamedDataObjectMaint), (object) value);
      }
      get
      {
        return (NamedDataObjectMaint_Environment) this.PropertyGet(nameof (NamedDataObjectMaint));
      }
    }

    public RevisionedObjectMaint_Environment RevisionedObjectMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (RevisionedObjectMaint), (object) value);
      }
      get
      {
        return (RevisionedObjectMaint_Environment) this.PropertyGet(nameof (RevisionedObjectMaint));
      }
    }

    public DocumentMaint_Environment DocumentMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentMaint), (object) value);
      }
      get
      {
        return (DocumentMaint_Environment) this.PropertyGet(nameof (DocumentMaint));
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

    public Environment ServiceTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceTypeName));
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

    public new Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Environment CalledExternally
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledExternally), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CalledExternally));
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

    public Environment DocumentProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentProxy));
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

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
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
  }
}
