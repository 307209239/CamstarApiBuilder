// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ViewContainerStatus_Environment
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
  public class ViewContainerStatus_Environment : ViewContainer_Environment
  {
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, false, "NamedObjectRef", 1050602, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_NonconformanceReports")]
    protected Environment _NonconformanceReports;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050469, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_IncludeClosedNCRs")]
    protected Environment _IncludeClosedNCRs;
    [Metadata("Generic String", "", false, false, false, "String", 1049278, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_ContainerLevel")]
    protected Environment _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_Resource")]
    [Metadata("Generic String", "", false, false, false, "String", 1048840, false, false, false, null)]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_Location")]
    [Metadata("Generic String", "", false, false, false, "String", 1048660, false, false, false, null)]
    protected Environment _Location;
    [Metadata("Generic String", "", false, false, false, "String", 1048812, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_NextOperation")]
    protected Environment _NextOperation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_InProcess")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048801, false, false, false, "0")]
    protected Environment _InProcess;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048852, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_UnitCount")]
    protected Environment _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_OriginalStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048820, false, false, false, null)]
    protected Environment _OriginalStartDate;
    [Metadata("Generic String", "", false, false, false, "String", 1049032, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_Step")]
    protected Environment _Step;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_LastActivityDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048803, false, false, false, null)]
    protected Environment _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_ChildCount")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048770, false, false, false, "0")]
    protected Environment _ChildCount;
    [Metadata("Generic String", "", false, false, false, "String", 1048815, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_Operation")]
    protected Environment _Operation;
    [Metadata("Generic String", "", false, false, false, "String", 1048853, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_UOM")]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_ProductDescription")]
    [Metadata("Generic String", "", false, false, false, "String", 1049279, false, false, false, null)]
    protected Environment _ProductDescription;
    [Metadata("Generic String", "", false, false, false, "String", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_LastMoveDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048807, false, false, false, null)]
    protected Environment _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_ParentContainer")]
    [Metadata("Generic String", "", false, false, false, "String", 1049070, false, false, false, null)]
    protected Environment _ParentContainer;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048654, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_Workflow")]
    protected Environment _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_FactoryName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049831, false, false, false, null)]
    protected Environment _FactoryName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048612, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_Customer")]
    protected Environment _Customer;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_Qty")]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Environment_ContainerName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049088, false, false, false, null)]
    protected Environment _ContainerName;

    public Environment NonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReports), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NonconformanceReports));
      }
    }

    public Environment IncludeClosedNCRs
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeClosedNCRs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeClosedNCRs));
      }
    }

    public Environment ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerLevel));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }

    public Environment Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Location));
      }
    }

    public Environment NextOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextOperation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextOperation));
      }
    }

    public Environment InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InProcess));
      }
    }

    public Environment UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Environment OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Environment Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Step));
      }
    }

    public Environment LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public Environment ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public Environment ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }

    public Environment LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Environment ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Environment Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workflow));
      }
    }

    public Environment FactoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryName));
      }
    }

    public Environment Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Customer));
      }
    }

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }

    public Environment ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerName));
      }
    }
  }
}
