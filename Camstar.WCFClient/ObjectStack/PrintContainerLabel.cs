// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintContainerLabel
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
  public class PrintContainerLabel : PrintLabelTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_CurrentContainerStatus")]
    protected CurrentContainerStatus _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_PrinterLabelDefinition")]
    protected new RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_RecipeList")]
    protected RevisionedObjectRef _RecipeList;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_LabelCount")]
    protected new Primitive<int> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_HistoryId")]
    protected ContainerRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_NoPrinterDefinition")]
    protected Primitive<int> _NoPrinterDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_WorkCenter")]
    protected NamedObjectRef _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is PrintContainerLabel && object.Equals((object) this._PrintQueue, (object) ((PrintContainerLabel) obj)._PrintQueue) && (object.Equals((object) this._CurrentContainerStatus, (object) ((PrintContainerLabel) obj)._CurrentContainerStatus) && object.Equals((object) this._PrinterLabelDefinition, (object) ((PrintContainerLabel) obj)._PrinterLabelDefinition)) && (object.Equals((object) this._RecipeList, (object) ((PrintContainerLabel) obj)._RecipeList) && object.Equals((object) this._Carrier, (object) ((PrintContainerLabel) obj)._Carrier) && (object.Equals((object) this._LabelCount, (object) ((PrintContainerLabel) obj)._LabelCount) && object.Equals((object) this._Container, (object) ((PrintContainerLabel) obj)._Container))) && (object.Equals((object) this._HistoryId, (object) ((PrintContainerLabel) obj)._HistoryId) && object.Equals((object) this._NoPrinterDefinition, (object) ((PrintContainerLabel) obj)._NoPrinterDefinition) && (object.Equals((object) this._Factory, (object) ((PrintContainerLabel) obj)._Factory) && object.Equals((object) this._WorkCenter, (object) ((PrintContainerLabel) obj)._WorkCenter)) && (object.Equals((object) this._Operation, (object) ((PrintContainerLabel) obj)._Operation) && object.Equals((object) this._Resource, (object) ((PrintContainerLabel) obj)._Resource))) && base.Equals(obj);
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

    public CurrentContainerStatus CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus) this.PropertyGet(nameof (CurrentContainerStatus));
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

    public RevisionedObjectRef RecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (RecipeList));
      }
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
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

    public ContainerRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> NoPrinterDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (NoPrinterDefinition), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (NoPrinterDefinition));
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

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
