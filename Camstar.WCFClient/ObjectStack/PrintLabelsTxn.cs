// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintLabelsTxn
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
  public class PrintLabelsTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Services")]
    protected PrintLabelTxn[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_PrinterLabelDefinition")]
    protected RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_ServiceDetails")]
    protected PrintLabelDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_LabelCount")]
    protected Primitive<int> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is PrintLabelsTxn && this.CompareArrays((Array) this._Services, (Array) ((PrintLabelsTxn) obj)._Services) && (object.Equals((object) this._PrintQueue, (object) ((PrintLabelsTxn) obj)._PrintQueue) && object.Equals((object) this._PrinterLabelDefinition, (object) ((PrintLabelsTxn) obj)._PrinterLabelDefinition)) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((PrintLabelsTxn) obj)._ServiceDetails) && object.Equals((object) this._LabelCount, (object) ((PrintLabelsTxn) obj)._LabelCount) && object.Equals((object) this._Factory, (object) ((PrintLabelsTxn) obj)._Factory)) && base.Equals(obj);
    }

    public PrintLabelTxn[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (PrintLabelTxn[]) this.PropertyGet(nameof (Services));
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

    public PrintLabelDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (PrintLabelDetails[]) this.PropertyGet(nameof (ServiceDetails));
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
