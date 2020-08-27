// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceTxn_Info
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
  public class ResourceTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_Info_ResourceStatusDetails")]
    protected ResourceStatusDetails_Info _ResourceStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_Info_ParametricData")]
    protected new ParametricData_Info _ParametricData;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_Info_DataCollectionDef")]
    protected new Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_Info_PrintLabels")]
    protected new Info _PrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxn_Info_MfgOrder")]
    protected new Info _MfgOrder;

    public ResourceStatusDetails_Info ResourceStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusDetails), (object) value);
      }
      get
      {
        return (ResourceStatusDetails_Info) this.PropertyGet(nameof (ResourceStatusDetails));
      }
    }

    public new ParametricData_Info ParametricData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricData), (object) value);
      }
      get
      {
        return (ParametricData_Info) this.PropertyGet(nameof (ParametricData));
      }
    }

    public new Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new Info PrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabels), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintLabels));
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
  }
}
