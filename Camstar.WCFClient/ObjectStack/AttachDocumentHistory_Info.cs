// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachDocumentHistory_Info
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
  public class AttachDocumentHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_AttachedFileExtension")]
    protected Info _AttachedFileExtension;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_AttachedFileName")]
    protected Info _AttachedFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_AttachmentType")]
    protected Info _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_DocTransactionDate")]
    protected Info _DocTransactionDate;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_InstanceIsROR")]
    protected Info _InstanceIsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_ObjectInstance")]
    protected Info _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_IsDetached")]
    protected Info _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_UseROR")]
    protected Info _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_ObjectTypeId")]
    protected Info _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_AttachAsROR")]
    protected Info _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_DocumentRevision")]
    protected Info _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_User")]
    protected Info _User;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_InstanceRevision")]
    protected Info _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_InstanceName")]
    protected Info _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_FilePath")]
    protected Info _FilePath;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_DocumentDescription")]
    protected Info _DocumentDescription;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_DocumentName")]
    protected Info _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentHistory_Info_AttachedDocument")]
    protected Info _AttachedDocument;

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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

    public Info User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (User));
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
  }
}
