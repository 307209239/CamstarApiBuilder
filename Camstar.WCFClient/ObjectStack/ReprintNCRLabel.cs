// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprintNCRLabel
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
  public class ReprintNCRLabel : ReprintLabel
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprintNCRLabel_NonconformanceReport")]
    protected NamedObjectRef _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "ReprintNCRLabel_LabelHistorySummary")]
    protected new SubentityRef _LabelHistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ReprintNCRLabel_HistoryId")]
    protected NamedObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReprintNCRLabel_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ReprintNCRLabel_WorkCenter")]
    protected NamedObjectRef _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "ReprintNCRLabel_Operation")]
    protected NamedObjectRef _Operation;

    public override bool Equals(object obj)
    {
      return obj is ReprintNCRLabel && object.Equals((object) this._NonconformanceReport, (object) ((ReprintNCRLabel) obj)._NonconformanceReport) && (object.Equals((object) this._LabelHistorySummary, (object) ((ReprintNCRLabel) obj)._LabelHistorySummary) && object.Equals((object) this._HistoryId, (object) ((ReprintNCRLabel) obj)._HistoryId)) && (object.Equals((object) this._Container, (object) ((ReprintNCRLabel) obj)._Container) && object.Equals((object) this._WorkCenter, (object) ((ReprintNCRLabel) obj)._WorkCenter) && object.Equals((object) this._Operation, (object) ((ReprintNCRLabel) obj)._Operation)) && base.Equals(obj);
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

    public new SubentityRef LabelHistorySummary
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
