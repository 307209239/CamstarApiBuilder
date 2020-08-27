// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedSubentityChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChecklistEntryChanges))]
  [KnownType(typeof (UIActionChanges))]
  [KnownType(typeof (RolePermissionChanges))]
  [KnownType(typeof (TriageSpecDetailChanges))]
  [KnownType(typeof (UIPrefFieldDefChanges))]
  [KnownType(typeof (ChecklistChanges))]
  [KnownType(typeof (ProcessObjectChanges))]
  [KnownType(typeof (DataPointCollectionChanges))]
  [KnownType(typeof (DataPointCollectionGroupChgs))]
  [KnownType(typeof (DataPointChanges))]
  [KnownType(typeof (UIPageFlowStateChanges))]
  [KnownType(typeof (UIPageFlowActivityChanges))]
  [KnownType(typeof (ApprovalDecisionChanges))]
  [KnownType(typeof (UserQueryParameterChanges))]
  [KnownType(typeof (ApprovalSheetChanges))]
  [KnownType(typeof (VendorItemChanges))]
  [KnownType(typeof (CustomerContactChanges))]
  [KnownType(typeof (BillOfProcessOverrideChanges))]
  [KnownType(typeof (BusinessRuleHandlerDataChanges))]
  [KnownType(typeof (BizRuleHandlerParameterChanges))]
  [KnownType(typeof (ESigReqDetailChanges))]
  [KnownType(typeof (LocationChanges))]
  [KnownType(typeof (BusinessRuleDataChanges))]
  [KnownType(typeof (DocumentEntryChanges))]
  [KnownType(typeof (StepChanges))]
  [KnownType(typeof (PathChanges))]
  [KnownType(typeof (ComputationParamSpecChanges))]
  [KnownType(typeof (HistViewDtlChanges))]
  [KnownType(typeof (GateChanges))]
  [KnownType(typeof (RouteStepChanges))]
  [KnownType(typeof (LabelTagChanges))]
  [KnownType(typeof (ProcessItemChanges))]
  [KnownType(typeof (MasterDataCatalogDtlChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MaterialListItemChanges))]
  [KnownType(typeof (UserAttributeChanges))]
  [Serializable]
  public class NamedSubentityChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_TypeName")]
    protected Primitive<string> _TypeName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_QueryName1")]
    protected Primitive<string> _QueryName1;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_ParentName")]
    protected Primitive<string> _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_PhantomQueryName")]
    protected Primitive<string> _PhantomQueryName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentityChanges_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is NamedSubentityChanges && object.Equals((object) this._ListItemToChange, (object) ((NamedSubentityChanges) obj)._ListItemToChange) && (object.Equals((object) this._DisplayName, (object) ((NamedSubentityChanges) obj)._DisplayName) && object.Equals((object) this._TypeName, (object) ((NamedSubentityChanges) obj)._TypeName)) && (object.Equals((object) this._QueryName1, (object) ((NamedSubentityChanges) obj)._QueryName1) && object.Equals((object) this._ParentName, (object) ((NamedSubentityChanges) obj)._ParentName) && (object.Equals((object) this._ObjectToChange, (object) ((NamedSubentityChanges) obj)._ObjectToChange) && object.Equals((object) this._PhantomQueryName, (object) ((NamedSubentityChanges) obj)._PhantomQueryName))) && (object.Equals((object) this._IsFrozen, (object) ((NamedSubentityChanges) obj)._IsFrozen) && object.Equals((object) this._Name, (object) ((NamedSubentityChanges) obj)._Name)) && base.Equals(obj);
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Primitive<string> TypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TypeName));
      }
    }

    public Primitive<string> QueryName1
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName1), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QueryName1));
      }
    }

    public Primitive<string> ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParentName));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> PhantomQueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomQueryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PhantomQueryName));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
