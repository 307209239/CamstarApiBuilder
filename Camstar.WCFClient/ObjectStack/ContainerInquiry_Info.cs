// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerInquiry_Info
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
  public class ContainerInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_ToStartDateFilter")]
    protected Info _ToStartDateFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_FromStartDateFilter")]
    protected Info _FromStartDateFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_SearchIssuedFromContainers")]
    protected Info _SearchIssuedFromContainers;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_ToStartDate")]
    protected Info _ToStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_SearchIssuedToContainers")]
    protected Info _SearchIssuedToContainers;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_ChildContainer")]
    protected Info _ChildContainer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_SearchEmployeeHistory")]
    protected Info _SearchEmployeeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_SearchOperationHistory")]
    protected Info _SearchOperationHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_FromStartDate")]
    protected Info _FromStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_FromIssuedLotFilter")]
    protected Info _FromIssuedLotFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_SearchContainersOnly")]
    protected Info _SearchContainersOnly;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_SearchResourceHistory")]
    protected Info _SearchResourceHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_OnHoldFilter")]
    protected Info _OnHoldFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_InReworkFilter")]
    protected Info _InReworkFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_FromIssuedStockPointFilter")]
    protected Info _FromIssuedStockPointFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_ProductFilter")]
    protected Info _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_EmployeeFilter")]
    protected Info _EmployeeFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_ContainerNameFilter")]
    protected Info _ContainerNameFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_OwnerFilter")]
    protected Info _OwnerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_OperationFilter")]
    protected Info _OperationFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_MfgOrderFilter")]
    protected Info _MfgOrderFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Info_ResourceFilter")]
    protected Info _ResourceFilter;

    public Info ToStartDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStartDateFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStartDateFilter));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info FromStartDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStartDateFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStartDateFilter));
      }
    }

    public Info SearchIssuedFromContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchIssuedFromContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SearchIssuedFromContainers));
      }
    }

    public Info ToStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStartDate));
      }
    }

    public Info SearchIssuedToContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchIssuedToContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SearchIssuedToContainers));
      }
    }

    public Info ChildContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildContainer));
      }
    }

    public Info SearchEmployeeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchEmployeeHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SearchEmployeeHistory));
      }
    }

    public Info SearchOperationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchOperationHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SearchOperationHistory));
      }
    }

    public Info FromStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStartDate));
      }
    }

    public Info FromIssuedLotFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedLotFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromIssuedLotFilter));
      }
    }

    public Info SearchContainersOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchContainersOnly), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SearchContainersOnly));
      }
    }

    public Info SearchResourceHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchResourceHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SearchResourceHistory));
      }
    }

    public Info OnHoldFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHoldFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnHoldFilter));
      }
    }

    public Info InReworkFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InReworkFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InReworkFilter));
      }
    }

    public Info FromIssuedStockPointFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedStockPointFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromIssuedStockPointFilter));
      }
    }

    public Info ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductFilter));
      }
    }

    public Info EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmployeeFilter));
      }
    }

    public Info ContainerNameFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNameFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerNameFilter));
      }
    }

    public Info OwnerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerFilter));
      }
    }

    public Info OperationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationFilter));
      }
    }

    public Info MfgOrderFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrderFilter));
      }
    }

    public Info ResourceFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceFilter));
      }
    }
  }
}
