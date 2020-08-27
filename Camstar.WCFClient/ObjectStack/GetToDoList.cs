// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetToDoList
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
  public class GetToDoList : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_MessageCategoriesToRetrieve")]
    protected NamedObjectRef[] _MessageCategoriesToRetrieve;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_RoleFilter")]
    protected NamedObjectRef _RoleFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_MessageCategoryFilter")]
    protected NamedObjectRef _MessageCategoryFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_SortOrder")]
    protected Enumeration<ToDoListSortOrderEnum, int> _SortOrder;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_OrganizationFilter")]
    protected NamedObjectRef _OrganizationFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_ToDoListDetail")]
    protected Camstar.WCF.ObjectStack.ToDoListDetail[] _ToDoListDetail;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_FilterForConcierge")]
    protected Primitive<bool> _FilterForConcierge;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_DisplayRoleMessages")]
    protected Primitive<bool> _DisplayRoleMessages;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_TODOListCount")]
    protected Primitive<int> _TODOListCount;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_FilterForMsgCenter")]
    protected Primitive<bool> _FilterForMsgCenter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_TODOListSize")]
    protected Primitive<int> _TODOListSize;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_DateFromFilter")]
    protected Primitive<DateTime> _DateFromFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_DateToFilter")]
    protected Primitive<DateTime> _DateToFilter;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_TODOListStartRow")]
    protected Primitive<int> _TODOListStartRow;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_Identifier")]
    protected BaseObjectRef _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "GetToDoList_AssigneeFilter")]
    protected NamedObjectRef _AssigneeFilter;

    public override bool Equals(object obj)
    {
      return obj is GetToDoList && this.CompareArrays((Array) this._MessageCategoriesToRetrieve, (Array) ((GetToDoList) obj)._MessageCategoriesToRetrieve) && (object.Equals((object) this._RoleFilter, (object) ((GetToDoList) obj)._RoleFilter) && object.Equals((object) this._MessageCategoryFilter, (object) ((GetToDoList) obj)._MessageCategoryFilter)) && (object.Equals((object) this._SortOrder, (object) ((GetToDoList) obj)._SortOrder) && object.Equals((object) this._OrganizationFilter, (object) ((GetToDoList) obj)._OrganizationFilter) && (this.CompareArrays((Array) this._ToDoListDetail, (Array) ((GetToDoList) obj)._ToDoListDetail) && object.Equals((object) this._FilterForConcierge, (object) ((GetToDoList) obj)._FilterForConcierge))) && (object.Equals((object) this._DisplayRoleMessages, (object) ((GetToDoList) obj)._DisplayRoleMessages) && object.Equals((object) this._TODOListCount, (object) ((GetToDoList) obj)._TODOListCount) && (object.Equals((object) this._FilterForMsgCenter, (object) ((GetToDoList) obj)._FilterForMsgCenter) && object.Equals((object) this._TODOListSize, (object) ((GetToDoList) obj)._TODOListSize)) && (object.Equals((object) this._DateFromFilter, (object) ((GetToDoList) obj)._DateFromFilter) && object.Equals((object) this._DateToFilter, (object) ((GetToDoList) obj)._DateToFilter) && (object.Equals((object) this._TODOListStartRow, (object) ((GetToDoList) obj)._TODOListStartRow) && object.Equals((object) this._Identifier, (object) ((GetToDoList) obj)._Identifier)))) && object.Equals((object) this._AssigneeFilter, (object) ((GetToDoList) obj)._AssigneeFilter) && base.Equals(obj);
    }

    public NamedObjectRef[] MessageCategoriesToRetrieve
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoriesToRetrieve), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (MessageCategoriesToRetrieve));
      }
    }

    public NamedObjectRef RoleFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RoleFilter));
      }
    }

    public NamedObjectRef MessageCategoryFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoryFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MessageCategoryFilter));
      }
    }

    public Enumeration<ToDoListSortOrderEnum, int> SortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SortOrder), (object) value);
      }
      get
      {
        return (Enumeration<ToDoListSortOrderEnum, int>) this.PropertyGet(nameof (SortOrder));
      }
    }

    public NamedObjectRef OrganizationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrganizationFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OrganizationFilter));
      }
    }

    public Camstar.WCF.ObjectStack.ToDoListDetail[] ToDoListDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToDoListDetail), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ToDoListDetail[]) this.PropertyGet(nameof (ToDoListDetail));
      }
    }

    public Primitive<bool> FilterForConcierge
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForConcierge), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (FilterForConcierge));
      }
    }

    public Primitive<bool> DisplayRoleMessages
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayRoleMessages), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayRoleMessages));
      }
    }

    public Primitive<int> TODOListCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TODOListCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TODOListCount));
      }
    }

    public Primitive<bool> FilterForMsgCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForMsgCenter), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (FilterForMsgCenter));
      }
    }

    public Primitive<int> TODOListSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (TODOListSize), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TODOListSize));
      }
    }

    public Primitive<DateTime> DateFromFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateFromFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DateFromFilter));
      }
    }

    public Primitive<DateTime> DateToFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateToFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DateToFilter));
      }
    }

    public Primitive<int> TODOListStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (TODOListStartRow), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TODOListStartRow));
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

    public NamedObjectRef AssigneeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssigneeFilter));
      }
    }
  }
}
