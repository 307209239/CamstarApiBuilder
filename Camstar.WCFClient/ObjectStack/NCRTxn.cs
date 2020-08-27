// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRTxn
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
  public class NCRTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_NonconformanceReport")]
    protected NamedObjectRef _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_WorkCenter")]
    protected NamedObjectRef _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_Operation")]
    protected NamedObjectRef _Operation;

    public override bool Equals(object obj)
    {
      return obj is NCRTxn && object.Equals((object) this._Comments, (object) ((NCRTxn) obj)._Comments) && (object.Equals((object) this._NonconformanceReport, (object) ((NCRTxn) obj)._NonconformanceReport) && object.Equals((object) this._PrintQueue, (object) ((NCRTxn) obj)._PrintQueue)) && (object.Equals((object) this._Factory, (object) ((NCRTxn) obj)._Factory) && object.Equals((object) this._WorkCenter, (object) ((NCRTxn) obj)._WorkCenter) && object.Equals((object) this._Operation, (object) ((NCRTxn) obj)._Operation)) && base.Equals(obj);
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public NamedObjectRef NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NonconformanceReport));
      }
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
  }
}
