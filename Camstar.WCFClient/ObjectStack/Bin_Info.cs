// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Bin_Info
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
  public class Bin_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_EffectiveFromDateGMT")]
    protected Info _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_EffectiveThruDateGMT")]
    protected Info _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_EffectiveThruDate")]
    protected Info _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_EffectiveFromDate")]
    protected Info _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_TxnDetails")]
    protected TxnDetails_Info _TxnDetails;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_FromProduct")]
    protected Info _FromProduct;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_BinPercentage")]
    protected Info _BinPercentage;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_ResultingProduct")]
    protected Info _ResultingProduct;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_Path")]
    protected Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Info_Notes")]
    protected Info _Notes;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Info EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Info EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Info EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public TxnDetails_Info TxnDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDetails), (object) value);
      }
      get
      {
        return (TxnDetails_Info) this.PropertyGet(nameof (TxnDetails));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
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

    public Info FromProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromProduct));
      }
    }

    public Info BinPercentage
    {
      [param: In] set
      {
        this.PropertySet(nameof (BinPercentage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BinPercentage));
      }
    }

    public Info ResultingProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultingProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultingProduct));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Path));
      }
    }

    public Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
