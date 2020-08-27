// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRTxn_Info
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
  public class NCRTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_Info_NonconformanceReport")]
    protected Info _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_Info_Factory")]
    protected new Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_Info_WorkCenter")]
    protected Info _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "NCRTxn_Info_Operation")]
    protected Info _Operation;

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NonconformanceReport));
      }
    }

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

    public Info WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
