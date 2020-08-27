// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachDocumentDetails_Environment
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
  public class AttachDocumentDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_DocumentDisplayName")]
    [Metadata("DisplayName", "", false, false, false, "String", 16777587, false, false, false, null)]
    protected Environment _DocumentDisplayName;
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051133, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_FileName")]
    protected Environment _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_ObjectType")]
    [Metadata("Enumeration used to identify what type of object a document is being attached to", "ObjectTypeEnum", false, false, false, "Integer", 16777526, false, false, true, null)]
    protected Environment _ObjectType;
    [Metadata("Generic String", "", false, false, true, "String", 16777566, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_DocumentRevision")]
    protected Environment _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_AttachmentType")]
    [Metadata("Generic String", "", false, false, false, "String", 16777572, false, false, false, null)]
    protected Environment _AttachmentType;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777532, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_UseROR")]
    protected Environment _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_IsAttachment")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777539, false, false, false, "0")]
    protected Environment _IsAttachment;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777556, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_IsDetached")]
    protected Environment _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_DocTransactionDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777574, false, false, false, null)]
    protected Environment _DocTransactionDate;
    [Metadata("Generic String", "", false, false, false, "String", 16777588, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_DocumentInHistoryRevision")]
    protected Environment _DocumentInHistoryRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_AttachAsROR")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777584, false, false, false, "0")]
    protected Environment _AttachAsROR;
    [Metadata("Generic String", "", false, false, true, "String", 16777593, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_AttachedBy")]
    protected Environment _AttachedBy;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_ObjectInstance")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1053198, false, false, false, null)]
    protected Environment _ObjectInstance;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050784, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_ObjectTypeId")]
    protected Environment _ObjectTypeId;
    [Metadata("Generic String", "", false, false, true, "String", 16777586, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_DocumentNameRev")]
    protected Environment _DocumentNameRev;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_DocumentName")]
    [Metadata("Generic String", "", false, false, true, "String", 1050228, false, false, false, null)]
    protected Environment _DocumentName;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1048606, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_Document")]
    protected Environment _Document;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 16777585, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_DocumentInHistory")]
    protected Environment _DocumentInHistory;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Environment_ObjectTypeName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050572, false, false, false, null)]
    protected Environment _ObjectTypeName;

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

    public Environment AttachedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedBy));
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

    public Environment DocumentNameRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentNameRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentNameRev));
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

    public Environment DocumentInHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentInHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentInHistory));
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
