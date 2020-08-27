// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AdjustDetails_Info
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
  public class AdjustDetails_Info : ChangeQtyDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Info_Qty2")]
    protected new Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Info_ReasonCode")]
    protected new Info _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Info_ChangeQtyType")]
    protected new Info _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Info_AdjustThruput")]
    protected new Info _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Info_TypeSortOrder")]
    protected new Info _TypeSortOrder;
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "AdjustDetails_Info_ChargeToStep")]
    protected new Info _ChargeToStep;

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

    public new Info ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReasonCode));
      }
    }

    public new Info ChangeQtyType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQtyType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangeQtyType));
      }
    }

    public new Info AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public new Info TypeSortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeSortOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TypeSortOrder));
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

    public new Info ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChargeToStep));
      }
    }
  }
}
