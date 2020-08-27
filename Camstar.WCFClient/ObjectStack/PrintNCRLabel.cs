// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintNCRLabel
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
  public class PrintNCRLabel : PrintLabelTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintNCRLabel_NonconformanceReport")]
    protected NamedObjectRef _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "PrintNCRLabel_HistoryId")]
    protected NamedObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "PrintNCRLabel_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintNCRLabel_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "PrintNCRLabel_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "PrintNCRLabel_WorkCenter")]
    protected NamedObjectRef _WorkCenter;

    public override bool Equals(object obj)
    {
      return obj is PrintNCRLabel && object.Equals((object) this._NonconformanceReport, (object) ((PrintNCRLabel) obj)._NonconformanceReport) && (object.Equals((object) this._HistoryId, (object) ((PrintNCRLabel) obj)._HistoryId) && object.Equals((object) this._PrintQueue, (object) ((PrintNCRLabel) obj)._PrintQueue)) && (object.Equals((object) this._Container, (object) ((PrintNCRLabel) obj)._Container) && object.Equals((object) this._Operation, (object) ((PrintNCRLabel) obj)._Operation) && object.Equals((object) this._WorkCenter, (object) ((PrintNCRLabel) obj)._WorkCenter)) && base.Equals(obj);
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

    public NamedObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HistoryId));
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
  }
}
