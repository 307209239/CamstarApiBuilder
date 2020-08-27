// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprintLabel
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
  public class ReprintLabel : PrintLabelTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_LabelHistorySummary")]
    protected SubentityRef _LabelHistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_SelectedHistoryMainline")]
    protected BaseObjectRef _SelectedHistoryMainline;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_PrinterLabelDefinition")]
    protected new RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_LabelCount")]
    protected new Primitive<int> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is ReprintLabel && object.Equals((object) this._PrintQueue, (object) ((ReprintLabel) obj)._PrintQueue) && (object.Equals((object) this._LabelHistorySummary, (object) ((ReprintLabel) obj)._LabelHistorySummary) && object.Equals((object) this._SelectedHistoryMainline, (object) ((ReprintLabel) obj)._SelectedHistoryMainline)) && (object.Equals((object) this._PrinterLabelDefinition, (object) ((ReprintLabel) obj)._PrinterLabelDefinition) && object.Equals((object) this._LabelCount, (object) ((ReprintLabel) obj)._LabelCount) && (object.Equals((object) this._HistoryId, (object) ((ReprintLabel) obj)._HistoryId) && object.Equals((object) this._Factory, (object) ((ReprintLabel) obj)._Factory))) && base.Equals(obj);
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

    public SubentityRef LabelHistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelHistorySummary), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (LabelHistorySummary));
      }
    }

    public BaseObjectRef SelectedHistoryMainline
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryMainline), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (SelectedHistoryMainline));
      }
    }

    public new RevisionedObjectRef PrinterLabelDefinition
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

    public new Primitive<int> LabelCount
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

    public new BaseObjectRef HistoryId
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
