// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ToDoListDetail
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
  public class ToDoListDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Category")]
    protected Enumeration<CategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_SubclassificationName")]
    protected Primitive<string> _SubclassificationName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_ApprovalEntryRole")]
    protected NamedObjectRef _ApprovalEntryRole;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_ClassificationName")]
    protected Primitive<string> _ClassificationName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_CategoryName")]
    protected Primitive<string> _CategoryName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_MessageCategoryName")]
    protected Primitive<string> _MessageCategoryName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_ProcessModel")]
    protected NamedSubentityRef _ProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Plan")]
    protected NamedSubentityRef _Plan;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_ToDoListItemType")]
    protected Enumeration<ConciergePageMappingEnum, string> _ToDoListItemType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_PriorityStatus")]
    protected Enumeration<PriorityStatusEnum, int> _PriorityStatus;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_NotificationType")]
    protected Enumeration<NotificationTypeEnum, int> _NotificationType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_MessageCategory")]
    protected NamedObjectRef _MessageCategory;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_ApprovalSheetEntry")]
    protected SubentityRef _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Type")]
    protected Primitive<string> _Type;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_AssignedDate")]
    protected Primitive<DateTime> _AssignedDate;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_AssignedDateGMT")]
    protected Primitive<DateTime> _AssignedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_IdentifierType")]
    protected Primitive<int> _IdentifierType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_ReportingDate")]
    protected Primitive<DateTime> _ReportingDate;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_ReportingDateGMT")]
    protected Primitive<DateTime> _ReportingDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Identifier")]
    protected BaseObjectRef _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Status")]
    protected Primitive<string> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_DueDateGMT")]
    protected Primitive<DateTime> _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_ApprovalSheetParent")]
    protected BaseObjectRef _ApprovalSheetParent;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_TriageComplete")]
    protected Primitive<bool> _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_IdentifierCDOType")]
    protected Primitive<int> _IdentifierCDOType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_DataCollectionDefined")]
    protected Primitive<bool> _DataCollectionDefined;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_OwnerName")]
    protected Primitive<string> _OwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_RoleName")]
    protected Primitive<string> _RoleName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_DisplayMessage")]
    protected Primitive<string> _DisplayMessage;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ToDoListDetail && object.Equals((object) this._Category, (object) ((ToDoListDetail) obj)._Category) && (object.Equals((object) this._SubclassificationName, (object) ((ToDoListDetail) obj)._SubclassificationName) && object.Equals((object) this._Role, (object) ((ToDoListDetail) obj)._Role)) && (object.Equals((object) this._ApprovalEntryRole, (object) ((ToDoListDetail) obj)._ApprovalEntryRole) && object.Equals((object) this._PriorityLevel, (object) ((ToDoListDetail) obj)._PriorityLevel) && (object.Equals((object) this._ClassificationName, (object) ((ToDoListDetail) obj)._ClassificationName) && object.Equals((object) this._CategoryName, (object) ((ToDoListDetail) obj)._CategoryName))) && (object.Equals((object) this._QualityObject, (object) ((ToDoListDetail) obj)._QualityObject) && object.Equals((object) this._MessageCategoryName, (object) ((ToDoListDetail) obj)._MessageCategoryName) && (object.Equals((object) this._Organization, (object) ((ToDoListDetail) obj)._Organization) && object.Equals((object) this._ProcessModel, (object) ((ToDoListDetail) obj)._ProcessModel)) && (object.Equals((object) this._Plan, (object) ((ToDoListDetail) obj)._Plan) && object.Equals((object) this._SubClassification, (object) ((ToDoListDetail) obj)._SubClassification) && (object.Equals((object) this._ToDoListItemType, (object) ((ToDoListDetail) obj)._ToDoListItemType) && object.Equals((object) this._PriorityStatus, (object) ((ToDoListDetail) obj)._PriorityStatus)))) && (object.Equals((object) this._NotificationType, (object) ((ToDoListDetail) obj)._NotificationType) && object.Equals((object) this._MessageCategory, (object) ((ToDoListDetail) obj)._MessageCategory) && (object.Equals((object) this._ApprovalSheetEntry, (object) ((ToDoListDetail) obj)._ApprovalSheetEntry) && object.Equals((object) this._Classification, (object) ((ToDoListDetail) obj)._Classification)) && (object.Equals((object) this._Type, (object) ((ToDoListDetail) obj)._Type) && object.Equals((object) this._AssignedDate, (object) ((ToDoListDetail) obj)._AssignedDate) && (object.Equals((object) this._AssignedDateGMT, (object) ((ToDoListDetail) obj)._AssignedDateGMT) && object.Equals((object) this._DueDate, (object) ((ToDoListDetail) obj)._DueDate))) && (object.Equals((object) this._IdentifierType, (object) ((ToDoListDetail) obj)._IdentifierType) && object.Equals((object) this._ReportingDate, (object) ((ToDoListDetail) obj)._ReportingDate) && (object.Equals((object) this._ReportingDateGMT, (object) ((ToDoListDetail) obj)._ReportingDateGMT) && object.Equals((object) this._Identifier, (object) ((ToDoListDetail) obj)._Identifier)) && (object.Equals((object) this._Status, (object) ((ToDoListDetail) obj)._Status) && object.Equals((object) this._DueDateGMT, (object) ((ToDoListDetail) obj)._DueDateGMT) && (object.Equals((object) this._ApprovalSheetParent, (object) ((ToDoListDetail) obj)._ApprovalSheetParent) && object.Equals((object) this._TriageComplete, (object) ((ToDoListDetail) obj)._TriageComplete))))) && (object.Equals((object) this._IdentifierCDOType, (object) ((ToDoListDetail) obj)._IdentifierCDOType) && object.Equals((object) this._DataCollectionDefined, (object) ((ToDoListDetail) obj)._DataCollectionDefined) && (object.Equals((object) this._OwnerName, (object) ((ToDoListDetail) obj)._OwnerName) && object.Equals((object) this._RoleName, (object) ((ToDoListDetail) obj)._RoleName)) && (object.Equals((object) this._DisplayMessage, (object) ((ToDoListDetail) obj)._DisplayMessage) && object.Equals((object) this._Owner, (object) ((ToDoListDetail) obj)._Owner) && object.Equals((object) this._Name, (object) ((ToDoListDetail) obj)._Name))) && base.Equals(obj);
    }

    public Enumeration<CategoryEnum, int> Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (Category));
      }
    }

    public Primitive<string> SubclassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubclassificationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SubclassificationName));
      }
    }

    public NamedObjectRef Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Role));
      }
    }

    public NamedObjectRef ApprovalEntryRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntryRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalEntryRole));
      }
    }

    public NamedObjectRef PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Primitive<string> ClassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassificationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ClassificationName));
      }
    }

    public Primitive<string> CategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CategoryName));
      }
    }

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Primitive<string> MessageCategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MessageCategoryName));
      }
    }

    public NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public NamedSubentityRef ProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModel), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessModel));
      }
    }

    public NamedSubentityRef Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Plan));
      }
    }

    public NamedObjectRef SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Enumeration<ConciergePageMappingEnum, string> ToDoListItemType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToDoListItemType), (object) value);
      }
      get
      {
        return (Enumeration<ConciergePageMappingEnum, string>) this.PropertyGet(nameof (ToDoListItemType));
      }
    }

    public Enumeration<PriorityStatusEnum, int> PriorityStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityStatus), (object) value);
      }
      get
      {
        return (Enumeration<PriorityStatusEnum, int>) this.PropertyGet(nameof (PriorityStatus));
      }
    }

    public Enumeration<NotificationTypeEnum, int> NotificationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationType), (object) value);
      }
      get
      {
        return (Enumeration<NotificationTypeEnum, int>) this.PropertyGet(nameof (NotificationType));
      }
    }

    public NamedObjectRef MessageCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MessageCategory));
      }
    }

    public SubentityRef ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ApprovalSheetEntry));
      }
    }

    public NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public Primitive<string> Type
    {
      [param: In] set
      {
        this.PropertySet(nameof (Type), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Type));
      }
    }

    public Primitive<DateTime> AssignedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (AssignedDate));
      }
    }

    public Primitive<DateTime> AssignedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (AssignedDateGMT));
      }
    }

    public Primitive<DateTime> DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDate));
      }
    }

    public Primitive<int> IdentifierType
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IdentifierType));
      }
    }

    public Primitive<DateTime> ReportingDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportingDate));
      }
    }

    public Primitive<DateTime> ReportingDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportingDateGMT));
      }
    }

    public BaseObjectRef Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Identifier));
      }
    }

    public Primitive<string> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Status));
      }
    }

    public Primitive<DateTime> DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public BaseObjectRef ApprovalSheetParent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetParent), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ApprovalSheetParent));
      }
    }

    public Primitive<bool> TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Primitive<int> IdentifierCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierCDOType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IdentifierCDOType));
      }
    }

    public Primitive<bool> DataCollectionDefined
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDefined), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DataCollectionDefined));
      }
    }

    public Primitive<string> OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OwnerName));
      }
    }

    public Primitive<string> RoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RoleName));
      }
    }

    public Primitive<string> DisplayMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMessage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayMessage));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
