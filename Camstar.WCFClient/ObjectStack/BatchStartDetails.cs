// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchStartDetails
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
  public class BatchStartDetails : StartDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_StartReason")]
    protected new NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_MasterRecipe")]
    protected RevisionedObjectRef _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_BatchStatus")]
    protected Enumeration<BatchStatusEnum, int> _BatchStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_ChildContainers")]
    protected BatchStartDetails[] _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_DueDate")]
    protected new Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_ContainerName")]
    protected new Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_PlannedQty")]
    protected new Primitive<double> _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_PriorityCode")]
    protected new NamedObjectRef _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_BatchComments")]
    protected Primitive<string> _BatchComments;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Level")]
    protected new NamedObjectRef _Level;

    public override bool Equals(object obj)
    {
      return obj is BatchStartDetails && object.Equals((object) this._StartReason, (object) ((BatchStartDetails) obj)._StartReason) && (object.Equals((object) this._UOM, (object) ((BatchStartDetails) obj)._UOM) && object.Equals((object) this._MasterRecipe, (object) ((BatchStartDetails) obj)._MasterRecipe)) && (object.Equals((object) this._Container, (object) ((BatchStartDetails) obj)._Container) && object.Equals((object) this._BatchStatus, (object) ((BatchStartDetails) obj)._BatchStatus) && (this.CompareArrays((Array) this._ChildContainers, (Array) ((BatchStartDetails) obj)._ChildContainers) && object.Equals((object) this._DueDate, (object) ((BatchStartDetails) obj)._DueDate))) && (object.Equals((object) this._ContainerName, (object) ((BatchStartDetails) obj)._ContainerName) && object.Equals((object) this._PlannedQty, (object) ((BatchStartDetails) obj)._PlannedQty) && (object.Equals((object) this._Owner, (object) ((BatchStartDetails) obj)._Owner) && object.Equals((object) this._Qty, (object) ((BatchStartDetails) obj)._Qty)) && (object.Equals((object) this._PriorityCode, (object) ((BatchStartDetails) obj)._PriorityCode) && object.Equals((object) this._MfgOrder, (object) ((BatchStartDetails) obj)._MfgOrder) && (object.Equals((object) this._BatchComments, (object) ((BatchStartDetails) obj)._BatchComments) && object.Equals((object) this._Product, (object) ((BatchStartDetails) obj)._Product)))) && object.Equals((object) this._Level, (object) ((BatchStartDetails) obj)._Level) && base.Equals(obj);
    }

    public new NamedObjectRef StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StartReason));
      }
    }

    public new NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public RevisionedObjectRef MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MasterRecipe));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Enumeration<BatchStatusEnum, int> BatchStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatus), (object) value);
      }
      get
      {
        return (Enumeration<BatchStatusEnum, int>) this.PropertyGet(nameof (BatchStatus));
      }
    }

    public BatchStartDetails[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (BatchStartDetails[]) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public new Primitive<DateTime> DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDate));
      }
    }

    public new Primitive<string> ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerName));
      }
    }

    public new Primitive<double> PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (PlannedQty));
      }
    }

    public new NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public new Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public new NamedObjectRef PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public new NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public Primitive<string> BatchComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BatchComments));
      }
    }

    public new RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public new NamedObjectRef Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Level));
      }
    }
  }
}
