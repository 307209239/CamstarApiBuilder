// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintPELabels
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
  public class PrintPELabels : PrintLabelsTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Services")]
    protected PrintPELabel[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_ServiceDetails")]
    protected PrintPELabelDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_PETxn")]
    protected Primitive<int> _PETxn;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is PrintPELabels && object.Equals((object) this._PrintQueue, (object) ((PrintPELabels) obj)._PrintQueue) && (this.CompareArrays((Array) this._Services, (Array) ((PrintPELabels) obj)._Services) && this.CompareArrays((Array) this._ServiceDetails, (Array) ((PrintPELabels) obj)._ServiceDetails)) && (object.Equals((object) this._PETxn, (object) ((PrintPELabels) obj)._PETxn) && object.Equals((object) this._Factory, (object) ((PrintPELabels) obj)._Factory)) && base.Equals(obj);
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

    public PrintPELabel[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (PrintPELabel[]) this.PropertyGet(nameof (Services));
      }
    }

    public PrintPELabelDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (PrintPELabelDetails[]) this.PropertyGet(nameof (ServiceDetails));
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
