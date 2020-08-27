// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetToDoList_Environment
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
  public class GetToDoList_Environment : Inquiry_Environment
  {
    [Metadata("Labels that do not exist in any form in the Designer, but are defined as instance data.    It belongs to default label and is in a special label category: OtherUserLabel.  New label ID is created using a server side API call.", "UserLabel", false, false, false, "NamedObjectRef", 1052322, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_MessageCategoriesToRetrieve")]
    protected Environment _MessageCategoriesToRetrieve;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_RoleFilter")]
    protected Environment _RoleFilter;
    [Metadata("Manages Categories available for use in PortalNotification.", "MessageCategoryLabel", false, false, false, "NamedObjectRef", 1053053, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_MessageCategoryFilter")]
    protected Environment _MessageCategoryFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_SortOrder")]
    [Metadata("ToDoListSortOrder", "ToDoListSortOrderEnum", false, false, false, "Integer", 1052312, false, false, true, null)]
    protected Environment _SortOrder;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_OrganizationFilter")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, false, true, null)]
    protected Environment _OrganizationFilter;
    [Metadata("Details of notificaitons (by employee) to be displayed in the Concierge.", "ToDoListDetail", false, false, true, "ToDoListDetail", 1051522, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_ToDoListDetail")]
    protected ToDoListDetail_Environment _ToDoListDetail;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_FilterForConcierge")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052321, false, false, false, "0")]
    protected Environment _FilterForConcierge;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052320, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_DisplayRoleMessages")]
    protected Environment _DisplayRoleMessages;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052326, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_TODOListCount")]
    protected Environment _TODOListCount;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052313, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_FilterForMsgCenter")]
    protected Environment _FilterForMsgCenter;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052234, false, false, false, "-1")]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_TODOListSize")]
    protected Environment _TODOListSize;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052316, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_DateFromFilter")]
    protected Environment _DateFromFilter;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051349, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_DateToFilter")]
    protected Environment _DateToFilter;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052235, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_TODOListStartRow")]
    protected Environment _TODOListStartRow;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_Identifier")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051057, false, false, true, null)]
    protected Environment _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Environment_AssigneeFilter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1051372, false, false, true, null)]
    protected Environment _AssigneeFilter;

    public Environment MessageCategoriesToRetrieve
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoriesToRetrieve), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MessageCategoriesToRetrieve));
      }
    }

    public Environment RoleFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RoleFilter));
      }
    }

    public Environment MessageCategoryFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoryFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MessageCategoryFilter));
      }
    }

    public Environment SortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SortOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SortOrder));
      }
    }

    public Environment OrganizationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrganizationFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OrganizationFilter));
      }
    }

    public ToDoListDetail_Environment ToDoListDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToDoListDetail), (object) value);
      }
      get
      {
        return (ToDoListDetail_Environment) this.PropertyGet(nameof (ToDoListDetail));
      }
    }

    public Environment FilterForConcierge
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForConcierge), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterForConcierge));
      }
    }

    public Environment DisplayRoleMessages
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayRoleMessages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayRoleMessages));
      }
    }

    public Environment TODOListCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TODOListCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TODOListCount));
      }
    }

    public Environment FilterForMsgCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForMsgCenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterForMsgCenter));
      }
    }

    public Environment TODOListSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (TODOListSize), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TODOListSize));
      }
    }

    public Environment DateFromFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateFromFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DateFromFilter));
      }
    }

    public Environment DateToFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateToFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DateToFilter));
      }
    }

    public Environment TODOListStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (TODOListStartRow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TODOListStartRow));
      }
    }

    public Environment Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Identifier));
      }
    }

    public Environment AssigneeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssigneeFilter));
      }
    }
  }
}
