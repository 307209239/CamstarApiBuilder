// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachDocument_Info
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
  public class AttachDocument_Info : GenericTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_AttachedFileExtension")]
    protected Info _AttachedFileExtension;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_NamedDataObjectMaint")]
    protected NamedDataObjectMaint_Info _NamedDataObjectMaint;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_RevisionedObjectMaint")]
    protected RevisionedObjectMaint_Info _RevisionedObjectMaint;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_DocumentMaint")]
    protected DocumentMaint_Info _DocumentMaint;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_AttachedFileName")]
    protected Info _AttachedFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_FilePath")]
    protected Info _FilePath;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_AttachmentType")]
    protected Info _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_DocTransactionDate")]
    protected Info _DocTransactionDate;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_IsNDO")]
    protected Info _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_ServiceTypeName")]
    protected Info _ServiceTypeName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_InstanceRevision")]
    protected Info _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_IsRDO")]
    protected Info _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_IsContainer")]
    protected Info _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_IsDetached")]
    protected Info _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_AttachAsROR")]
    protected Info _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_ContainerInstance")]
    protected Info _ContainerInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_ObjectTypeId")]
    protected Info _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_ObjectInstance")]
    protected Info _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_UseROR")]
    protected Info _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_TrackableObject")]
    protected new Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_CalledExternally")]
    protected Info _CalledExternally;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_InstanceIsROR")]
    protected Info _InstanceIsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_DocumentDescription")]
    protected Info _DocumentDescription;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_AttachedDocument")]
    protected Info _AttachedDocument;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_DocumentProxy")]
    protected Info _DocumentProxy;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_DocumentRevision")]
    protected Info _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_DocumentName")]
    protected Info _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_Identifier")]
    protected Info _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocument_Info_InstanceName")]
    protected Info _InstanceName;

    public Info AttachedFileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileExtension), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedFileExtension));
      }
    }

    public NamedDataObjectMaint_Info NamedDataObjectMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (NamedDataObjectMaint), (object) value);
      }
      get
      {
        return (NamedDataObjectMaint_Info) this.PropertyGet(nameof (NamedDataObjectMaint));
      }
    }

    public RevisionedObjectMaint_Info RevisionedObjectMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (RevisionedObjectMaint), (object) value);
      }
      get
      {
        return (RevisionedObjectMaint_Info) this.PropertyGet(nameof (RevisionedObjectMaint));
      }
    }

    public DocumentMaint_Info DocumentMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentMaint), (object) value);
      }
      get
      {
        return (DocumentMaint_Info) this.PropertyGet(nameof (DocumentMaint));
      }
    }

    public Info AttachedFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedFileName));
      }
    }

    public Info FilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilePath), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilePath));
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

    public Info DocTransactionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocTransactionDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocTransactionDate));
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

    public Info ServiceTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceTypeName));
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

    public Info ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeName));
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

    public Info AttachAsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachAsROR));
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

    public Info UseROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseROR));
      }
    }

    public new Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Info CalledExternally
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledExternally), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CalledExternally));
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

    public Info DocumentDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentDescription));
      }
    }

    public Info AttachedDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocument), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedDocument));
      }
    }

    public Info DocumentProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentProxy));
      }
    }

    public Info DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentRevision));
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

    public Info Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Identifier));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
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
  }
}
