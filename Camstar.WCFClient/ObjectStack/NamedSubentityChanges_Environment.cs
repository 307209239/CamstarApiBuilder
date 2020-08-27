// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedSubentityChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BusinessRuleDataChanges_Environment))]
  [KnownType(typeof (ApprovalSheetChanges_Environment))]
  [KnownType(typeof (UIActionChanges_Environment))]
  [KnownType(typeof (StepChanges_Environment))]
  [KnownType(typeof (VendorItemChanges_Environment))]
  [KnownType(typeof (DataPointChanges_Environment))]
  [KnownType(typeof (PathChanges_Environment))]
  [KnownType(typeof (TriageSpecDetailChanges_Environment))]
  [KnownType(typeof (DataPointCollectionChanges_Environment))]
  [KnownType(typeof (BillOfProcessOverrideChanges_Environment))]
  [KnownType(typeof (UIPrefFieldDefChanges_Environment))]
  [KnownType(typeof (DocumentEntryChanges_Environment))]
  [KnownType(typeof (ComputationParamSpecChanges_Environment))]
  [KnownType(typeof (ApprovalDecisionChanges_Environment))]
  [KnownType(typeof (GateChanges_Environment))]
  [KnownType(typeof (HistViewDtlChanges_Environment))]
  [KnownType(typeof (CustomerContactChanges_Environment))]
  [KnownType(typeof (BusinessRuleHandlerDataChanges_Environment))]
  [KnownType(typeof (RouteStepChanges_Environment))]
  [KnownType(typeof (ChecklistChanges_Environment))]
  [KnownType(typeof (UserAttributeChanges_Environment))]
  [KnownType(typeof (LabelTagChanges_Environment))]
  [KnownType(typeof (UIPageFlowStateChanges_Environment))]
  [KnownType(typeof (BizRuleHandlerParameterChanges_Environment))]
  [KnownType(typeof (ProcessItemChanges_Environment))]
  [KnownType(typeof (ESigReqDetailChanges_Environment))]
  [KnownType(typeof (DataPointCollectionGroupChgs_Environment))]
  [KnownType(typeof (MasterDataCatalogDtlChanges_Environment))]
  [KnownType(typeof (ChecklistEntryChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RolePermissionChanges_Environment))]
  [KnownType(typeof (MaterialListItemChanges_Environment))]
  [KnownType(typeof (LocationChanges_Environment))]
  [KnownType(typeof (ProcessObjectChanges_Environment))]
  [KnownType(typeof (UserQueryParameterChanges_Environment))]
  [KnownType(typeof (UIPageFlowActivityChanges_Environment))]
  [Serializable]
  public class NamedSubentityChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO.  SubEntityChanges are used as temporary holding places while the parent CDO is undergoing maintenance.", "SubentityChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Environment_TypeName")]
    [Metadata("Generic String", "", false, false, false, "String", 16779177, false, false, false, null)]
    protected Environment _TypeName;
    [Metadata("Generic String", "", false, false, false, "String", 1050871, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Environment_QueryName1")]
    protected Environment _QueryName1;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Environment_ParentName")]
    [Metadata("Generic String", "", false, false, false, "String", 16779249, false, false, false, null)]
    protected Environment _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Environment_ObjectToChange")]
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO. This typically equates to a list-type field within a Modeling CDO.", "Subentity", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Environment_PhantomQueryName")]
    [Metadata("Generic String", "", false, false, false, "String", 16779176, false, false, false, null)]
    protected Environment _PhantomQueryName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    protected Environment _Name;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Environment TypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TypeName));
      }
    }

    public Environment QueryName1
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName1), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryName1));
      }
    }

    public Environment ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentName));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment PhantomQueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomQueryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PhantomQueryName));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
