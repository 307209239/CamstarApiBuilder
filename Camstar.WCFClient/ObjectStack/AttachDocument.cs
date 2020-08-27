// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachDocument
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
  public class AttachDocument : GenericTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_AttachedFileExtension")]
    protected Primitive<string> _AttachedFileExtension;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_NamedDataObjectMaint")]
    protected NamedDataObjectMaint _NamedDataObjectMaint;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_RevisionedObjectMaint")]
    protected RevisionedObjectMaint _RevisionedObjectMaint;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_DocumentMaint")]
    protected DocumentMaint _DocumentMaint;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_AttachedFileName")]
    protected Primitive<string> _AttachedFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_FilePath")]
    protected Primitive<string> _FilePath;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_AttachmentType")]
    protected Enumeration<AttachmentTypeEnum, int> _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_ObjectType")]
    protected Enumeration<ObjectTypeEnum, int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_DocTransactionDate")]
    protected Primitive<DateTime> _DocTransactionDate;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_IsNDO")]
    protected Primitive<bool> _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_ServiceTypeName")]
    protected Primitive<string> _ServiceTypeName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_InstanceRevision")]
    protected Primitive<string> _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_IsRDO")]
    protected Primitive<bool> _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_IsContainer")]
    protected Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_IsDetached")]
    protected Primitive<bool> _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_AttachAsROR")]
    protected Primitive<bool> _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_ContainerInstance")]
    protected ContainerRef _ContainerInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_ObjectTypeId")]
    protected Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_ObjectInstance")]
    protected BaseObjectRef _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_UseROR")]
    protected Primitive<bool> _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_TrackableObject")]
    protected new BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_CalledExternally")]
    protected Primitive<bool> _CalledExternally;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_InstanceIsROR")]
    protected Primitive<bool> _InstanceIsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_DocumentDescription")]
    protected Primitive<string> _DocumentDescription;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_AttachedDocument")]
    protected RevisionedObjectRef _AttachedDocument;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_DocumentProxy")]
    protected RevisionedObjectRef _DocumentProxy;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_DocumentRevision")]
    protected Primitive<string> _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_DocumentName")]
    protected Primitive<string> _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Identifier")]
    protected Primitive<string> _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_InstanceName")]
    protected Primitive<string> _InstanceName;

    public override bool Equals(object obj)
    {
      return obj is AttachDocument && object.Equals((object) this._AttachedFileExtension, (object) ((AttachDocument) obj)._AttachedFileExtension) && (object.Equals((object) this._NamedDataObjectMaint, (object) ((AttachDocument) obj)._NamedDataObjectMaint) && object.Equals((object) this._RevisionedObjectMaint, (object) ((AttachDocument) obj)._RevisionedObjectMaint)) && (object.Equals((object) this._DocumentMaint, (object) ((AttachDocument) obj)._DocumentMaint) && object.Equals((object) this._AttachedFileName, (object) ((AttachDocument) obj)._AttachedFileName) && (object.Equals((object) this._FilePath, (object) ((AttachDocument) obj)._FilePath) && object.Equals((object) this._AttachmentType, (object) ((AttachDocument) obj)._AttachmentType))) && (object.Equals((object) this._ObjectType, (object) ((AttachDocument) obj)._ObjectType) && object.Equals((object) this._DocTransactionDate, (object) ((AttachDocument) obj)._DocTransactionDate) && (object.Equals((object) this._IsNDO, (object) ((AttachDocument) obj)._IsNDO) && object.Equals((object) this._ServiceTypeName, (object) ((AttachDocument) obj)._ServiceTypeName)) && (object.Equals((object) this._InstanceRevision, (object) ((AttachDocument) obj)._InstanceRevision) && object.Equals((object) this._IsRDO, (object) ((AttachDocument) obj)._IsRDO) && (object.Equals((object) this._IsContainer, (object) ((AttachDocument) obj)._IsContainer) && object.Equals((object) this._ObjectTypeName, (object) ((AttachDocument) obj)._ObjectTypeName)))) && (object.Equals((object) this._IsDetached, (object) ((AttachDocument) obj)._IsDetached) && object.Equals((object) this._AttachAsROR, (object) ((AttachDocument) obj)._AttachAsROR) && (object.Equals((object) this._ContainerInstance, (object) ((AttachDocument) obj)._ContainerInstance) && object.Equals((object) this._ObjectTypeId, (object) ((AttachDocument) obj)._ObjectTypeId)) && (object.Equals((object) this._ObjectInstance, (object) ((AttachDocument) obj)._ObjectInstance) && object.Equals((object) this._UseROR, (object) ((AttachDocument) obj)._UseROR) && (object.Equals((object) this._TrackableObject, (object) ((AttachDocument) obj)._TrackableObject) && object.Equals((object) this._CalledExternally, (object) ((AttachDocument) obj)._CalledExternally))) && (object.Equals((object) this._InstanceIsROR, (object) ((AttachDocument) obj)._InstanceIsROR) && object.Equals((object) this._DocumentDescription, (object) ((AttachDocument) obj)._DocumentDescription) && (object.Equals((object) this._AttachedDocument, (object) ((AttachDocument) obj)._AttachedDocument) && object.Equals((object) this._DocumentProxy, (object) ((AttachDocument) obj)._DocumentProxy)) && (object.Equals((object) this._DocumentRevision, (object) ((AttachDocument) obj)._DocumentRevision) && object.Equals((object) this._DocumentName, (object) ((AttachDocument) obj)._DocumentName) && (object.Equals((object) this._Identifier, (object) ((AttachDocument) obj)._Identifier) && object.Equals((object) this._Operation, (object) ((AttachDocument) obj)._Operation))))) && object.Equals((object) this._InstanceName, (object) ((AttachDocument) obj)._InstanceName) && base.Equals(obj);
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

    public NamedDataObjectMaint NamedDataObjectMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (NamedDataObjectMaint), (object) value);
      }
      get
      {
        return (NamedDataObjectMaint) this.PropertyGet(nameof (NamedDataObjectMaint));
      }
    }

    public RevisionedObjectMaint RevisionedObjectMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (RevisionedObjectMaint), (object) value);
      }
      get
      {
        return (RevisionedObjectMaint) this.PropertyGet(nameof (RevisionedObjectMaint));
      }
    }

    public DocumentMaint DocumentMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentMaint), (object) value);
      }
      get
      {
        return (DocumentMaint) this.PropertyGet(nameof (DocumentMaint));
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

    public Primitive<bool> IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsNDO));
      }
    }

    public Primitive<string> ServiceTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ServiceTypeName));
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

    public Primitive<bool> IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Primitive<bool> IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsContainer));
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

    public ContainerRef ContainerInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerInstance), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ContainerInstance));
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

    public new BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Primitive<bool> CalledExternally
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledExternally), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CalledExternally));
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

    public RevisionedObjectRef DocumentProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentProxy), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DocumentProxy));
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

    public Primitive<string> Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Identifier));
      }
    }

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
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
  }
}
