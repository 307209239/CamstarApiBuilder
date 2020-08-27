// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedSubentityChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BusinessRuleDataChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DataPointCollectionChanges_Info))]
  [KnownType(typeof (DataPointChanges_Info))]
  [KnownType(typeof (UIPageFlowStateChanges_Info))]
  [KnownType(typeof (UIPageFlowActivityChanges_Info))]
  [KnownType(typeof (ApprovalDecisionChanges_Info))]
  [KnownType(typeof (UserAttributeChanges_Info))]
  [KnownType(typeof (RolePermissionChanges_Info))]
  [KnownType(typeof (UserQueryParameterChanges_Info))]
  [KnownType(typeof (ApprovalSheetChanges_Info))]
  [KnownType(typeof (VendorItemChanges_Info))]
  [KnownType(typeof (BillOfProcessOverrideChanges_Info))]
  [KnownType(typeof (CustomerContactChanges_Info))]
  [KnownType(typeof (BusinessRuleHandlerDataChanges_Info))]
  [KnownType(typeof (ESigReqDetailChanges_Info))]
  [KnownType(typeof (BizRuleHandlerParameterChanges_Info))]
  [KnownType(typeof (UIActionChanges_Info))]
  [KnownType(typeof (LocationChanges_Info))]
  [KnownType(typeof (ChecklistChanges_Info))]
  [KnownType(typeof (ProcessObjectChanges_Info))]
  [KnownType(typeof (DocumentEntryChanges_Info))]
  [KnownType(typeof (StepChanges_Info))]
  [KnownType(typeof (TriageSpecDetailChanges_Info))]
  [KnownType(typeof (PathChanges_Info))]
  [KnownType(typeof (ComputationParamSpecChanges_Info))]
  [KnownType(typeof (HistViewDtlChanges_Info))]
  [KnownType(typeof (GateChanges_Info))]
  [KnownType(typeof (DataPointCollectionGroupChgs_Info))]
  [KnownType(typeof (RouteStepChanges_Info))]
  [KnownType(typeof (LabelTagChanges_Info))]
  [KnownType(typeof (UIPrefFieldDefChanges_Info))]
  [KnownType(typeof (ProcessItemChanges_Info))]
  [KnownType(typeof (ChecklistEntryChanges_Info))]
  [KnownType(typeof (MasterDataCatalogDtlChanges_Info))]
  [KnownType(typeof (MaterialListItemChanges_Info))]
  [Serializable]
  public class NamedSubentityChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Info_TypeName")]
    protected Info _TypeName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Info_QueryName1")]
    protected Info _QueryName1;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Info_ParentName")]
    protected Info _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Info_PhantomQueryName")]
    protected Info _PhantomQueryName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Info_Name")]
    protected Info _Name;

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Info TypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TypeName));
      }
    }

    public Info QueryName1
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName1), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QueryName1));
      }
    }

    public Info ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentName));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info PhantomQueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomQueryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PhantomQueryName));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
