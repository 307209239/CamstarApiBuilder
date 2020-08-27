// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachDocumentDetails
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
  public class AttachDocumentDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_DocumentDisplayName")]
    protected Primitive<string> _DocumentDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_FileName")]
    protected Primitive<string> _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_ObjectType")]
    protected Enumeration<ObjectTypeEnum, int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_DocumentRevision")]
    protected Primitive<string> _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_AttachmentType")]
    protected Primitive<string> _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_UseROR")]
    protected Primitive<bool> _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_IsAttachment")]
    protected Primitive<bool> _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_IsDetached")]
    protected Primitive<bool> _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_DocTransactionDate")]
    protected Primitive<DateTime> _DocTransactionDate;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_DocumentInHistoryRevision")]
    protected Primitive<string> _DocumentInHistoryRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_AttachAsROR")]
    protected Primitive<bool> _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_AttachedBy")]
    protected Primitive<string> _AttachedBy;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_ObjectInstance")]
    protected BaseObjectRef _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_ObjectTypeId")]
    protected Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_DocumentNameRev")]
    protected Primitive<string> _DocumentNameRev;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_DocumentName")]
    protected Primitive<string> _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Document")]
    protected RevisionedObjectRef _Document;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_DocumentInHistory")]
    protected RevisionedObjectRef _DocumentInHistory;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;

    public override bool Equals(object obj)
    {
      return obj is AttachDocumentDetails && object.Equals((object) this._DocumentDisplayName, (object) ((AttachDocumentDetails) obj)._DocumentDisplayName) && (object.Equals((object) this._FileName, (object) ((AttachDocumentDetails) obj)._FileName) && object.Equals((object) this._ObjectType, (object) ((AttachDocumentDetails) obj)._ObjectType)) && (object.Equals((object) this._DocumentRevision, (object) ((AttachDocumentDetails) obj)._DocumentRevision) && object.Equals((object) this._AttachmentType, (object) ((AttachDocumentDetails) obj)._AttachmentType) && (object.Equals((object) this._UseROR, (object) ((AttachDocumentDetails) obj)._UseROR) && object.Equals((object) this._IsAttachment, (object) ((AttachDocumentDetails) obj)._IsAttachment))) && (object.Equals((object) this._IsDetached, (object) ((AttachDocumentDetails) obj)._IsDetached) && object.Equals((object) this._DocTransactionDate, (object) ((AttachDocumentDetails) obj)._DocTransactionDate) && (object.Equals((object) this._DocumentInHistoryRevision, (object) ((AttachDocumentDetails) obj)._DocumentInHistoryRevision) && object.Equals((object) this._AttachAsROR, (object) ((AttachDocumentDetails) obj)._AttachAsROR)) && (object.Equals((object) this._AttachedBy, (object) ((AttachDocumentDetails) obj)._AttachedBy) && object.Equals((object) this._ObjectInstance, (object) ((AttachDocumentDetails) obj)._ObjectInstance) && (object.Equals((object) this._ObjectTypeId, (object) ((AttachDocumentDetails) obj)._ObjectTypeId) && object.Equals((object) this._DocumentNameRev, (object) ((AttachDocumentDetails) obj)._DocumentNameRev)))) && (object.Equals((object) this._DocumentName, (object) ((AttachDocumentDetails) obj)._DocumentName) && object.Equals((object) this._Document, (object) ((AttachDocumentDetails) obj)._Document) && (object.Equals((object) this._DocumentInHistory, (object) ((AttachDocumentDetails) obj)._DocumentInHistory) && object.Equals((object) this._Description, (object) ((AttachDocumentDetails) obj)._Description)) && object.Equals((object) this._ObjectTypeName, (object) ((AttachDocumentDetails) obj)._ObjectTypeName)) && base.Equals(obj);
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

    public Primitive<string> AttachedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedBy), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttachedBy));
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

    public Primitive<string> DocumentNameRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentNameRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentNameRev));
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

    public RevisionedObjectRef DocumentInHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentInHistory), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DocumentInHistory));
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
