// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectInquiry
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
  public class QualityObjectInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_RoleFilter")]
    protected NamedObjectRef _RoleFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_StatusFilter")]
    protected Enumeration<QualityStatusEnum, int> _StatusFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_PriorityLevelFilter")]
    protected NamedObjectRef _PriorityLevelFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_QualityObjectToExclude")]
    protected NamedObjectRef _QualityObjectToExclude;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_CategoryFilter")]
    protected Enumeration<CategoryEnum, int> _CategoryFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_WorkflowStack")]
    protected NamedSubentityRef _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_FailureModeGroup")]
    protected NamedObjectRef _FailureModeGroup;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_FailureModesFilter")]
    protected NamedObjectRef[] _FailureModesFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_InitiatorOrgFilter")]
    protected NamedObjectRef _InitiatorOrgFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_SubClassificationFilter")]
    protected NamedObjectRef _SubClassificationFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_QualityInquiryPage")]
    protected Enumeration<QualityInquiryPageEnum, int> _QualityInquiryPage;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_OrganizationFilter")]
    protected NamedObjectRef _OrganizationFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_QualityObjectInquiryDetail")]
    protected QualityObjectStatusDetail _QualityObjectInquiryDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ReporterOrgFilter")]
    protected NamedObjectRef _ReporterOrgFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ClassificationFilter")]
    protected NamedObjectRef _ClassificationFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_IncludeAllRoleRecords")]
    protected Primitive<bool> _IncludeAllRoleRecords;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ReportedFromGMTFilter")]
    protected Primitive<DateTime> _ReportedFromGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_OccuredToGMTFilter")]
    protected Primitive<DateTime> _OccuredToGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ReportedToGMTFilter")]
    protected Primitive<DateTime> _ReportedToGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_OccuredFromGMTFilter")]
    protected Primitive<DateTime> _OccuredFromGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_InitiatorFilter")]
    protected NamedObjectRef _InitiatorFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_IdentifierFilter")]
    protected Primitive<string> _IdentifierFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_DiscoveryAreaFilter")]
    protected Primitive<string> _DiscoveryAreaFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ReporterFilter")]
    protected NamedObjectRef _ReporterFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ResourceFilter")]
    protected Primitive<string> _ResourceFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ToStep")]
    protected NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_DescriptionFilter")]
    protected Primitive<string> _DescriptionFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_WorkflowFilter")]
    protected RevisionedObjectRef _WorkflowFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_WorkflowStepFilter")]
    protected Primitive<string> _WorkflowStepFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ContainerFilter")]
    protected Primitive<string> _ContainerFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_OwnerFilter")]
    protected NamedObjectRef _OwnerFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_ProductFilter")]
    protected RevisionedObjectRef _ProductFilter;

    public override bool Equals(object obj)
    {
      return obj is QualityObjectInquiry && object.Equals((object) this._RoleFilter, (object) ((QualityObjectInquiry) obj)._RoleFilter) && (object.Equals((object) this._QualityObject, (object) ((QualityObjectInquiry) obj)._QualityObject) && object.Equals((object) this._StatusFilter, (object) ((QualityObjectInquiry) obj)._StatusFilter)) && (object.Equals((object) this._PriorityLevelFilter, (object) ((QualityObjectInquiry) obj)._PriorityLevelFilter) && object.Equals((object) this._ResourceGroup, (object) ((QualityObjectInquiry) obj)._ResourceGroup) && (object.Equals((object) this._QualityObjectToExclude, (object) ((QualityObjectInquiry) obj)._QualityObjectToExclude) && object.Equals((object) this._CategoryFilter, (object) ((QualityObjectInquiry) obj)._CategoryFilter))) && (object.Equals((object) this._WorkflowStack, (object) ((QualityObjectInquiry) obj)._WorkflowStack) && object.Equals((object) this._FailureModeGroup, (object) ((QualityObjectInquiry) obj)._FailureModeGroup) && (this.CompareArrays((Array) this._FailureModesFilter, (Array) ((QualityObjectInquiry) obj)._FailureModesFilter) && object.Equals((object) this._InitiatorOrgFilter, (object) ((QualityObjectInquiry) obj)._InitiatorOrgFilter)) && (object.Equals((object) this._SubClassificationFilter, (object) ((QualityObjectInquiry) obj)._SubClassificationFilter) && object.Equals((object) this._QualityInquiryPage, (object) ((QualityObjectInquiry) obj)._QualityInquiryPage) && (object.Equals((object) this._OrganizationFilter, (object) ((QualityObjectInquiry) obj)._OrganizationFilter) && object.Equals((object) this._QualityObjectInquiryDetail, (object) ((QualityObjectInquiry) obj)._QualityObjectInquiryDetail)))) && (object.Equals((object) this._ReporterOrgFilter, (object) ((QualityObjectInquiry) obj)._ReporterOrgFilter) && object.Equals((object) this._ClassificationFilter, (object) ((QualityObjectInquiry) obj)._ClassificationFilter) && (object.Equals((object) this._IncludeAllRoleRecords, (object) ((QualityObjectInquiry) obj)._IncludeAllRoleRecords) && object.Equals((object) this._ReportedFromGMTFilter, (object) ((QualityObjectInquiry) obj)._ReportedFromGMTFilter)) && (object.Equals((object) this._OccuredToGMTFilter, (object) ((QualityObjectInquiry) obj)._OccuredToGMTFilter) && object.Equals((object) this._ReportedToGMTFilter, (object) ((QualityObjectInquiry) obj)._ReportedToGMTFilter) && (object.Equals((object) this._OccuredFromGMTFilter, (object) ((QualityObjectInquiry) obj)._OccuredFromGMTFilter) && object.Equals((object) this._InitiatorFilter, (object) ((QualityObjectInquiry) obj)._InitiatorFilter))) && (object.Equals((object) this._IdentifierFilter, (object) ((QualityObjectInquiry) obj)._IdentifierFilter) && object.Equals((object) this._DiscoveryAreaFilter, (object) ((QualityObjectInquiry) obj)._DiscoveryAreaFilter) && (object.Equals((object) this._ReporterFilter, (object) ((QualityObjectInquiry) obj)._ReporterFilter) && object.Equals((object) this._ResourceFilter, (object) ((QualityObjectInquiry) obj)._ResourceFilter)) && (object.Equals((object) this._ToStep, (object) ((QualityObjectInquiry) obj)._ToStep) && object.Equals((object) this._DescriptionFilter, (object) ((QualityObjectInquiry) obj)._DescriptionFilter) && (object.Equals((object) this._WorkflowFilter, (object) ((QualityObjectInquiry) obj)._WorkflowFilter) && object.Equals((object) this._WorkflowStepFilter, (object) ((QualityObjectInquiry) obj)._WorkflowStepFilter))))) && (object.Equals((object) this._ContainerFilter, (object) ((QualityObjectInquiry) obj)._ContainerFilter) && object.Equals((object) this._OwnerFilter, (object) ((QualityObjectInquiry) obj)._OwnerFilter) && object.Equals((object) this._ProductFilter, (object) ((QualityObjectInquiry) obj)._ProductFilter)) && base.Equals(obj);
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

    public Enumeration<QualityStatusEnum, int> StatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusFilter), (object) value);
      }
      get
      {
        return (Enumeration<QualityStatusEnum, int>) this.PropertyGet(nameof (StatusFilter));
      }
    }

    public NamedObjectRef PriorityLevelFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevelFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityLevelFilter));
      }
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public NamedObjectRef QualityObjectToExclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectToExclude), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObjectToExclude));
      }
    }

    public Enumeration<CategoryEnum, int> CategoryFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryFilter), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (CategoryFilter));
      }
    }

    public NamedSubentityRef WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public NamedObjectRef FailureModeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModeGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureModeGroup));
      }
    }

    public NamedObjectRef[] FailureModesFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModesFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (FailureModesFilter));
      }
    }

    public NamedObjectRef InitiatorOrgFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorOrgFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (InitiatorOrgFilter));
      }
    }

    public NamedObjectRef SubClassificationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassificationFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassificationFilter));
      }
    }

    public Enumeration<QualityInquiryPageEnum, int> QualityInquiryPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityInquiryPage), (object) value);
      }
      get
      {
        return (Enumeration<QualityInquiryPageEnum, int>) this.PropertyGet(nameof (QualityInquiryPage));
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

    public QualityObjectStatusDetail QualityObjectInquiryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectInquiryDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail) this.PropertyGet(nameof (QualityObjectInquiryDetail));
      }
    }

    public NamedObjectRef ReporterOrgFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterOrgFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReporterOrgFilter));
      }
    }

    public NamedObjectRef ClassificationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassificationFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ClassificationFilter));
      }
    }

    public Primitive<bool> IncludeAllRoleRecords
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeAllRoleRecords), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeAllRoleRecords));
      }
    }

    public Primitive<DateTime> ReportedFromGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedFromGMTFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportedFromGMTFilter));
      }
    }

    public Primitive<DateTime> OccuredToGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredToGMTFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OccuredToGMTFilter));
      }
    }

    public Primitive<DateTime> ReportedToGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedToGMTFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportedToGMTFilter));
      }
    }

    public Primitive<DateTime> OccuredFromGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredFromGMTFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OccuredFromGMTFilter));
      }
    }

    public NamedObjectRef InitiatorFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (InitiatorFilter));
      }
    }

    public Primitive<string> IdentifierFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IdentifierFilter));
      }
    }

    public Primitive<string> DiscoveryAreaFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryAreaFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DiscoveryAreaFilter));
      }
    }

    public NamedObjectRef ReporterFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReporterFilter));
      }
    }

    public Primitive<string> ResourceFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResourceFilter));
      }
    }

    public NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
      }
    }

    public Primitive<string> DescriptionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DescriptionFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DescriptionFilter));
      }
    }

    public RevisionedObjectRef WorkflowFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowFilter), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (WorkflowFilter));
      }
    }

    public Primitive<string> WorkflowStepFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStepFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowStepFilter));
      }
    }

    public Primitive<string> ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerFilter));
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
  }
}
