// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRDefectDetails
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
  public class NCRDefectDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_ActualComponentIssue")]
    protected SubentityRef _ActualComponentIssue;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_NCRDefectData")]
    protected SubentityRef _NCRDefectData;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_IsDefect")]
    protected Primitive<bool> _IsDefect;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is NCRDefectDetails && object.Equals((object) this._ActualComponentIssue, (object) ((NCRDefectDetails) obj)._ActualComponentIssue) && (object.Equals((object) this._NCRDefectData, (object) ((NCRDefectDetails) obj)._NCRDefectData) && object.Equals((object) this._Container, (object) ((NCRDefectDetails) obj)._Container)) && (object.Equals((object) this._IsDefect, (object) ((NCRDefectDetails) obj)._IsDefect) && object.Equals((object) this._Lot, (object) ((NCRDefectDetails) obj)._Lot) && (object.Equals((object) this._ReferenceDesignator, (object) ((NCRDefectDetails) obj)._ReferenceDesignator) && object.Equals((object) this._Product, (object) ((NCRDefectDetails) obj)._Product))) && base.Equals(obj);
    }

    public SubentityRef ActualComponentIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualComponentIssue), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ActualComponentIssue));
      }
    }

    public SubentityRef NCRDefectData
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (NCRDefectData));
      }
    }

    public ContainerRef Container
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

    public Primitive<bool> IsDefect
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefect), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsDefect));
      }
    }

    public Primitive<string> Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Lot));
      }
    }

    public Primitive<string> ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public RevisionedObjectRef Product
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
  }
}
