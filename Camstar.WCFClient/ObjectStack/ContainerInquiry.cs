// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerInquiry
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
  public class ContainerInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_ToStartDateFilter")]
    protected Primitive<DateTime> _ToStartDateFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_FromStartDateFilter")]
    protected Primitive<DateTime> _FromStartDateFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_SearchIssuedFromContainers")]
    protected Primitive<bool> _SearchIssuedFromContainers;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_ToStartDate")]
    protected Primitive<DateTime> _ToStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_SearchIssuedToContainers")]
    protected Primitive<bool> _SearchIssuedToContainers;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_ChildContainer")]
    protected ContainerRef _ChildContainer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_SearchEmployeeHistory")]
    protected Primitive<bool> _SearchEmployeeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_SearchOperationHistory")]
    protected Primitive<bool> _SearchOperationHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_FromStartDate")]
    protected Primitive<DateTime> _FromStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_FromIssuedLotFilter")]
    protected Primitive<string> _FromIssuedLotFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_SearchContainersOnly")]
    protected Primitive<bool> _SearchContainersOnly;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_SearchResourceHistory")]
    protected Primitive<bool> _SearchResourceHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_OnHoldFilter")]
    protected Primitive<bool> _OnHoldFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_InReworkFilter")]
    protected Primitive<bool> _InReworkFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_FromIssuedStockPointFilter")]
    protected Primitive<string> _FromIssuedStockPointFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_ProductFilter")]
    protected RevisionedObjectRef _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_EmployeeFilter")]
    protected NamedObjectRef _EmployeeFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_ContainerNameFilter")]
    protected Primitive<string> _ContainerNameFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_OwnerFilter")]
    protected NamedObjectRef _OwnerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_OperationFilter")]
    protected NamedObjectRef _OperationFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_MfgOrderFilter")]
    protected NamedObjectRef _MfgOrderFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_ResourceFilter")]
    protected NamedObjectRef _ResourceFilter;

    public override bool Equals(object obj)
    {
      return obj is ContainerInquiry && object.Equals((object) this._ToStartDateFilter, (object) ((ContainerInquiry) obj)._ToStartDateFilter) && (object.Equals((object) this._Container, (object) ((ContainerInquiry) obj)._Container) && object.Equals((object) this._FromStartDateFilter, (object) ((ContainerInquiry) obj)._FromStartDateFilter)) && (object.Equals((object) this._SearchIssuedFromContainers, (object) ((ContainerInquiry) obj)._SearchIssuedFromContainers) && object.Equals((object) this._ToStartDate, (object) ((ContainerInquiry) obj)._ToStartDate) && (object.Equals((object) this._SearchIssuedToContainers, (object) ((ContainerInquiry) obj)._SearchIssuedToContainers) && object.Equals((object) this._ChildContainer, (object) ((ContainerInquiry) obj)._ChildContainer))) && (object.Equals((object) this._SearchEmployeeHistory, (object) ((ContainerInquiry) obj)._SearchEmployeeHistory) && object.Equals((object) this._SearchOperationHistory, (object) ((ContainerInquiry) obj)._SearchOperationHistory) && (object.Equals((object) this._FromStartDate, (object) ((ContainerInquiry) obj)._FromStartDate) && object.Equals((object) this._FromIssuedLotFilter, (object) ((ContainerInquiry) obj)._FromIssuedLotFilter)) && (object.Equals((object) this._SearchContainersOnly, (object) ((ContainerInquiry) obj)._SearchContainersOnly) && object.Equals((object) this._SearchResourceHistory, (object) ((ContainerInquiry) obj)._SearchResourceHistory) && (object.Equals((object) this._OnHoldFilter, (object) ((ContainerInquiry) obj)._OnHoldFilter) && object.Equals((object) this._InReworkFilter, (object) ((ContainerInquiry) obj)._InReworkFilter)))) && (object.Equals((object) this._FromIssuedStockPointFilter, (object) ((ContainerInquiry) obj)._FromIssuedStockPointFilter) && object.Equals((object) this._ProductFilter, (object) ((ContainerInquiry) obj)._ProductFilter) && (object.Equals((object) this._EmployeeFilter, (object) ((ContainerInquiry) obj)._EmployeeFilter) && object.Equals((object) this._ContainerNameFilter, (object) ((ContainerInquiry) obj)._ContainerNameFilter)) && (object.Equals((object) this._OwnerFilter, (object) ((ContainerInquiry) obj)._OwnerFilter) && object.Equals((object) this._OperationFilter, (object) ((ContainerInquiry) obj)._OperationFilter) && (object.Equals((object) this._MfgOrderFilter, (object) ((ContainerInquiry) obj)._MfgOrderFilter) && object.Equals((object) this._ResourceFilter, (object) ((ContainerInquiry) obj)._ResourceFilter)))) && base.Equals(obj);
    }

    public Primitive<DateTime> ToStartDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStartDateFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ToStartDateFilter));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<DateTime> FromStartDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStartDateFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FromStartDateFilter));
      }
    }

    public Primitive<bool> SearchIssuedFromContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchIssuedFromContainers), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SearchIssuedFromContainers));
      }
    }

    public Primitive<DateTime> ToStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ToStartDate));
      }
    }

    public Primitive<bool> SearchIssuedToContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchIssuedToContainers), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SearchIssuedToContainers));
      }
    }

    public ContainerRef ChildContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ChildContainer));
      }
    }

    public Primitive<bool> SearchEmployeeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchEmployeeHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SearchEmployeeHistory));
      }
    }

    public Primitive<bool> SearchOperationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchOperationHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SearchOperationHistory));
      }
    }

    public Primitive<DateTime> FromStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FromStartDate));
      }
    }

    public Primitive<string> FromIssuedLotFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedLotFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FromIssuedLotFilter));
      }
    }

    public Primitive<bool> SearchContainersOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchContainersOnly), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SearchContainersOnly));
      }
    }

    public Primitive<bool> SearchResourceHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchResourceHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SearchResourceHistory));
      }
    }

    public Primitive<bool> OnHoldFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHoldFilter), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OnHoldFilter));
      }
    }

    public Primitive<bool> InReworkFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InReworkFilter), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InReworkFilter));
      }
    }

    public Primitive<string> FromIssuedStockPointFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedStockPointFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FromIssuedStockPointFilter));
      }
    }

    public RevisionedObjectRef ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProductFilter));
      }
    }

    public NamedObjectRef EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EmployeeFilter));
      }
    }

    public Primitive<string> ContainerNameFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNameFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerNameFilter));
      }
    }

    public NamedObjectRef OwnerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OwnerFilter));
      }
    }

    public NamedObjectRef OperationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OperationFilter));
      }
    }

    public NamedObjectRef MfgOrderFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrderFilter));
      }
    }

    public NamedObjectRef ResourceFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceFilter));
      }
    }
  }
}
