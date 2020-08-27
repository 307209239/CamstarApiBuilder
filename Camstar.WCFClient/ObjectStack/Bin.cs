// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Bin
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
  public class Bin : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "Bin_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Bin_EffectiveFromDateGMT")]
    protected Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Bin_EffectiveThruDateGMT")]
    protected Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Bin_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "Bin_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Status")]
    protected Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "Bin_TxnDetails")]
    protected TxnDetails _TxnDetails;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Step")]
    protected NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "Bin_FromProduct")]
    protected RevisionedObjectRef _FromProduct;
    [DataMember(EmitDefaultValue = false, Name = "Bin_BinPercentage")]
    protected Primitive<double> _BinPercentage;
    [DataMember(EmitDefaultValue = false, Name = "Bin_ResultingProduct")]
    protected RevisionedObjectRef _ResultingProduct;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "Bin_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Path")]
    protected NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "Bin_Notes")]
    protected Primitive<string> _Notes;

    public override bool Equals(object obj)
    {
      return obj is Bin && object.Equals((object) this._ExportImportKey, (object) ((Bin) obj)._ExportImportKey) && (object.Equals((object) this._EffectiveFromDateGMT, (object) ((Bin) obj)._EffectiveFromDateGMT) && object.Equals((object) this._EffectiveThruDateGMT, (object) ((Bin) obj)._EffectiveThruDateGMT)) && (object.Equals((object) this._EffectiveThruDate, (object) ((Bin) obj)._EffectiveThruDate) && object.Equals((object) this._EffectiveFromDate, (object) ((Bin) obj)._EffectiveFromDate) && (object.Equals((object) this._Status, (object) ((Bin) obj)._Status) && object.Equals((object) this._TxnDetails, (object) ((Bin) obj)._TxnDetails))) && (object.Equals((object) this._Description, (object) ((Bin) obj)._Description) && object.Equals((object) this._Step, (object) ((Bin) obj)._Step) && (object.Equals((object) this._FromProduct, (object) ((Bin) obj)._FromProduct) && object.Equals((object) this._BinPercentage, (object) ((Bin) obj)._BinPercentage)) && (object.Equals((object) this._ResultingProduct, (object) ((Bin) obj)._ResultingProduct) && object.Equals((object) this._Name, (object) ((Bin) obj)._Name) && (object.Equals((object) this._IsFrozen, (object) ((Bin) obj)._IsFrozen) && object.Equals((object) this._Path, (object) ((Bin) obj)._Path)))) && object.Equals((object) this._Notes, (object) ((Bin) obj)._Notes) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<DateTime> EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Primitive<DateTime> EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Primitive<DateTime> EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Primitive<DateTime> EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public TxnDetails TxnDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDetails), (object) value);
      }
      get
      {
        return (TxnDetails) this.PropertyGet(nameof (TxnDetails));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public NamedSubentityRef Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Step));
      }
    }

    public RevisionedObjectRef FromProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (FromProduct));
      }
    }

    public Primitive<double> BinPercentage
    {
      [param: In] set
      {
        this.PropertySet(nameof (BinPercentage), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (BinPercentage));
      }
    }

    public RevisionedObjectRef ResultingProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultingProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ResultingProduct));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public NamedSubentityRef Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Path));
      }
    }

    public Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
