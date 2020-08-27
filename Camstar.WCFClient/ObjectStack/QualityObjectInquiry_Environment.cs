// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectInquiry_Environment
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
  public class QualityObjectInquiry_Environment : Inquiry_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_RoleFilter")]
    protected Environment _RoleFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    protected Environment _QualityObject;
    [Metadata("Enumeration for the Quality Status:\r\n1 = Active\r\n2 = Pending\r\n3 = Escalated\r\n5 = Closed\r\n6 = Deleted\r\n7 = Initiated\r\n8 = InReview", "QualityStatusEnum", false, false, false, "Integer", 1048671, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_StatusFilter")]
    protected Environment _StatusFilter;
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, false, "NamedObjectRef", 1051051, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_PriorityLevelFilter")]
    protected Environment _PriorityLevelFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ResourceGroup")]
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    protected Environment _ResourceGroup;
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1052279, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_QualityObjectToExclude")]
    protected Environment _QualityObjectToExclude;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_CategoryFilter")]
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, false, "Integer", 1051206, false, false, true, null)]
    protected Environment _CategoryFilter;
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow. This allows, for example, the re-use of Workflows for Rework processing.\r\n\r\n", "SubWorkflowStep", false, false, false, "NamedSubentityRef", 1049067, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_WorkflowStack")]
    protected Environment _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_FailureModeGroup")]
    [Metadata("Grouping mechanism for the FailureModes.  Identifies the possible FailureModes that can be assigned to an Event.", "FailureModeGroup", false, false, false, "NamedObjectRef", 1051035, false, false, true, null)]
    protected Environment _FailureModeGroup;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_FailureModesFilter")]
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, false, "NamedObjectRef", 1051064, false, true, true, null)]
    protected Environment _FailureModesFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_InitiatorOrgFilter")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051049, false, false, true, null)]
    protected Environment _InitiatorOrgFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_SubClassificationFilter")]
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, false, "NamedObjectRef", 1051146, false, false, true, null)]
    protected Environment _SubClassificationFilter;
    [Metadata("Enumeration for the QualityObjectInquiry pages:\r\n1 = Basic Search\r\n2 = Manage My Records\r\n3 = Cross Reference Search\r\n", "QualityInquiryPageEnum", false, false, false, "Integer", 1052287, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_QualityInquiryPage")]
    protected Environment _QualityInquiryPage;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_OrganizationFilter")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, false, true, null)]
    protected Environment _OrganizationFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_QualityObjectInquiryDetail")]
    [Metadata("The detail information for the QualityObject.", "QualityObjectStatusDetail", false, false, false, "QualityObjectStatusDetail", 1051347, false, false, false, null)]
    protected QualityObjectStatusDetail_Environment _QualityObjectInquiryDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ReporterOrgFilter")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051054, false, false, true, null)]
    protected Environment _ReporterOrgFilter;
    [Metadata("Used to classify QualityObjects", "Classification", false, false, false, "NamedObjectRef", 1051055, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ClassificationFilter")]
    protected Environment _ClassificationFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_IncludeAllRoleRecords")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052010, false, false, false, "0")]
    protected Environment _IncludeAllRoleRecords;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052927, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ReportedFromGMTFilter")]
    protected Environment _ReportedFromGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_OccuredToGMTFilter")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052926, false, false, false, null)]
    protected Environment _OccuredToGMTFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ReportedToGMTFilter")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052928, false, false, false, null)]
    protected Environment _ReportedToGMTFilter;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052925, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_OccuredFromGMTFilter")]
    protected Environment _OccuredFromGMTFilter;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052281, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_InitiatorFilter")]
    protected Environment _InitiatorFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_IdentifierFilter")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051057, false, false, true, null)]
    protected Environment _IdentifierFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_DiscoveryAreaFilter")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051345, false, false, true, null)]
    protected Environment _DiscoveryAreaFilter;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052282, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ReporterFilter")]
    protected Environment _ReporterFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ResourceFilter")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048840, false, false, true, null)]
    protected Environment _ResourceFilter;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ToStep")]
    protected Environment _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_DescriptionFilter")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected Environment _DescriptionFilter;
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1050500, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_WorkflowFilter")]
    protected Environment _WorkflowFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_WorkflowStepFilter")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049822, false, false, true, null)]
    protected Environment _WorkflowStepFilter;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ContainerFilter")]
    protected Environment _ContainerFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_OwnerFilter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    protected Environment _OwnerFilter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectInquiry_Environment_ProductFilter")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected Environment _ProductFilter;

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

    public Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Environment StatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StatusFilter));
      }
    }

    public Environment PriorityLevelFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevelFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityLevelFilter));
      }
    }

    public Environment ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Environment QualityObjectToExclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectToExclude), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObjectToExclude));
      }
    }

    public Environment CategoryFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryFilter));
      }
    }

    public Environment WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public Environment FailureModeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModeGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureModeGroup));
      }
    }

    public Environment FailureModesFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModesFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureModesFilter));
      }
    }

    public Environment InitiatorOrgFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorOrgFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InitiatorOrgFilter));
      }
    }

    public Environment SubClassificationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassificationFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassificationFilter));
      }
    }

    public Environment QualityInquiryPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityInquiryPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityInquiryPage));
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

    public QualityObjectStatusDetail_Environment QualityObjectInquiryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectInquiryDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail_Environment) this.PropertyGet(nameof (QualityObjectInquiryDetail));
      }
    }

    public Environment ReporterOrgFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterOrgFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReporterOrgFilter));
      }
    }

    public Environment ClassificationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassificationFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClassificationFilter));
      }
    }

    public Environment IncludeAllRoleRecords
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeAllRoleRecords), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeAllRoleRecords));
      }
    }

    public Environment ReportedFromGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedFromGMTFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportedFromGMTFilter));
      }
    }

    public Environment OccuredToGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredToGMTFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OccuredToGMTFilter));
      }
    }

    public Environment ReportedToGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedToGMTFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportedToGMTFilter));
      }
    }

    public Environment OccuredFromGMTFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredFromGMTFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OccuredFromGMTFilter));
      }
    }

    public Environment InitiatorFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InitiatorFilter));
      }
    }

    public Environment IdentifierFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IdentifierFilter));
      }
    }

    public Environment DiscoveryAreaFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryAreaFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DiscoveryAreaFilter));
      }
    }

    public Environment ReporterFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReporterFilter));
      }
    }

    public Environment ResourceFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceFilter));
      }
    }

    public Environment ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStep));
      }
    }

    public Environment DescriptionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DescriptionFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DescriptionFilter));
      }
    }

    public Environment WorkflowFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowFilter));
      }
    }

    public Environment WorkflowStepFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStepFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStepFilter));
      }
    }

    public Environment ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerFilter));
      }
    }

    public Environment OwnerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerFilter));
      }
    }

    public Environment ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductFilter));
      }
    }
  }
}
