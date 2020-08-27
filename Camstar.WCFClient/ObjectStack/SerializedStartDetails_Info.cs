// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializedStartDetails_Info
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
  public class SerializedStartDetails_Info : StartDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_Customer")]
    protected new Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_BOM")]
    protected new Info _BOM;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_UOM2")]
    protected new Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_UOM")]
    protected new Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_StartReason")]
    protected new Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_Qty2")]
    protected new Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_RequestDate")]
    protected new Info _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_DueDate")]
    protected new Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_PriorityCode")]
    protected new Info _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_ContainerName")]
    protected new Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_Owner")]
    protected new Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_MfgOrder")]
    protected new Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_ContainerComment")]
    protected new Info _ContainerComment;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_Level")]
    protected new Info _Level;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_Product")]
    protected new Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Info_SalesOrder")]
    protected new Info _SalesOrder;

    public new Info Customer
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

    public new Info BOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BOM));
      }
    }

    public new Info UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2));
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

    public new Info RequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequestDate));
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

    public new Info ContainerComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerComment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerComment));
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

    public new Info SalesOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SalesOrder));
      }
    }
  }
}
