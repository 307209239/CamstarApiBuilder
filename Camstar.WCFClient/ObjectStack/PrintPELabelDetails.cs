// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintPELabelDetails
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
  public class PrintPELabelDetails : PrintLabelDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabelDetails_ProductionEvent")]
    protected NamedObjectRef _ProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabelDetails_Container")]
    protected ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is PrintPELabelDetails && object.Equals((object) this._ProductionEvent, (object) ((PrintPELabelDetails) obj)._ProductionEvent) && object.Equals((object) this._Container, (object) ((PrintPELabelDetails) obj)._Container) && base.Equals(obj);
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
  }
}
