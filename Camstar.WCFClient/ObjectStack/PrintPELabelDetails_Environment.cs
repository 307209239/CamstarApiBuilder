// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintPELabelDetails_Environment
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
  public class PrintPELabelDetails_Environment : PrintLabelDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabelDetails_Environment_ProductionEvent")]
    [Metadata("An Event identifies something suspect for which more investigation must be done.  Events may be escalated to an NCR or attached to CAPAs.", "Event", false, false, false, "NamedObjectRef", 1052906, false, false, false, null)]
    protected Environment _ProductionEvent;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabelDetails_Environment_Container")]
    protected Environment _Container;

    public Environment ProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionEvent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductionEvent));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }
  }
}
