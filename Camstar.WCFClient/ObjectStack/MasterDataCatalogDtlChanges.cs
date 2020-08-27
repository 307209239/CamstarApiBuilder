// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterDataCatalogDtlChanges
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
  public class MasterDataCatalogDtlChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_CDODisplayName")]
    protected Primitive<string> _CDODisplayName;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_AnyWorkflowControlled")]
    protected Primitive<bool> _AnyWorkflowControlled;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_DisplayNameLabelId")]
    protected Primitive<int> _DisplayNameLabelId;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_ApprovalWorkflowControlled")]
    protected Primitive<bool> _ApprovalWorkflowControlled;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_MaintenanceTypeID")]
    protected Primitive<int> _MaintenanceTypeID;

    public override bool Equals(object obj)
    {
      return obj is MasterDataCatalogDtlChanges && object.Equals((object) this._Comments, (object) ((MasterDataCatalogDtlChanges) obj)._Comments) && (object.Equals((object) this._CDODisplayName, (object) ((MasterDataCatalogDtlChanges) obj)._CDODisplayName) && object.Equals((object) this._ObjectToChange, (object) ((MasterDataCatalogDtlChanges) obj)._ObjectToChange)) && (object.Equals((object) this._ListItemToChange, (object) ((MasterDataCatalogDtlChanges) obj)._ListItemToChange) && object.Equals((object) this._AnyWorkflowControlled, (object) ((MasterDataCatalogDtlChanges) obj)._AnyWorkflowControlled) && (object.Equals((object) this._DisplayNameLabelId, (object) ((MasterDataCatalogDtlChanges) obj)._DisplayNameLabelId) && object.Equals((object) this._ApprovalWorkflowControlled, (object) ((MasterDataCatalogDtlChanges) obj)._ApprovalWorkflowControlled))) && object.Equals((object) this._MaintenanceTypeID, (object) ((MasterDataCatalogDtlChanges) obj)._MaintenanceTypeID) && base.Equals(obj);
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public Primitive<string> CDODisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CDODisplayName));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<bool> AnyWorkflowControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (AnyWorkflowControlled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AnyWorkflowControlled));
      }
    }

    public Primitive<int> DisplayNameLabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayNameLabelId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DisplayNameLabelId));
      }
    }

    public Primitive<bool> ApprovalWorkflowControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalWorkflowControlled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApprovalWorkflowControlled));
      }
    }

    public Primitive<int> MaintenanceTypeID
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceTypeID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MaintenanceTypeID));
      }
    }
  }
}
