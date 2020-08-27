// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterDataCatalogDtlChanges_Environment
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
  public class MasterDataCatalogDtlChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Environment_Comments")]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Environment_CDODisplayName")]
    [Metadata("DisplayName", "", false, false, false, "String", 16778032, false, false, false, null)]
    protected Environment _CDODisplayName;
    [Metadata("The detail information for the Master Data Catalog", "MasterDataCatalogDtl", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Environment_ListItemToChange")]
    [Metadata("The detail information for the Master Data Catalog", "MasterDataCatalogDtlChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Environment_AnyWorkflowControlled")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778033, false, false, false, "0")]
    protected Environment _AnyWorkflowControlled;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778984, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Environment_DisplayNameLabelId")]
    protected Environment _DisplayNameLabelId;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Environment_ApprovalWorkflowControlled")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778034, false, false, false, "0")]
    protected Environment _ApprovalWorkflowControlled;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Environment_MaintenanceTypeID")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778031, false, false, false, null)]
    protected Environment _MaintenanceTypeID;

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment CDODisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDODisplayName));
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

    public Environment AnyWorkflowControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (AnyWorkflowControlled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AnyWorkflowControlled));
      }
    }

    public Environment DisplayNameLabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayNameLabelId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayNameLabelId));
      }
    }

    public Environment ApprovalWorkflowControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalWorkflowControlled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalWorkflowControlled));
      }
    }

    public Environment MaintenanceTypeID
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceTypeID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceTypeID));
      }
    }
  }
}
