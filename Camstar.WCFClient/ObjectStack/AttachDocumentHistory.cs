// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachDocumentHistory
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
  public class AttachDocumentHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_AttachedFileExtension")]
    protected Primitive<string> _AttachedFileExtension;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_AttachedFileName")]
    protected Primitive<string> _AttachedFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_AttachmentType")]
    protected Enumeration<AttachmentTypeEnum, int> _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_ObjectType")]
    protected Enumeration<ObjectTypeEnum, int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_DocTransactionDate")]
    protected Primitive<DateTime> _DocTransactionDate;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_InstanceIsROR")]
    protected Primitive<bool> _InstanceIsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_ObjectInstance")]
    protected BaseObjectRef _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_IsDetached")]
    protected Primitive<bool> _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_UseROR")]
    protected Primitive<bool> _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_ObjectTypeId")]
    protected Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_AttachAsROR")]
    protected Primitive<bool> _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_DocumentRevision")]
    protected Primitive<string> _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_User")]
    protected NamedObjectRef _User;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_InstanceRevision")]
    protected Primitive<string> _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_InstanceName")]
    protected Primitive<string> _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_FilePath")]
    protected Primitive<string> _FilePath;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_DocumentDescription")]
    protected Primitive<string> _DocumentDescription;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_DocumentName")]
    protected Primitive<string> _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_AttachedDocument")]
    protected RevisionedObjectRef _AttachedDocument;

    public override bool Equals(object obj)
    {
      return obj is AttachDocumentHistory && object.Equals((object) this._AttachedFileExtension, (object) ((AttachDocumentHistory) obj)._AttachedFileExtension) && (object.Equals((object) this._ExportImportKey, (object) ((AttachDocumentHistory) obj)._ExportImportKey) && object.Equals((object) this._AttachedFileName, (object) ((AttachDocumentHistory) obj)._AttachedFileName)) && (object.Equals((object) this._Comments, (object) ((AttachDocumentHistory) obj)._Comments) && object.Equals((object) this._AttachmentType, (object) ((AttachDocumentHistory) obj)._AttachmentType) && (object.Equals((object) this._ObjectType, (object) ((AttachDocumentHistory) obj)._ObjectType) && object.Equals((object) this._DocTransactionDate, (object) ((AttachDocumentHistory) obj)._DocTransactionDate))) && (object.Equals((object) this._InstanceIsROR, (object) ((AttachDocumentHistory) obj)._InstanceIsROR) && object.Equals((object) this._HistoryId, (object) ((AttachDocumentHistory) obj)._HistoryId) && (object.Equals((object) this._ObjectInstance, (object) ((AttachDocumentHistory) obj)._ObjectInstance) && object.Equals((object) this._IsDetached, (object) ((AttachDocumentHistory) obj)._IsDetached)) && (object.Equals((object) this._UseROR, (object) ((AttachDocumentHistory) obj)._UseROR) && object.Equals((object) this._ObjectTypeId, (object) ((AttachDocumentHistory) obj)._ObjectTypeId) && (object.Equals((object) this._AttachAsROR, (object) ((AttachDocumentHistory) obj)._AttachAsROR) && object.Equals((object) this._DocumentRevision, (object) ((AttachDocumentHistory) obj)._DocumentRevision)))) && (object.Equals((object) this._User, (object) ((AttachDocumentHistory) obj)._User) && object.Equals((object) this._InstanceRevision, (object) ((AttachDocumentHistory) obj)._InstanceRevision) && (object.Equals((object) this._InstanceName, (object) ((AttachDocumentHistory) obj)._InstanceName) && object.Equals((object) this._FilePath, (object) ((AttachDocumentHistory) obj)._FilePath)) && (object.Equals((object) this._DocumentDescription, (object) ((AttachDocumentHistory) obj)._DocumentDescription) && object.Equals((object) this._DocumentName, (object) ((AttachDocumentHistory) obj)._DocumentName) && object.Equals((object) this._AttachedDocument, (object) ((AttachDocumentHistory) obj)._AttachedDocument))) && base.Equals(obj);
    }

    public Primitive<string> AttachedFileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileExtension), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttachedFileExtension));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> AttachedFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttachedFileName));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public Enumeration<AttachmentTypeEnum, int> AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Enumeration<AttachmentTypeEnum, int>) this.PropertyGet(nameof (AttachmentType));
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

    public Primitive<bool> InstanceIsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceIsROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InstanceIsROR));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
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

    public NamedObjectRef User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (User));
      }
    }

    public Primitive<string> InstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceRevision));
      }
    }

    public Primitive<string> InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceName));
      }
    }

    public Primitive<string> FilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilePath), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilePath));
      }
    }

    public Primitive<string> DocumentDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentDescription));
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

    public RevisionedObjectRef AttachedDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocument), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (AttachedDocument));
      }
    }
  }
}
