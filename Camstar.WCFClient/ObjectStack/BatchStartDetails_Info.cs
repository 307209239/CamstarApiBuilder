// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchStartDetails_Info
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
  public class BatchStartDetails_Info : StartDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_StartReason")]
    protected new Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_UOM")]
    protected new Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_MasterRecipe")]
    protected Info _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_BatchStatus")]
    protected Info _BatchStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_ChildContainers")]
    protected BatchStartDetails_Info _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_DueDate")]
    protected new Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_ContainerName")]
    protected new Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_PlannedQty")]
    protected new Info _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_Owner")]
    protected new Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_PriorityCode")]
    protected new Info _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_MfgOrder")]
    protected new Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_BatchComments")]
    protected Info _BatchComments;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_Product")]
    protected new Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Info_Level")]
    protected new Info _Level;

    public new Info StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartReason));
      }
    }

    public new Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
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

    public BatchStartDetails_Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (BatchStartDetails_Info) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public new Info DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDate));
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

    public new Info PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQty));
      }
    }

    public new Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
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

    public new Info PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public new Info MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public Info BatchComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BatchComments));
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

    public new Info Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Level));
      }
    }
  }
}
