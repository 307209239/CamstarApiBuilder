// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetToDoList_Info
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
  public class GetToDoList_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_MessageCategoriesToRetrieve")]
    protected Info _MessageCategoriesToRetrieve;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_RoleFilter")]
    protected Info _RoleFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_MessageCategoryFilter")]
    protected Info _MessageCategoryFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_SortOrder")]
    protected Info _SortOrder;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_OrganizationFilter")]
    protected Info _OrganizationFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_ToDoListDetail")]
    protected ToDoListDetail_Info _ToDoListDetail;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_FilterForConcierge")]
    protected Info _FilterForConcierge;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_DisplayRoleMessages")]
    protected Info _DisplayRoleMessages;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_TODOListCount")]
    protected Info _TODOListCount;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_FilterForMsgCenter")]
    protected Info _FilterForMsgCenter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_TODOListSize")]
    protected Info _TODOListSize;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_DateFromFilter")]
    protected Info _DateFromFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_DateToFilter")]
    protected Info _DateToFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_TODOListStartRow")]
    protected Info _TODOListStartRow;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_Identifier")]
    protected Info _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Info_AssigneeFilter")]
    protected Info _AssigneeFilter;

    public Info MessageCategoriesToRetrieve
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoriesToRetrieve), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MessageCategoriesToRetrieve));
      }
    }

    public Info RoleFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RoleFilter));
      }
    }

    public Info MessageCategoryFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoryFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MessageCategoryFilter));
      }
    }

    public Info SortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SortOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SortOrder));
      }
    }

    public Info OrganizationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrganizationFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OrganizationFilter));
      }
    }

    public ToDoListDetail_Info ToDoListDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToDoListDetail), (object) value);
      }
      get
      {
        return (ToDoListDetail_Info) this.PropertyGet(nameof (ToDoListDetail));
      }
    }

    public Info FilterForConcierge
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForConcierge), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterForConcierge));
      }
    }

    public Info DisplayRoleMessages
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayRoleMessages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayRoleMessages));
      }
    }

    public Info TODOListCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TODOListCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TODOListCount));
      }
    }

    public Info FilterForMsgCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForMsgCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterForMsgCenter));
      }
    }

    public Info TODOListSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (TODOListSize), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TODOListSize));
      }
    }

    public Info DateFromFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateFromFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DateFromFilter));
      }
    }

    public Info DateToFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateToFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DateToFilter));
      }
    }

    public Info TODOListStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (TODOListStartRow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TODOListStartRow));
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

    public Info AssigneeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeFilter));
      }
    }
  }
}
