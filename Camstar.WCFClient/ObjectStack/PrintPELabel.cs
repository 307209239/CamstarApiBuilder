// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintPELabel
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
  public class PrintPELabel : PrintLabelTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_HistoryId")]
    protected NamedObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_ProductionEvent")]
    protected NamedObjectRef _ProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_PrinterLabelDefinition")]
    protected new RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_LabelCount")]
    protected new Primitive<int> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_PETxn")]
    protected Primitive<int> _PETxn;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is PrintPELabel && object.Equals((object) this._HistoryId, (object) ((PrintPELabel) obj)._HistoryId) && (object.Equals((object) this._ProductionEvent, (object) ((PrintPELabel) obj)._ProductionEvent) && object.Equals((object) this._PrintQueue, (object) ((PrintPELabel) obj)._PrintQueue)) && (object.Equals((object) this._PrinterLabelDefinition, (object) ((PrintPELabel) obj)._PrinterLabelDefinition) && object.Equals((object) this._Container, (object) ((PrintPELabel) obj)._Container) && (object.Equals((object) this._LabelCount, (object) ((PrintPELabel) obj)._LabelCount) && object.Equals((object) this._PETxn, (object) ((PrintPELabel) obj)._PETxn))) && object.Equals((object) this._Factory, (object) ((PrintPELabel) obj)._Factory) && base.Equals(obj);
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

    public NamedObjectRef ProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionEvent), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ProductionEvent));
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

    public Primitive<int> PETxn
    {
      [param: In] set
      {
        this.PropertySet(nameof (PETxn), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (PETxn));
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
