// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ViewContainerStatus_Info
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
  public class ViewContainerStatus_Info : ViewContainer_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_NonconformanceReports")]
    protected Info _NonconformanceReports;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_IncludeClosedNCRs")]
    protected Info _IncludeClosedNCRs;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_ContainerLevel")]
    protected Info _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_NextOperation")]
    protected Info _NextOperation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_InProcess")]
    protected Info _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_OriginalStartDate")]
    protected Info _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_LastActivityDate")]
    protected Info _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_ProductDescription")]
    protected Info _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_LastMoveDate")]
    protected Info _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_ParentContainer")]
    protected Info _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_FactoryName")]
    protected Info _FactoryName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_Customer")]
    protected Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerStatus_Info_ContainerName")]
    protected Info _ContainerName;

    public Info NonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReports), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NonconformanceReports));
      }
    }

    public Info IncludeClosedNCRs
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeClosedNCRs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeClosedNCRs));
      }
    }

    public Info ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerLevel));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
      }
    }

    public Info NextOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextOperation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextOperation));
      }
    }

    public Info InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InProcess));
      }
    }

    public Info UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Info OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Info Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Step));
      }
    }

    public Info LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public Info ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public Info UOM
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

    public Info ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Info Product
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

    public Info LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Info ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public Info FactoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryName));
      }
    }

    public Info Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Customer));
      }
    }

    public Info Qty
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

    public Info ContainerName
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
  }
}
