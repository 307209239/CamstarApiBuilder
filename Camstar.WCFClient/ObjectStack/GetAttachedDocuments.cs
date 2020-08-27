// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetAttachedDocuments
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
  public class GetAttachedDocuments : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_FileNameProxy")]
    protected Primitive<string>[] _FileNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_AttachmentType")]
    protected Enumeration<AttachmentTypeEnum, int> _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ObjectTypeProxy")]
    protected Enumeration<ObjectTypeEnum, int>[] _ObjectTypeProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ObjectType")]
    protected Enumeration<ObjectTypeEnum, int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_DocumentType")]
    protected Enumeration<DocumentTypeEnum, int> _DocumentType;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_AttachedDocuments")]
    protected Camstar.WCF.ObjectStack.AttachedDocuments[] _AttachedDocuments;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_AttachAsRORProxy")]
    protected Primitive<bool>[] _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_DocTransactionDateProxy")]
    protected Primitive<DateTime>[] _DocTransactionDateProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_FromTimeStamp")]
    protected Primitive<DateTime> _FromTimeStamp;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ObjectTypeIdProxy")]
    protected Primitive<int>[] _ObjectTypeIdProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_IsRDO")]
    protected Primitive<bool> _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_IsNDO")]
    protected Primitive<bool> _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ObjectTypeId")]
    protected Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_DocumentRevisionProxy")]
    protected Primitive<string>[] _DocumentRevisionProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ShowOnlyROR")]
    protected Primitive<bool> _ShowOnlyROR;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ObjectInstanceRevisionProxy")]
    protected Primitive<string>[] _ObjectInstanceRevisionProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_UseRORProxy")]
    protected Primitive<bool>[] _UseRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_IncludeAttached")]
    protected Primitive<bool> _IncludeAttached;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_InstanceRevision")]
    protected Primitive<string> _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_IsContainer")]
    protected Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_EmployeeNameProxy")]
    protected Primitive<string>[] _EmployeeNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_DocumentNameProxy")]
    protected Primitive<string>[] _DocumentNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ToTimestamp")]
    protected Primitive<DateTime> _ToTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_IncludeDetached")]
    protected Primitive<bool> _IncludeDetached;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_InstanceIsROR")]
    protected Primitive<bool> _InstanceIsROR;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ContainerInstance")]
    protected ContainerRef _ContainerInstance;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_IsDetachedProxy")]
    protected Primitive<bool>[] _IsDetachedProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ObjectInstanceNameProxy")]
    protected Primitive<string>[] _ObjectInstanceNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_IsAttachmentProxy")]
    protected Primitive<bool>[] _IsAttachmentProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ObjectInstance")]
    protected BaseObjectRef _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_IsDetached")]
    protected Primitive<bool> _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_FileExtension")]
    protected Primitive<string> _FileExtension;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_DescriptionProxy")]
    protected Primitive<string>[] _DescriptionProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_EmployeeProxy")]
    protected NamedObjectRef[] _EmployeeProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_DocumentsProxy")]
    protected RevisionedObjectRef[] _DocumentsProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_InstanceName")]
    protected Primitive<string> _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_AttachedDocumentInHistoryProxy")]
    protected RevisionedObjectRef[] _AttachedDocumentInHistoryProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_EmployeeFilter")]
    protected NamedObjectRef _EmployeeFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_ObjectTypeNameProxy")]
    protected Primitive<string>[] _ObjectTypeNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_DocumentName")]
    protected RevisionedObjectRef _DocumentName;

    public override bool Equals(object obj)
    {
      return obj is GetAttachedDocuments && this.CompareArrays((Array) this._FileNameProxy, (Array) ((GetAttachedDocuments) obj)._FileNameProxy) && (object.Equals((object) this._AttachmentType, (object) ((GetAttachedDocuments) obj)._AttachmentType) && this.CompareArrays((Array) this._ObjectTypeProxy, (Array) ((GetAttachedDocuments) obj)._ObjectTypeProxy)) && (object.Equals((object) this._ObjectType, (object) ((GetAttachedDocuments) obj)._ObjectType) && object.Equals((object) this._DocumentType, (object) ((GetAttachedDocuments) obj)._DocumentType) && (this.CompareArrays((Array) this._AttachedDocuments, (Array) ((GetAttachedDocuments) obj)._AttachedDocuments) && this.CompareArrays((Array) this._AttachAsRORProxy, (Array) ((GetAttachedDocuments) obj)._AttachAsRORProxy))) && (this.CompareArrays((Array) this._DocTransactionDateProxy, (Array) ((GetAttachedDocuments) obj)._DocTransactionDateProxy) && object.Equals((object) this._FromTimeStamp, (object) ((GetAttachedDocuments) obj)._FromTimeStamp) && (this.CompareArrays((Array) this._ObjectTypeIdProxy, (Array) ((GetAttachedDocuments) obj)._ObjectTypeIdProxy) && object.Equals((object) this._IsRDO, (object) ((GetAttachedDocuments) obj)._IsRDO)) && (object.Equals((object) this._IsNDO, (object) ((GetAttachedDocuments) obj)._IsNDO) && object.Equals((object) this._ObjectTypeId, (object) ((GetAttachedDocuments) obj)._ObjectTypeId) && (this.CompareArrays((Array) this._DocumentRevisionProxy, (Array) ((GetAttachedDocuments) obj)._DocumentRevisionProxy) && object.Equals((object) this._ShowOnlyROR, (object) ((GetAttachedDocuments) obj)._ShowOnlyROR)))) && (this.CompareArrays((Array) this._ObjectInstanceRevisionProxy, (Array) ((GetAttachedDocuments) obj)._ObjectInstanceRevisionProxy) && this.CompareArrays((Array) this._UseRORProxy, (Array) ((GetAttachedDocuments) obj)._UseRORProxy) && (object.Equals((object) this._IncludeAttached, (object) ((GetAttachedDocuments) obj)._IncludeAttached) && object.Equals((object) this._InstanceRevision, (object) ((GetAttachedDocuments) obj)._InstanceRevision)) && (object.Equals((object) this._IsContainer, (object) ((GetAttachedDocuments) obj)._IsContainer) && this.CompareArrays((Array) this._EmployeeNameProxy, (Array) ((GetAttachedDocuments) obj)._EmployeeNameProxy) && (this.CompareArrays((Array) this._DocumentNameProxy, (Array) ((GetAttachedDocuments) obj)._DocumentNameProxy) && object.Equals((object) this._ToTimestamp, (object) ((GetAttachedDocuments) obj)._ToTimestamp))) && (object.Equals((object) this._IncludeDetached, (object) ((GetAttachedDocuments) obj)._IncludeDetached) && object.Equals((object) this._InstanceIsROR, (object) ((GetAttachedDocuments) obj)._InstanceIsROR) && (object.Equals((object) this._ContainerInstance, (object) ((GetAttachedDocuments) obj)._ContainerInstance) && this.CompareArrays((Array) this._IsDetachedProxy, (Array) ((GetAttachedDocuments) obj)._IsDetachedProxy)) && (this.CompareArrays((Array) this._ObjectInstanceNameProxy, (Array) ((GetAttachedDocuments) obj)._ObjectInstanceNameProxy) && this.CompareArrays((Array) this._IsAttachmentProxy, (Array) ((GetAttachedDocuments) obj)._IsAttachmentProxy) && (object.Equals((object) this._ObjectInstance, (object) ((GetAttachedDocuments) obj)._ObjectInstance) && object.Equals((object) this._IsDetached, (object) ((GetAttachedDocuments) obj)._IsDetached))))) && (object.Equals((object) this._FileExtension, (object) ((GetAttachedDocuments) obj)._FileExtension) && this.CompareArrays((Array) this._DescriptionProxy, (Array) ((GetAttachedDocuments) obj)._DescriptionProxy) && (this.CompareArrays((Array) this._EmployeeProxy, (Array) ((GetAttachedDocuments) obj)._EmployeeProxy) && this.CompareArrays((Array) this._DocumentsProxy, (Array) ((GetAttachedDocuments) obj)._DocumentsProxy)) && (object.Equals((object) this._InstanceName, (object) ((GetAttachedDocuments) obj)._InstanceName) && this.CompareArrays((Array) this._AttachedDocumentInHistoryProxy, (Array) ((GetAttachedDocuments) obj)._AttachedDocumentInHistoryProxy) && (object.Equals((object) this._EmployeeFilter, (object) ((GetAttachedDocuments) obj)._EmployeeFilter) && this.CompareArrays((Array) this._ObjectTypeNameProxy, (Array) ((GetAttachedDocuments) obj)._ObjectTypeNameProxy))) && object.Equals((object) this._DocumentName, (object) ((GetAttachedDocuments) obj)._DocumentName)) && base.Equals(obj);
    }

    public Primitive<string>[] FileNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileNameProxy), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (FileNameProxy));
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

    public Enumeration<ObjectTypeEnum, int>[] ObjectTypeProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeProxy), (object) value);
      }
      get
      {
        return (Enumeration<ObjectTypeEnum, int>[]) this.PropertyGet(nameof (ObjectTypeProxy));
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

    public Camstar.WCF.ObjectStack.AttachedDocuments[] AttachedDocuments
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocuments), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.AttachedDocuments[]) this.PropertyGet(nameof (AttachedDocuments));
      }
    }

    public Primitive<bool>[] AttachAsRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsRORProxy), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (AttachAsRORProxy));
      }
    }

    public Primitive<DateTime>[] DocTransactionDateProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocTransactionDateProxy), (object) value);
      }
      get
      {
        return (Primitive<DateTime>[]) this.PropertyGet(nameof (DocTransactionDateProxy));
      }
    }

    public Primitive<DateTime> FromTimeStamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromTimeStamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FromTimeStamp));
      }
    }

    public Primitive<int>[] ObjectTypeIdProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeIdProxy), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (ObjectTypeIdProxy));
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

    public Primitive<string>[] DocumentRevisionProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevisionProxy), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (DocumentRevisionProxy));
      }
    }

    public Primitive<bool> ShowOnlyROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowOnlyROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowOnlyROR));
      }
    }

    public Primitive<string>[] ObjectInstanceRevisionProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceRevisionProxy), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (ObjectInstanceRevisionProxy));
      }
    }

    public Primitive<bool>[] UseRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseRORProxy), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (UseRORProxy));
      }
    }

    public Primitive<bool> IncludeAttached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeAttached), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeAttached));
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

    public Primitive<string>[] EmployeeNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeNameProxy), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (EmployeeNameProxy));
      }
    }

    public Primitive<string>[] DocumentNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentNameProxy), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (DocumentNameProxy));
      }
    }

    public Primitive<DateTime> ToTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToTimestamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ToTimestamp));
      }
    }

    public Primitive<bool> IncludeDetached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeDetached), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeDetached));
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

    public Primitive<bool>[] IsDetachedProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDetachedProxy), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (IsDetachedProxy));
      }
    }

    public Primitive<string>[] ObjectInstanceNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceNameProxy), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (ObjectInstanceNameProxy));
      }
    }

    public Primitive<bool>[] IsAttachmentProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachmentProxy), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (IsAttachmentProxy));
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

    public Primitive<string> FileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileExtension), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileExtension));
      }
    }

    public Primitive<string>[] DescriptionProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DescriptionProxy), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (DescriptionProxy));
      }
    }

    public NamedObjectRef[] EmployeeProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeProxy), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (EmployeeProxy));
      }
    }

    public RevisionedObjectRef[] DocumentsProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentsProxy), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (DocumentsProxy));
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

    public RevisionedObjectRef[] AttachedDocumentInHistoryProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocumentInHistoryProxy), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (AttachedDocumentInHistoryProxy));
      }
    }

    public NamedObjectRef EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EmployeeFilter));
      }
    }

    public Primitive<string>[] ObjectTypeNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeNameProxy), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (ObjectTypeNameProxy));
      }
    }

    public RevisionedObjectRef DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DocumentName));
      }
    }
  }
}
