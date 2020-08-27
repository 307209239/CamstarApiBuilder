// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterDataCatalogDtlChanges_Info
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
  public class MasterDataCatalogDtlChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Info_CDODisplayName")]
    protected Info _CDODisplayName;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Info_AnyWorkflowControlled")]
    protected Info _AnyWorkflowControlled;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Info_DisplayNameLabelId")]
    protected Info _DisplayNameLabelId;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Info_ApprovalWorkflowControlled")]
    protected Info _ApprovalWorkflowControlled;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogDtlChanges_Info_MaintenanceTypeID")]
    protected Info _MaintenanceTypeID;

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info CDODisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDODisplayName));
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

    public Info AnyWorkflowControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (AnyWorkflowControlled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AnyWorkflowControlled));
      }
    }

    public Info DisplayNameLabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayNameLabelId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayNameLabelId));
      }
    }

    public Info ApprovalWorkflowControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalWorkflowControlled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalWorkflowControlled));
      }
    }

    public Info MaintenanceTypeID
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceTypeID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceTypeID));
      }
    }
  }
}
