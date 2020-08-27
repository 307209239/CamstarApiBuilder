// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetAttachedDocuments_Info
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
  public class GetAttachedDocuments_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_FileNameProxy")]
    protected Info _FileNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_AttachmentType")]
    protected Info _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ObjectTypeProxy")]
    protected Info _ObjectTypeProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_DocumentType")]
    protected Info _DocumentType;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_AttachedDocuments")]
    protected AttachedDocuments_Info _AttachedDocuments;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_AttachAsRORProxy")]
    protected Info _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_DocTransactionDateProxy")]
    protected Info _DocTransactionDateProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_FromTimeStamp")]
    protected Info _FromTimeStamp;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ObjectTypeIdProxy")]
    protected Info _ObjectTypeIdProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_IsRDO")]
    protected Info _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_IsNDO")]
    protected Info _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ObjectTypeId")]
    protected Info _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_DocumentRevisionProxy")]
    protected Info _DocumentRevisionProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ShowOnlyROR")]
    protected Info _ShowOnlyROR;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ObjectInstanceRevisionProxy")]
    protected Info _ObjectInstanceRevisionProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_UseRORProxy")]
    protected Info _UseRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_IncludeAttached")]
    protected Info _IncludeAttached;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_InstanceRevision")]
    protected Info _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_IsContainer")]
    protected Info _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_EmployeeNameProxy")]
    protected Info _EmployeeNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_DocumentNameProxy")]
    protected Info _DocumentNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ToTimestamp")]
    protected Info _ToTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_IncludeDetached")]
    protected Info _IncludeDetached;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_InstanceIsROR")]
    protected Info _InstanceIsROR;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ContainerInstance")]
    protected Info _ContainerInstance;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_IsDetachedProxy")]
    protected Info _IsDetachedProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ObjectInstanceNameProxy")]
    protected Info _ObjectInstanceNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_IsAttachmentProxy")]
    protected Info _IsAttachmentProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ObjectInstance")]
    protected Info _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_IsDetached")]
    protected Info _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_FileExtension")]
    protected Info _FileExtension;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_DescriptionProxy")]
    protected Info _DescriptionProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_EmployeeProxy")]
    protected Info _EmployeeProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_DocumentsProxy")]
    protected Info _DocumentsProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_InstanceName")]
    protected Info _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_AttachedDocumentInHistoryProxy")]
    protected Info _AttachedDocumentInHistoryProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_EmployeeFilter")]
    protected Info _EmployeeFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_ObjectTypeNameProxy")]
    protected Info _ObjectTypeNameProxy;
    [DataMember(EmitDefaultValue = false, Name = "GetAttachedDocuments_Info_DocumentName")]
    protected Info _DocumentName;

    public Info FileNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileNameProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileNameProxy));
      }
    }

    public Info AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachmentType));
      }
    }

    public Info ObjectTypeProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeProxy));
      }
    }

    public Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Info DocumentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentType));
      }
    }

    public AttachedDocuments_Info AttachedDocuments
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocuments), (object) value);
      }
      get
      {
        return (AttachedDocuments_Info) this.PropertyGet(nameof (AttachedDocuments));
      }
    }

    public Info AttachAsRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsRORProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachAsRORProxy));
      }
    }

    public Info DocTransactionDateProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocTransactionDateProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocTransactionDateProxy));
      }
    }

    public Info FromTimeStamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromTimeStamp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromTimeStamp));
      }
    }

    public Info ObjectTypeIdProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeIdProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeIdProxy));
      }
    }

    public Info IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Info IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsNDO));
      }
    }

    public Info ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public Info DocumentRevisionProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevisionProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentRevisionProxy));
      }
    }

    public Info ShowOnlyROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowOnlyROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowOnlyROR));
      }
    }

    public Info ObjectInstanceRevisionProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceRevisionProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceRevisionProxy));
      }
    }

    public Info UseRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseRORProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseRORProxy));
      }
    }

    public Info IncludeAttached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeAttached), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeAttached));
      }
    }

    public Info InstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceRevision));
      }
    }

    public Info IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Info EmployeeNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeNameProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmployeeNameProxy));
      }
    }

    public Info DocumentNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentNameProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentNameProxy));
      }
    }

    public Info ToTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToTimestamp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToTimestamp));
      }
    }

    public Info IncludeDetached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeDetached), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeDetached));
      }
    }

    public Info InstanceIsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceIsROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceIsROR));
      }
    }

    public Info ContainerInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerInstance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerInstance));
      }
    }

    public Info IsDetachedProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDetachedProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsDetachedProxy));
      }
    }

    public Info ObjectInstanceNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceNameProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceNameProxy));
      }
    }

    public Info IsAttachmentProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachmentProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsAttachmentProxy));
      }
    }

    public Info ObjectInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstance));
      }
    }

    public Info IsDetached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDetached), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsDetached));
      }
    }

    public Info FileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileExtension), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileExtension));
      }
    }

    public Info DescriptionProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DescriptionProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DescriptionProxy));
      }
    }

    public Info EmployeeProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmployeeProxy));
      }
    }

    public Info DocumentsProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentsProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentsProxy));
      }
    }

    public Info InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceName));
      }
    }

    public Info AttachedDocumentInHistoryProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocumentInHistoryProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedDocumentInHistoryProxy));
      }
    }

    public Info EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmployeeFilter));
      }
    }

    public Info ObjectTypeNameProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeNameProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeNameProxy));
      }
    }

    public Info DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentName));
      }
    }
  }
}
