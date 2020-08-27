// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintLabelTxn
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
  public class PrintLabelTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_PrinterLabelDefinition")]
    protected RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_LabelSummaries")]
    protected new LabelSummary[] _LabelSummaries;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_HistoryId")]
    protected BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_LabelCount")]
    protected Primitive<int> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is PrintLabelTxn && object.Equals((object) this._PrinterLabelDefinition, (object) ((PrintLabelTxn) obj)._PrinterLabelDefinition) && (this.CompareArrays((Array) this._LabelSummaries, (Array) ((PrintLabelTxn) obj)._LabelSummaries) && object.Equals((object) this._PrintQueue, (object) ((PrintLabelTxn) obj)._PrintQueue)) && (object.Equals((object) this._HistoryId, (object) ((PrintLabelTxn) obj)._HistoryId) && object.Equals((object) this._LabelCount, (object) ((PrintLabelTxn) obj)._LabelCount) && object.Equals((object) this._Factory, (object) ((PrintLabelTxn) obj)._Factory)) && base.Equals(obj);
    }

    public RevisionedObjectRef PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public new LabelSummary[] LabelSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummaries), (object) value);
      }
      get
      {
        return (LabelSummary[]) this.PropertyGet(nameof (LabelSummaries));
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

    public BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LabelCount));
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
