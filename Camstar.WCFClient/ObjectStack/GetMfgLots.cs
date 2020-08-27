// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMfgLots
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
  public class GetMfgLots : GetMfgData
  {
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_MfgDataDetails")]
    protected MfgLotDetail[] _MfgDataDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_IncludeWhereUsed")]
    protected Primitive<bool> _IncludeWhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_ToStartDate")]
    protected Primitive<DateTime> _ToStartDate;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_FromStartDate")]
    protected Primitive<DateTime> _FromStartDate;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_WorkCenter")]
    protected NamedObjectRef _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is GetMfgLots && this.CompareArrays((Array) this._MfgDataDetails, (Array) ((GetMfgLots) obj)._MfgDataDetails) && (object.Equals((object) this._IncludeWhereUsed, (object) ((GetMfgLots) obj)._IncludeWhereUsed) && object.Equals((object) this._ToStartDate, (object) ((GetMfgLots) obj)._ToStartDate)) && (object.Equals((object) this._Container, (object) ((GetMfgLots) obj)._Container) && object.Equals((object) this._FromStartDate, (object) ((GetMfgLots) obj)._FromStartDate) && (object.Equals((object) this._Factory, (object) ((GetMfgLots) obj)._Factory) && object.Equals((object) this._Operation, (object) ((GetMfgLots) obj)._Operation))) && (object.Equals((object) this._WorkCenter, (object) ((GetMfgLots) obj)._WorkCenter) && object.Equals((object) this._Product, (object) ((GetMfgLots) obj)._Product)) && base.Equals(obj);
    }

    public MfgLotDetail[] MfgDataDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgDataDetails), (object) value);
      }
      get
      {
        return (MfgLotDetail[]) this.PropertyGet(nameof (MfgDataDetails));
      }
    }

    public Primitive<bool> IncludeWhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeWhereUsed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeWhereUsed));
      }
    }

    public Primitive<DateTime> ToStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ToStartDate));
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

    public Primitive<DateTime> FromStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FromStartDate));
      }
    }

    public NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }

    public NamedObjectRef WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkCenter));
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
