// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentContainerStatus
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
  public class CurrentContainerStatus : ViewContainerAsParent
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Qty2")]
    protected new Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_MasterRecipe")]
    protected RevisionedObjectRef _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Attributes")]
    protected UserAttribute[] _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Timers")]
    protected Timer[] _Timers;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_IsOnHold")]
    protected Primitive<bool> _IsOnHold;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_ContainerStatusName")]
    protected Primitive<string> _ContainerStatusName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_BatchStatus")]
    protected Primitive<int> _BatchStatus;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_BatchStatusName")]
    protected Primitive<string> _BatchStatusName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_FactoryStartDate")]
    protected Primitive<DateTime> _FactoryStartDate;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_PriorityCodeName")]
    protected new Primitive<string> _PriorityCodeName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Documents")]
    protected NamedSubentityRef[] _Documents;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_ContainerLevelName")]
    protected new Primitive<string> _ContainerLevelName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_ContainerName")]
    protected new Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_NextOperationName")]
    protected Primitive<string> _NextOperationName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_UOMName")]
    protected new Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_ProductName")]
    protected new Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_MfgOrderName")]
    protected new Primitive<string> _MfgOrderName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_WorkflowName")]
    protected Primitive<string> _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_DocumentSets")]
    protected DocumentSet[] _DocumentSets;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_CarrierName")]
    protected Primitive<string> _CarrierName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_UOM2Name")]
    protected new Primitive<string> _UOM2Name;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_StatusName")]
    protected new Primitive<string> _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_MasterRecipeName")]
    protected Primitive<string> _MasterRecipeName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_SpecName")]
    protected Primitive<string> _SpecName;

    public override bool Equals(object obj)
    {
      return obj is CurrentContainerStatus && object.Equals((object) this._Qty2, (object) ((CurrentContainerStatus) obj)._Qty2) && (object.Equals((object) this._MasterRecipe, (object) ((CurrentContainerStatus) obj)._MasterRecipe) && this.CompareArrays((Array) this._Attributes, (Array) ((CurrentContainerStatus) obj)._Attributes)) && (object.Equals((object) this._Carrier, (object) ((CurrentContainerStatus) obj)._Carrier) && this.CompareArrays((Array) this._Timers, (Array) ((CurrentContainerStatus) obj)._Timers) && (object.Equals((object) this._IsOnHold, (object) ((CurrentContainerStatus) obj)._IsOnHold) && object.Equals((object) this._ContainerStatusName, (object) ((CurrentContainerStatus) obj)._ContainerStatusName))) && (object.Equals((object) this._BatchStatus, (object) ((CurrentContainerStatus) obj)._BatchStatus) && object.Equals((object) this._Container, (object) ((CurrentContainerStatus) obj)._Container) && (object.Equals((object) this._BatchStatusName, (object) ((CurrentContainerStatus) obj)._BatchStatusName) && object.Equals((object) this._FactoryStartDate, (object) ((CurrentContainerStatus) obj)._FactoryStartDate)) && (object.Equals((object) this._ExpirationDate, (object) ((CurrentContainerStatus) obj)._ExpirationDate) && object.Equals((object) this._PriorityCodeName, (object) ((CurrentContainerStatus) obj)._PriorityCodeName) && (this.CompareArrays((Array) this._Documents, (Array) ((CurrentContainerStatus) obj)._Documents) && object.Equals((object) this._ContainerLevelName, (object) ((CurrentContainerStatus) obj)._ContainerLevelName)))) && (object.Equals((object) this._ContainerName, (object) ((CurrentContainerStatus) obj)._ContainerName) && object.Equals((object) this._NextOperationName, (object) ((CurrentContainerStatus) obj)._NextOperationName) && (object.Equals((object) this._UOMName, (object) ((CurrentContainerStatus) obj)._UOMName) && object.Equals((object) this._Qty, (object) ((CurrentContainerStatus) obj)._Qty)) && (object.Equals((object) this._ProductName, (object) ((CurrentContainerStatus) obj)._ProductName) && object.Equals((object) this._MfgOrderName, (object) ((CurrentContainerStatus) obj)._MfgOrderName) && (object.Equals((object) this._WorkflowName, (object) ((CurrentContainerStatus) obj)._WorkflowName) && object.Equals((object) this._Product, (object) ((CurrentContainerStatus) obj)._Product))) && (this.CompareArrays((Array) this._DocumentSets, (Array) ((CurrentContainerStatus) obj)._DocumentSets) && object.Equals((object) this._CarrierName, (object) ((CurrentContainerStatus) obj)._CarrierName) && (object.Equals((object) this._UOM2Name, (object) ((CurrentContainerStatus) obj)._UOM2Name) && object.Equals((object) this._StatusName, (object) ((CurrentContainerStatus) obj)._StatusName)) && (object.Equals((object) this._MasterRecipeName, (object) ((CurrentContainerStatus) obj)._MasterRecipeName) && object.Equals((object) this._SpecName, (object) ((CurrentContainerStatus) obj)._SpecName)))) && base.Equals(obj);
    }

    public new Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
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

    public UserAttribute[] Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttribute[]) this.PropertyGet(nameof (Attributes));
      }
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public Timer[] Timers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timers), (object) value);
      }
      get
      {
        return (Timer[]) this.PropertyGet(nameof (Timers));
      }
    }

    public Primitive<bool> IsOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsOnHold), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsOnHold));
      }
    }

    public Primitive<string> ContainerStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerStatusName));
      }
    }

    public Primitive<int> BatchStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatus), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (BatchStatus));
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

    public Primitive<string> BatchStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BatchStatusName));
      }
    }

    public Primitive<DateTime> FactoryStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FactoryStartDate));
      }
    }

    public Primitive<DateTime> ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public new Primitive<string> PriorityCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCodeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PriorityCodeName));
      }
    }

    public NamedSubentityRef[] Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (Documents));
      }
    }

    public new Primitive<string> ContainerLevelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerLevelName));
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

    public Primitive<string> NextOperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextOperationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NextOperationName));
      }
    }

    public new Primitive<string> UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOMName));
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

    public new Primitive<string> ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductName));
      }
    }

    public new Primitive<string> MfgOrderName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MfgOrderName));
      }
    }

    public Primitive<string> WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowName));
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

    public DocumentSet[] DocumentSets
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSets), (object) value);
      }
      get
      {
        return (DocumentSet[]) this.PropertyGet(nameof (DocumentSets));
      }
    }

    public Primitive<string> CarrierName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CarrierName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CarrierName));
      }
    }

    public new Primitive<string> UOM2Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOM2Name));
      }
    }

    public new Primitive<string> StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StatusName));
      }
    }

    public Primitive<string> MasterRecipeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MasterRecipeName));
      }
    }

    public Primitive<string> SpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecName));
      }
    }
  }
}
