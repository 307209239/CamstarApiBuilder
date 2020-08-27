// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EligibleContainersInquiry_Info
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
  public class EligibleContainersInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_FilterForCombine")]
    protected Info _FilterForCombine;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_FilterForAssociate")]
    protected Info _FilterForAssociate;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_IncludeIneligibleContainers")]
    protected Info _IncludeIneligibleContainers;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_SingleContainer")]
    protected Info _SingleContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_SingleContainerMismatchAllowed")]
    protected Info _SingleContainerMismatchAllowed;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_ContainersToExclude")]
    protected Info _ContainersToExclude;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_GroupContainer")]
    protected Info _GroupContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_ParentContainer")]
    protected Info _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_CombineType")]
    protected Info _CombineType;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_EligibleContainer")]
    protected Info _EligibleContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_ProductFilter")]
    protected Info _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_QtyLessThanFilter")]
    protected Info _QtyLessThanFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_ContainerNameFilter")]
    protected Info _ContainerNameFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_QtyGreaterThanFilter")]
    protected Info _QtyGreaterThanFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_MfgOrderFilter")]
    protected Info _MfgOrderFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Info_OperationFilter")]
    protected Info _OperationFilter;

    public Info FilterForCombine
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForCombine), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterForCombine));
      }
    }

    public Info FilterForAssociate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForAssociate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterForAssociate));
      }
    }

    public Info IncludeIneligibleContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeIneligibleContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeIneligibleContainers));
      }
    }

    public Info SingleContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (SingleContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SingleContainer));
      }
    }

    public Info SingleContainerMismatchAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (SingleContainerMismatchAllowed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SingleContainerMismatchAllowed));
      }
    }

    public Info ContainersToExclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainersToExclude), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainersToExclude));
      }
    }

    public Info GroupContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GroupContainer));
      }
    }

    public Info ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Info CombineType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CombineType));
      }
    }

    public Info EligibleContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (EligibleContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EligibleContainer));
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

    public Info QtyLessThanFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLessThanFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyLessThanFilter));
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

    public Info QtyGreaterThanFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyGreaterThanFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyGreaterThanFilter));
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
  }
}
