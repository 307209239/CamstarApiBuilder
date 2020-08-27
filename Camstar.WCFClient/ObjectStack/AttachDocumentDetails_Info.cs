// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachDocumentDetails_Info
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
  public class AttachDocumentDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_DocumentDisplayName")]
    protected Info _DocumentDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_FileName")]
    protected Info _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_DocumentRevision")]
    protected Info _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_AttachmentType")]
    protected Info _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_UseROR")]
    protected Info _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_IsAttachment")]
    protected Info _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_IsDetached")]
    protected Info _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_DocTransactionDate")]
    protected Info _DocTransactionDate;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_DocumentInHistoryRevision")]
    protected Info _DocumentInHistoryRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_AttachAsROR")]
    protected Info _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_AttachedBy")]
    protected Info _AttachedBy;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_ObjectInstance")]
    protected Info _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_ObjectTypeId")]
    protected Info _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_DocumentNameRev")]
    protected Info _DocumentNameRev;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_DocumentName")]
    protected Info _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_Document")]
    protected Info _Document;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_DocumentInHistory")]
    protected Info _DocumentInHistory;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "AttachDocumentDetails_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;

    public Info DocumentDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentDisplayName));
      }
    }

    public Info FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileName));
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

    public Info IsAttachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsAttachment));
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

    public Info DocumentInHistoryRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentInHistoryRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentInHistoryRevision));
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

    public Info AttachedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedBy));
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

    public Info DocumentNameRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentNameRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentNameRev));
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

    public Info Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Document));
      }
    }

    public Info DocumentInHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentInHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentInHistory));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
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
  }
}
