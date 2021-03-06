﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ThruputDetail_Info
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
  public class ThruputDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_ThruputAllQty")]
    protected Info _ThruputAllQty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_ThruputReportingLevel")]
    protected Info _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Info_ContainerLevel")]
    protected Info _ContainerLevel;

    public Info Qty2
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

    public Info ThruputAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAllQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputAllQty));
      }
    }

    public Info Container
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

    public Info ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputReportingLevel));
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
  }
}
