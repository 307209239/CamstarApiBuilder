// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectInquiry_Info
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
  public class QualityObjectInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_RoleFilter")]
    protected Info _RoleFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_StatusFilter")]
    protected Info _StatusFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_PriorityLevelFilter")]
    protected Info _PriorityLevelFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_QualityObjectToExclude")]
    protected Info _QualityObjectToExclude;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_CategoryFilter")]
    protected Info _CategoryFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_FailureModeGroup")]
    protected Info _FailureModeGroup;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_FailureModesFilter")]
    protected Info _FailureModesFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_InitiatorOrgFilter")]
    protected Info _InitiatorOrgFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_SubClassificationFilter")]
    protected Info _SubClassificationFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_QualityInquiryPage")]
    protected Info _QualityInquiryPage;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_OrganizationFilter")]
    protected Info _OrganizationFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_QualityObjectInquiryDetail")]
    protected QualityObjectStatusDetail_Info _QualityObjectInquiryDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ReporterOrgFilter")]
    protected Info _ReporterOrgFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ClassificationFilter")]
    protected Info _ClassificationFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_IncludeAllRoleRecords")]
    protected Info _IncludeAllRoleRecords;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ReportedFromGMTFilter")]
    protected Info _ReportedFromGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_OccuredToGMTFilter")]
    protected Info _OccuredToGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ReportedToGMTFilter")]
    protected Info _ReportedToGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_OccuredFromGMTFilter")]
    protected Info _OccuredFromGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_InitiatorFilter")]
    protected Info _InitiatorFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_IdentifierFilter")]
    protected Info _IdentifierFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_DiscoveryAreaFilter")]
    protected Info _DiscoveryAreaFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ReporterFilter")]
    protected Info _ReporterFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ResourceFilter")]
    protected Info _ResourceFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ToStep")]
    protected Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_DescriptionFilter")]
    protected Info _DescriptionFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_WorkflowFilter")]
    protected Info _WorkflowFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_WorkflowStepFilter")]
    protected Info _WorkflowStepFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ContainerFilter")]
    protected Info _ContainerFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_OwnerFilter")]
    protected Info _OwnerFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Info_ProductFilter")]
    protected Info _ProductFilter;

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

    public Info StatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusFilter));
      }
    }

    public Info PriorityLevelFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevelFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityLevelFilter));
      }
    }

    public Info ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Info QualityObjectToExclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectToExclude), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObjectToExclude));
      }
    }

    public Info CategoryFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryFilter));
      }
    }

    public Info WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public Info FailureModeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModeGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureModeGroup));
      }
    }

    public Info FailureModesFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModesFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureModesFilter));
      }
    }

    public Info InitiatorOrgFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorOrgFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InitiatorOrgFilter));
      }
    }

    public Info SubClassificationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassificationFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassificationFilter));
      }
    }

    public Info QualityInquiryPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityInquiryPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityInquiryPage));
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

    public QualityObjectStatusDetail_Info QualityObjectInquiryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectInquiryDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail_Info) this.PropertyGet(nameof (QualityObjectInquiryDetail));
      }
    }

    public Info ReporterOrgFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterOrgFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReporterOrgFilter));
      }
    }

    public Info ClassificationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassificationFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClassificationFilter));
      }
    }

    public Info IncludeAllRoleRecords
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeAllRoleRecords), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeAllRoleRecords));
      }
    }

    public Info ReportedFromGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedFromGMTFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportedFromGMTFilter));
      }
    }

    public Info OccuredToGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredToGMTFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OccuredToGMTFilter));
      }
    }

    public Info ReportedToGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedToGMTFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportedToGMTFilter));
      }
    }

    public Info OccuredFromGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredFromGMTFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OccuredFromGMTFilter));
      }
    }

    public Info InitiatorFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InitiatorFilter));
      }
    }

    public Info IdentifierFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IdentifierFilter));
      }
    }

    public Info DiscoveryAreaFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryAreaFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DiscoveryAreaFilter));
      }
    }

    public Info ReporterFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReporterFilter));
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

    public Info ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStep));
      }
    }

    public Info DescriptionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DescriptionFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DescriptionFilter));
      }
    }

    public Info WorkflowFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowFilter));
      }
    }

    public Info WorkflowStepFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStepFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStepFilter));
      }
    }

    public Info ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerFilter));
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
  }
}
