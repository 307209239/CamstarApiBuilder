// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintPELabels_Environment
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
  public class PrintPELabels_Environment : PrintLabelsTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1050609, false, false, true, null)]
    protected new Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Environment_Services")]
    [Metadata("Service to print Production Event labels.", "PrintPELabel", false, false, false, "PrintPELabel", 1052702, false, true, false, null)]
    protected PrintPELabel_Environment _Services;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Environment_ServiceDetails")]
    [Metadata("Details to print Production Event and an associated Container", "PrintPELabelDetails", false, false, false, "PrintPELabelDetails", 1049843, false, true, false, null)]
    protected PrintPELabelDetails_Environment _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Environment_PETxn")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1052912, false, false, true, null)]
    protected Environment _PETxn;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Environment_Factory")]
    protected new Environment _Factory;

    public new Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public PrintPELabel_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (PrintPELabel_Environment) this.PropertyGet(nameof (Services));
      }
    }

    public PrintPELabelDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (PrintPELabelDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment PETxn
    {
      [param: In] set
      {
        this.PropertySet(nameof (PETxn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PETxn));
      }
    }

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
