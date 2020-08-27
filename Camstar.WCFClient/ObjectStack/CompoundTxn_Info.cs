// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompoundTxn_Info
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
  public class CompoundTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Info_MfgProcessOverrides")]
    protected new Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Info_PrintLabelsInSubServices")]
    protected Info _PrintLabelsInSubServices;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Info_PrintLabels")]
    protected new Info _PrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Info_Factory")]
    protected new Info _Factory;

    public new Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public new Info MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public Info PrintLabelsInSubServices
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabelsInSubServices), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintLabelsInSubServices));
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

    public new Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
