// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ToDoListDetail_Info
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
  public class ToDoListDetail_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_SubclassificationName")]
    protected Info _SubclassificationName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_ApprovalEntryRole")]
    protected Info _ApprovalEntryRole;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_ClassificationName")]
    protected Info _ClassificationName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_CategoryName")]
    protected Info _CategoryName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_MessageCategoryName")]
    protected Info _MessageCategoryName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_ProcessModel")]
    protected Info _ProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Plan")]
    protected Info _Plan;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_ToDoListItemType")]
    protected Info _ToDoListItemType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_PriorityStatus")]
    protected Info _PriorityStatus;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_NotificationType")]
    protected Info _NotificationType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_MessageCategory")]
    protected Info _MessageCategory;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_ApprovalSheetEntry")]
    protected Info _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Type")]
    protected Info _Type;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_AssignedDate")]
    protected Info _AssignedDate;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_AssignedDateGMT")]
    protected Info _AssignedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_DueDate")]
    protected Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_IdentifierType")]
    protected Info _IdentifierType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_ReportingDate")]
    protected Info _ReportingDate;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_ReportingDateGMT")]
    protected Info _ReportingDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Identifier")]
    protected Info _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_DueDateGMT")]
    protected Info _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_ApprovalSheetParent")]
    protected Info _ApprovalSheetParent;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_TriageComplete")]
    protected Info _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_IdentifierCDOType")]
    protected Info _IdentifierCDOType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_DataCollectionDefined")]
    protected Info _DataCollectionDefined;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_OwnerName")]
    protected Info _OwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_RoleName")]
    protected Info _RoleName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_DisplayMessage")]
    protected Info _DisplayMessage;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Info_Name")]
    protected Info _Name;

    public Info Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Category));
      }
    }

    public Info SubclassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubclassificationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubclassificationName));
      }
    }

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info ApprovalEntryRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntryRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalEntryRole));
      }
    }

    public Info PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Info ClassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassificationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClassificationName));
      }
    }

    public Info CategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryName));
      }
    }

    public Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Info MessageCategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MessageCategoryName));
      }
    }

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public Info ProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessModel));
      }
    }

    public Info Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Plan));
      }
    }

    public Info SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Info ToDoListItemType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToDoListItemType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToDoListItemType));
      }
    }

    public Info PriorityStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityStatus));
      }
    }

    public Info NotificationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotificationType));
      }
    }

    public Info MessageCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MessageCategory));
      }
    }

    public Info ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetEntry));
      }
    }

    public Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
      }
    }

    public Info Type
    {
      [param: In] set
      {
        this.PropertySet(nameof (Type), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Type));
      }
    }

    public Info AssignedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssignedDate));
      }
    }

    public Info AssignedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssignedDateGMT));
      }
    }

    public Info DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDate));
      }
    }

    public Info IdentifierType
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IdentifierType));
      }
    }

    public Info ReportingDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportingDate));
      }
    }

    public Info ReportingDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportingDateGMT));
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

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public Info ApprovalSheetParent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetParent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetParent));
      }
    }

    public Info TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Info IdentifierCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierCDOType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IdentifierCDOType));
      }
    }

    public Info DataCollectionDefined
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDefined), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDefined));
      }
    }

    public Info OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerName));
      }
    }

    public Info RoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RoleName));
      }
    }

    public Info DisplayMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayMessage));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
