// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompoundTxn
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
  public class CompoundTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_MfgProcessOverrides")]
    protected new RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_PrintLabelsInSubServices")]
    protected Primitive<bool> _PrintLabelsInSubServices;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_PrintLabels")]
    protected new Primitive<bool> _PrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "CompoundTxn_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is CompoundTxn && object.Equals((object) this._PrintQueue, (object) ((CompoundTxn) obj)._PrintQueue) && (object.Equals((object) this._MfgProcessOverrides, (object) ((CompoundTxn) obj)._MfgProcessOverrides) && object.Equals((object) this._PrintLabelsInSubServices, (object) ((CompoundTxn) obj)._PrintLabelsInSubServices)) && (object.Equals((object) this._PrintLabels, (object) ((CompoundTxn) obj)._PrintLabels) && object.Equals((object) this._Factory, (object) ((CompoundTxn) obj)._Factory)) && base.Equals(obj);
    }

    public new NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public new RevisionedObjectRef MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public Primitive<bool> PrintLabelsInSubServices
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabelsInSubServices), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PrintLabelsInSubServices));
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

    public new NamedObjectRef Factory
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
  }
}
