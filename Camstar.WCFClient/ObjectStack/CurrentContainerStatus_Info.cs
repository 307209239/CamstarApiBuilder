// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentContainerStatus_Info
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
  public class CurrentContainerStatus_Info : ViewContainerAsParent_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_Qty2")]
    protected new Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_MasterRecipe")]
    protected Info _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_Attributes")]
    protected UserAttribute_Info _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_Carrier")]
    protected Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_Timers")]
    protected Timer_Info _Timers;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_IsOnHold")]
    protected Info _IsOnHold;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_ContainerStatusName")]
    protected Info _ContainerStatusName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_BatchStatus")]
    protected Info _BatchStatus;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_BatchStatusName")]
    protected Info _BatchStatusName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_FactoryStartDate")]
    protected Info _FactoryStartDate;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_ExpirationDate")]
    protected Info _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_PriorityCodeName")]
    protected new Info _PriorityCodeName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_Documents")]
    protected Info _Documents;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_ContainerLevelName")]
    protected new Info _ContainerLevelName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_ContainerName")]
    protected new Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_NextOperationName")]
    protected Info _NextOperationName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_UOMName")]
    protected new Info _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_ProductName")]
    protected new Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_MfgOrderName")]
    protected new Info _MfgOrderName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_WorkflowName")]
    protected Info _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_Product")]
    protected new Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_DocumentSets")]
    protected DocumentSet_Info _DocumentSets;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_CarrierName")]
    protected Info _CarrierName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_UOM2Name")]
    protected new Info _UOM2Name;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_StatusName")]
    protected new Info _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_MasterRecipeName")]
    protected Info _MasterRecipeName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Info_SpecName")]
    protected Info _SpecName;

    public new Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
      }
    }

    public Info MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MasterRecipe));
      }
    }

    public UserAttribute_Info Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttribute_Info) this.PropertyGet(nameof (Attributes));
      }
    }

    public Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public Timer_Info Timers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timers), (object) value);
      }
      get
      {
        return (Timer_Info) this.PropertyGet(nameof (Timers));
      }
    }

    public Info IsOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsOnHold), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsOnHold));
      }
    }

    public Info ContainerStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerStatusName));
      }
    }

    public Info BatchStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BatchStatus));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info BatchStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BatchStatusName));
      }
    }

    public Info FactoryStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryStartDate));
      }
    }

    public Info ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public new Info PriorityCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCodeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityCodeName));
      }
    }

    public Info Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Documents));
      }
    }

    public new Info ContainerLevelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerLevelName));
      }
    }

    public new Info ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerName));
      }
    }

    public Info NextOperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextOperationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextOperationName));
      }
    }

    public new Info UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOMName));
      }
    }

    public new Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }

    public new Info ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductName));
      }
    }

    public new Info MfgOrderName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrderName));
      }
    }

    public Info WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowName));
      }
    }

    public new Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public DocumentSet_Info DocumentSets
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSets), (object) value);
      }
      get
      {
        return (DocumentSet_Info) this.PropertyGet(nameof (DocumentSets));
      }
    }

    public Info CarrierName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CarrierName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CarrierName));
      }
    }

    public new Info UOM2Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2Name));
      }
    }

    public new Info StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusName));
      }
    }

    public Info MasterRecipeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MasterRecipeName));
      }
    }

    public Info SpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecName));
      }
    }
  }
}
