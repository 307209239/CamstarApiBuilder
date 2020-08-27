// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ViewContainerStatus
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
  public class ViewContainerStatus : ViewContainer
  {
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_NonconformanceReports")]
    protected NamedObjectRef[] _NonconformanceReports;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_IncludeClosedNCRs")]
    protected Primitive<bool> _IncludeClosedNCRs;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_ContainerLevel")]
    protected Primitive<string> _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Resource")]
    protected Primitive<string> _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Location")]
    protected Primitive<string> _Location;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_NextOperation")]
    protected Primitive<string> _NextOperation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_InProcess")]
    protected Primitive<bool> _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_OriginalStartDate")]
    protected Primitive<DateTime> _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Step")]
    protected Primitive<string> _Step;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_LastActivityDate")]
    protected Primitive<DateTime> _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Operation")]
    protected Primitive<string> _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_UOM")]
    protected Primitive<string> _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_ProductDescription")]
    protected Primitive<string> _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Product")]
    protected Primitive<string> _Product;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_LastMoveDate")]
    protected Primitive<DateTime> _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_ParentContainer")]
    protected Primitive<string> _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Workflow")]
    protected Primitive<string> _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_FactoryName")]
    protected Primitive<string> _FactoryName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Customer")]
    protected Primitive<string> _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_ContainerName")]
    protected Primitive<string> _ContainerName;

    public override bool Equals(object obj)
    {
      return obj is ViewContainerStatus && this.CompareArrays((Array) this._NonconformanceReports, (Array) ((ViewContainerStatus) obj)._NonconformanceReports) && (object.Equals((object) this._IncludeClosedNCRs, (object) ((ViewContainerStatus) obj)._IncludeClosedNCRs) && object.Equals((object) this._ContainerLevel, (object) ((ViewContainerStatus) obj)._ContainerLevel)) && (object.Equals((object) this._Resource, (object) ((ViewContainerStatus) obj)._Resource) && object.Equals((object) this._Location, (object) ((ViewContainerStatus) obj)._Location) && (object.Equals((object) this._NextOperation, (object) ((ViewContainerStatus) obj)._NextOperation) && object.Equals((object) this._InProcess, (object) ((ViewContainerStatus) obj)._InProcess))) && (object.Equals((object) this._UnitCount, (object) ((ViewContainerStatus) obj)._UnitCount) && object.Equals((object) this._OriginalStartDate, (object) ((ViewContainerStatus) obj)._OriginalStartDate) && (object.Equals((object) this._Step, (object) ((ViewContainerStatus) obj)._Step) && object.Equals((object) this._LastActivityDate, (object) ((ViewContainerStatus) obj)._LastActivityDate)) && (object.Equals((object) this._ChildCount, (object) ((ViewContainerStatus) obj)._ChildCount) && object.Equals((object) this._Operation, (object) ((ViewContainerStatus) obj)._Operation) && (object.Equals((object) this._UOM, (object) ((ViewContainerStatus) obj)._UOM) && object.Equals((object) this._ProductDescription, (object) ((ViewContainerStatus) obj)._ProductDescription)))) && (object.Equals((object) this._Product, (object) ((ViewContainerStatus) obj)._Product) && object.Equals((object) this._LastMoveDate, (object) ((ViewContainerStatus) obj)._LastMoveDate) && (object.Equals((object) this._ParentContainer, (object) ((ViewContainerStatus) obj)._ParentContainer) && object.Equals((object) this._Workflow, (object) ((ViewContainerStatus) obj)._Workflow)) && (object.Equals((object) this._FactoryName, (object) ((ViewContainerStatus) obj)._FactoryName) && object.Equals((object) this._Customer, (object) ((ViewContainerStatus) obj)._Customer) && (object.Equals((object) this._Qty, (object) ((ViewContainerStatus) obj)._Qty) && object.Equals((object) this._ContainerName, (object) ((ViewContainerStatus) obj)._ContainerName)))) && base.Equals(obj);
    }

    public NamedObjectRef[] NonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReports), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (NonconformanceReports));
      }
    }

    public Primitive<bool> IncludeClosedNCRs
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeClosedNCRs), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeClosedNCRs));
      }
    }

    public Primitive<string> ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerLevel));
      }
    }

    public Primitive<string> Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Resource));
      }
    }

    public Primitive<string> Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Location));
      }
    }

    public Primitive<string> NextOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextOperation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NextOperation));
      }
    }

    public Primitive<bool> InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InProcess));
      }
    }

    public Primitive<int> UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Primitive<DateTime> OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Primitive<string> Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Step));
      }
    }

    public Primitive<DateTime> LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public Primitive<int> ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Primitive<string> Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Operation));
      }
    }

    public Primitive<string> UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOM));
      }
    }

    public Primitive<string> ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Primitive<string> Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Product));
      }
    }

    public Primitive<DateTime> LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Primitive<string> ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Primitive<string> Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Workflow));
      }
    }

    public Primitive<string> FactoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FactoryName));
      }
    }

    public Primitive<string> Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Customer));
      }
    }

    public Primitive<double> Qty
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

    public Primitive<string> ContainerName
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
  }
}
