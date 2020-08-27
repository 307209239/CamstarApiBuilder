// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintPELabels_Info
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
  public class PrintPELabels_Info : PrintLabelsTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Info_Services")]
    protected PrintPELabel_Info _Services;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Info_ServiceDetails")]
    protected PrintPELabelDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Info_PETxn")]
    protected Info _PETxn;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabels_Info_Factory")]
    protected new Info _Factory;

    public new Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public PrintPELabel_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (PrintPELabel_Info) this.PropertyGet(nameof (Services));
      }
    }

    public PrintPELabelDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (PrintPELabelDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Info PETxn
    {
      [param: In] set
      {
        this.PropertySet(nameof (PETxn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PETxn));
      }
    }

    public new Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
