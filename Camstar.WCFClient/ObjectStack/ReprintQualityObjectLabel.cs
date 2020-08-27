// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprintQualityObjectLabel
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
  public class ReprintQualityObjectLabel : ReprintLabel
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_HistoryId")]
    protected NamedObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_LabelHistorySummary")]
    protected new SubentityRef _LabelHistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_WorkCenter")]
    protected NamedObjectRef _WorkCenter;

    public override bool Equals(object obj)
    {
      return obj is ReprintQualityObjectLabel && object.Equals((object) this._HistoryId, (object) ((ReprintQualityObjectLabel) obj)._HistoryId) && (object.Equals((object) this._QualityObject, (object) ((ReprintQualityObjectLabel) obj)._QualityObject) && object.Equals((object) this._LabelHistorySummary, (object) ((ReprintQualityObjectLabel) obj)._LabelHistorySummary)) && (object.Equals((object) this._Container, (object) ((ReprintQualityObjectLabel) obj)._Container) && object.Equals((object) this._Operation, (object) ((ReprintQualityObjectLabel) obj)._Operation) && object.Equals((object) this._WorkCenter, (object) ((ReprintQualityObjectLabel) obj)._WorkCenter)) && base.Equals(obj);
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

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
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
