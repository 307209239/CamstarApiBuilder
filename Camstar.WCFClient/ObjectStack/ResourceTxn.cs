// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceTxn
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
  public class ResourceTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_ResourceStatusDetails")]
    protected ResourceStatusDetails _ResourceStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_ParametricData")]
    protected new ParametricData _ParametricData;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_DataCollectionDef")]
    protected new RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_PrintLabels")]
    protected new Primitive<bool> _PrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;

    public override bool Equals(object obj)
    {
      return obj is ResourceTxn && object.Equals((object) this._ResourceStatusDetails, (object) ((ResourceTxn) obj)._ResourceStatusDetails) && (object.Equals((object) this._ParametricData, (object) ((ResourceTxn) obj)._ParametricData) && object.Equals((object) this._DataCollectionDef, (object) ((ResourceTxn) obj)._DataCollectionDef)) && (object.Equals((object) this._PrintLabels, (object) ((ResourceTxn) obj)._PrintLabels) && object.Equals((object) this._Resource, (object) ((ResourceTxn) obj)._Resource) && object.Equals((object) this._MfgOrder, (object) ((ResourceTxn) obj)._MfgOrder)) && base.Equals(obj);
    }

    public ResourceStatusDetails ResourceStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusDetails), (object) value);
      }
      get
      {
        return (ResourceStatusDetails) this.PropertyGet(nameof (ResourceStatusDetails));
      }
    }

    public new ParametricData ParametricData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricData), (object) value);
      }
      get
      {
        return (ParametricData) this.PropertyGet(nameof (ParametricData));
      }
    }

    public new RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new Primitive<bool> PrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabels), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PrintLabels));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public new NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }
  }
}
