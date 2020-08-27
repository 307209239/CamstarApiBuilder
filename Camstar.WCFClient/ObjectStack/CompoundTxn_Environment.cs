// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompoundTxn_Environment
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
  public class CompoundTxn_Environment : ShopFloor_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, true, "NamedObjectRef", 1050609, false, false, true, null)]
    protected new Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Environment_MfgProcessOverrides")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, false, null)]
    protected new Environment _MfgProcessOverrides;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050627, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Environment_PrintLabelsInSubServices")]
    protected Environment _PrintLabelsInSubServices;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Environment_PrintLabels")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050625, false, false, false, "1")]
    protected new Environment _PrintLabels;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Environment_Factory")]
    protected new Environment _Factory;

    public new Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public new Environment MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public Environment PrintLabelsInSubServices
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabelsInSubServices), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintLabelsInSubServices));
      }
    }

    public new Environment PrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabels), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintLabels));
      }
    }

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
