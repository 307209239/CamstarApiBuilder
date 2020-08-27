// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachedDocuments_Info
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
  public class AttachedDocuments_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_FileName")]
    protected Info _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_DocumentDisplayName")]
    protected Info _DocumentDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_InstanceDisplayName")]
    protected Info _InstanceDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_DocumentType")]
    protected Info _DocumentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_AttachAsROR")]
    protected Info _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_EmployeeName")]
    protected Info _EmployeeName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_IsAttachment")]
    protected Info _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_ObjectInstanceRevision")]
    protected Info _ObjectInstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_UseROR")]
    protected Info _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_ObjectInstanceID")]
    protected Info _ObjectInstanceID;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_AttachmentType")]
    protected Info _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_DocumentName")]
    protected Info _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_ObjectTypeId")]
    protected Info _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_DocumentRevision")]
    protected Info _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_DocumentTypeValue")]
    protected Info _DocumentTypeValue;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_ObjectInstance")]
    protected Info _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_ObjectInstanceName")]
    protected Info _ObjectInstanceName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_DocTransactionDate")]
    protected Info _DocTransactionDate;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_IsDetached")]
    protected Info _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_DocumentInHistoryRevision")]
    protected Info _DocumentInHistoryRevision;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_AttachedDocumentInHistory")]
    protected Info _AttachedDocumentInHistory;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_Employee")]
    protected Info _Employee;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_Document")]
    protected Info _Document;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocuments_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;

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

    public Info InstanceDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceDisplayName));
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

    public Info EmployeeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmployeeName));
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

    public Info ObjectInstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceRevision));
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

    public Info ObjectInstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceID));
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

    public Info DocumentTypeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentTypeValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentTypeValue));
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

    public Info ObjectInstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceName));
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

    public Info AttachedDocumentInHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocumentInHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedDocumentInHistory));
      }
    }

    public Info Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Employee));
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
