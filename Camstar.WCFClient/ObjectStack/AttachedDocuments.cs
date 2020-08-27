// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachedDocuments
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
  public class AttachedDocuments : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_FileName")]
    protected Primitive<string> _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_DocumentDisplayName")]
    protected Primitive<string> _DocumentDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_InstanceDisplayName")]
    protected Primitive<string> _InstanceDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_ObjectType")]
    protected Enumeration<ObjectTypeEnum, int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_DocumentType")]
    protected Enumeration<DocumentTypeEnum, int> _DocumentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_AttachAsROR")]
    protected Primitive<bool> _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_EmployeeName")]
    protected Primitive<string> _EmployeeName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_IsAttachment")]
    protected Primitive<bool> _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_ObjectInstanceRevision")]
    protected Primitive<string> _ObjectInstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_UseROR")]
    protected Primitive<bool> _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_ObjectInstanceID")]
    protected Primitive<string> _ObjectInstanceID;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_AttachmentType")]
    protected Primitive<string> _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_DocumentName")]
    protected Primitive<string> _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_ObjectTypeId")]
    protected Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_DocumentRevision")]
    protected Primitive<string> _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_DocumentTypeValue")]
    protected Primitive<string> _DocumentTypeValue;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_ObjectInstance")]
    protected BaseObjectRef _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_ObjectInstanceName")]
    protected Primitive<string> _ObjectInstanceName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_DocTransactionDate")]
    protected Primitive<DateTime> _DocTransactionDate;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_IsDetached")]
    protected Primitive<bool> _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_DocumentInHistoryRevision")]
    protected Primitive<string> _DocumentInHistoryRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_AttachedDocumentInHistory")]
    protected RevisionedObjectRef _AttachedDocumentInHistory;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Employee")]
    protected NamedObjectRef _Employee;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Document")]
    protected RevisionedObjectRef _Document;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;

    public override bool Equals(object obj)
    {
      return obj is AttachedDocuments && object.Equals((object) this._FileName, (object) ((AttachedDocuments) obj)._FileName) && (object.Equals((object) this._DocumentDisplayName, (object) ((AttachedDocuments) obj)._DocumentDisplayName) && object.Equals((object) this._InstanceDisplayName, (object) ((AttachedDocuments) obj)._InstanceDisplayName)) && (object.Equals((object) this._ObjectType, (object) ((AttachedDocuments) obj)._ObjectType) && object.Equals((object) this._DocumentType, (object) ((AttachedDocuments) obj)._DocumentType) && (object.Equals((object) this._AttachAsROR, (object) ((AttachedDocuments) obj)._AttachAsROR) && object.Equals((object) this._EmployeeName, (object) ((AttachedDocuments) obj)._EmployeeName))) && (object.Equals((object) this._IsAttachment, (object) ((AttachedDocuments) obj)._IsAttachment) && object.Equals((object) this._ObjectInstanceRevision, (object) ((AttachedDocuments) obj)._ObjectInstanceRevision) && (object.Equals((object) this._UseROR, (object) ((AttachedDocuments) obj)._UseROR) && object.Equals((object) this._ObjectInstanceID, (object) ((AttachedDocuments) obj)._ObjectInstanceID)) && (object.Equals((object) this._AttachmentType, (object) ((AttachedDocuments) obj)._AttachmentType) && object.Equals((object) this._DocumentName, (object) ((AttachedDocuments) obj)._DocumentName) && (object.Equals((object) this._ObjectTypeId, (object) ((AttachedDocuments) obj)._ObjectTypeId) && object.Equals((object) this._DocumentRevision, (object) ((AttachedDocuments) obj)._DocumentRevision)))) && (object.Equals((object) this._DocumentTypeValue, (object) ((AttachedDocuments) obj)._DocumentTypeValue) && object.Equals((object) this._ObjectInstance, (object) ((AttachedDocuments) obj)._ObjectInstance) && (object.Equals((object) this._ObjectInstanceName, (object) ((AttachedDocuments) obj)._ObjectInstanceName) && object.Equals((object) this._DocTransactionDate, (object) ((AttachedDocuments) obj)._DocTransactionDate)) && (object.Equals((object) this._IsDetached, (object) ((AttachedDocuments) obj)._IsDetached) && object.Equals((object) this._Description, (object) ((AttachedDocuments) obj)._Description) && (object.Equals((object) this._DocumentInHistoryRevision, (object) ((AttachedDocuments) obj)._DocumentInHistoryRevision) && object.Equals((object) this._AttachedDocumentInHistory, (object) ((AttachedDocuments) obj)._AttachedDocumentInHistory))) && (object.Equals((object) this._Employee, (object) ((AttachedDocuments) obj)._Employee) && object.Equals((object) this._Document, (object) ((AttachedDocuments) obj)._Document) && object.Equals((object) this._ObjectTypeName, (object) ((AttachedDocuments) obj)._ObjectTypeName))) && base.Equals(obj);
    }

    public Primitive<string> FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileName));
      }
    }

    public Primitive<string> DocumentDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentDisplayName));
      }
    }

    public Primitive<string> InstanceDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceDisplayName));
      }
    }

    public Enumeration<ObjectTypeEnum, int> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Enumeration<ObjectTypeEnum, int>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Enumeration<DocumentTypeEnum, int> DocumentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentType), (object) value);
      }
      get
      {
        return (Enumeration<DocumentTypeEnum, int>) this.PropertyGet(nameof (DocumentType));
      }
    }

    public Primitive<bool> AttachAsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AttachAsROR));
      }
    }

    public Primitive<string> EmployeeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EmployeeName));
      }
    }

    public Primitive<bool> IsAttachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachment), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsAttachment));
      }
    }

    public Primitive<string> ObjectInstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceRevision));
      }
    }

    public Primitive<bool> UseROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseROR));
      }
    }

    public Primitive<string> ObjectInstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceID), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceID));
      }
    }

    public Primitive<string> AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttachmentType));
      }
    }

    public Primitive<string> DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentName));
      }
    }

    public Primitive<int> ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public Primitive<string> DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentRevision));
      }
    }

    public Primitive<string> DocumentTypeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentTypeValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentTypeValue));
      }
    }

    public BaseObjectRef ObjectInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstance), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ObjectInstance));
      }
    }

    public Primitive<string> ObjectInstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceName));
      }
    }

    public Primitive<DateTime> DocTransactionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocTransactionDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DocTransactionDate));
      }
    }

    public Primitive<bool> IsDetached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDetached), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsDetached));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<string> DocumentInHistoryRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentInHistoryRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentInHistoryRevision));
      }
    }

    public RevisionedObjectRef AttachedDocumentInHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocumentInHistory), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (AttachedDocumentInHistory));
      }
    }

    public NamedObjectRef Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Employee));
      }
    }

    public RevisionedObjectRef Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Document));
      }
    }

    public Primitive<string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
