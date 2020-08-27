// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintQualityObjectLabel
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
  public class PrintQualityObjectLabel : PrintLabelTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintQualityObjectLabel_HistoryId")]
    protected NamedObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "PrintQualityObjectLabel_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintQualityObjectLabel_PrinterLabelDefinition")]
    protected new RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintQualityObjectLabel_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "PrintQualityObjectLabel_LabelCount")]
    protected new Primitive<int> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintQualityObjectLabel_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "PrintQualityObjectLabel_WorkCenter")]
    protected NamedObjectRef _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "PrintQualityObjectLabel_Operation")]
    protected NamedObjectRef _Operation;

    public override bool Equals(object obj)
    {
      return obj is PrintQualityObjectLabel && object.Equals((object) this._HistoryId, (object) ((PrintQualityObjectLabel) obj)._HistoryId) && (object.Equals((object) this._PrintQueue, (object) ((PrintQualityObjectLabel) obj)._PrintQueue) && object.Equals((object) this._PrinterLabelDefinition, (object) ((PrintQualityObjectLabel) obj)._PrinterLabelDefinition)) && (object.Equals((object) this._QualityObject, (object) ((PrintQualityObjectLabel) obj)._QualityObject) && object.Equals((object) this._LabelCount, (object) ((PrintQualityObjectLabel) obj)._LabelCount) && (object.Equals((object) this._Container, (object) ((PrintQualityObjectLabel) obj)._Container) && object.Equals((object) this._WorkCenter, (object) ((PrintQualityObjectLabel) obj)._WorkCenter))) && object.Equals((object) this._Operation, (object) ((PrintQualityObjectLabel) obj)._Operation) && base.Equals(obj);
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
