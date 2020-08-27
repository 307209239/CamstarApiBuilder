// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EligibleContainersInquiry
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
  public class EligibleContainersInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_FilterForCombine")]
    protected Primitive<bool> _FilterForCombine;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_FilterForAssociate")]
    protected Primitive<bool> _FilterForAssociate;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_IncludeIneligibleContainers")]
    protected Primitive<bool> _IncludeIneligibleContainers;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_SingleContainer")]
    protected ContainerRef _SingleContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_SingleContainerMismatchAllowed")]
    protected Primitive<bool> _SingleContainerMismatchAllowed;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_ContainersToExclude")]
    protected ContainerRef[] _ContainersToExclude;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_GroupContainer")]
    protected ContainerRef _GroupContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_ParentContainer")]
    protected ContainerRef _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_CombineType")]
    protected Primitive<int> _CombineType;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_EligibleContainer")]
    protected ContainerRef _EligibleContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_ProductFilter")]
    protected RevisionedObjectRef _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_QtyLessThanFilter")]
    protected Primitive<double> _QtyLessThanFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_ContainerNameFilter")]
    protected Primitive<string> _ContainerNameFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_QtyGreaterThanFilter")]
    protected Primitive<double> _QtyGreaterThanFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_MfgOrderFilter")]
    protected NamedObjectRef _MfgOrderFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_OperationFilter")]
    protected NamedObjectRef _OperationFilter;

    public override bool Equals(object obj)
    {
      return obj is EligibleContainersInquiry && object.Equals((object) this._FilterForCombine, (object) ((EligibleContainersInquiry) obj)._FilterForCombine) && (object.Equals((object) this._FilterForAssociate, (object) ((EligibleContainersInquiry) obj)._FilterForAssociate) && object.Equals((object) this._IncludeIneligibleContainers, (object) ((EligibleContainersInquiry) obj)._IncludeIneligibleContainers)) && (object.Equals((object) this._SingleContainer, (object) ((EligibleContainersInquiry) obj)._SingleContainer) && object.Equals((object) this._SingleContainerMismatchAllowed, (object) ((EligibleContainersInquiry) obj)._SingleContainerMismatchAllowed) && (this.CompareArrays((Array) this._ContainersToExclude, (Array) ((EligibleContainersInquiry) obj)._ContainersToExclude) && object.Equals((object) this._GroupContainer, (object) ((EligibleContainersInquiry) obj)._GroupContainer))) && (object.Equals((object) this._ParentContainer, (object) ((EligibleContainersInquiry) obj)._ParentContainer) && object.Equals((object) this._CombineType, (object) ((EligibleContainersInquiry) obj)._CombineType) && (object.Equals((object) this._EligibleContainer, (object) ((EligibleContainersInquiry) obj)._EligibleContainer) && object.Equals((object) this._ProductFilter, (object) ((EligibleContainersInquiry) obj)._ProductFilter)) && (object.Equals((object) this._QtyLessThanFilter, (object) ((EligibleContainersInquiry) obj)._QtyLessThanFilter) && object.Equals((object) this._ContainerNameFilter, (object) ((EligibleContainersInquiry) obj)._ContainerNameFilter) && (object.Equals((object) this._QtyGreaterThanFilter, (object) ((EligibleContainersInquiry) obj)._QtyGreaterThanFilter) && object.Equals((object) this._MfgOrderFilter, (object) ((EligibleContainersInquiry) obj)._MfgOrderFilter)))) && object.Equals((object) this._OperationFilter, (object) ((EligibleContainersInquiry) obj)._OperationFilter) && base.Equals(obj);
    }

    public Primitive<bool> FilterForCombine
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForCombine), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (FilterForCombine));
      }
    }

    public Primitive<bool> FilterForAssociate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForAssociate), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (FilterForAssociate));
      }
    }

    public Primitive<bool> IncludeIneligibleContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeIneligibleContainers), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeIneligibleContainers));
      }
    }

    public ContainerRef SingleContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (SingleContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (SingleContainer));
      }
    }

    public Primitive<bool> SingleContainerMismatchAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (SingleContainerMismatchAllowed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SingleContainerMismatchAllowed));
      }
    }

    public ContainerRef[] ContainersToExclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainersToExclude), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (ContainersToExclude));
      }
    }

    public ContainerRef GroupContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (GroupContainer));
      }
    }

    public ContainerRef ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Primitive<int> CombineType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CombineType));
      }
    }

    public ContainerRef EligibleContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (EligibleContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (EligibleContainer));
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

    public Primitive<double> QtyLessThanFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLessThanFilter), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyLessThanFilter));
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

    public Primitive<double> QtyGreaterThanFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyGreaterThanFilter), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyGreaterThanFilter));
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
  }
}
