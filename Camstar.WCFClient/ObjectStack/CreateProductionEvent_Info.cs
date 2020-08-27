// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateProductionEvent_Info
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
  public class CreateProductionEvent_Info : CreateEvent_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_HoldReason")]
    protected Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_ServiceDetail")]
    protected new EventDetail_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_Classification")]
    protected new Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_SubClassification")]
    protected new Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_PrintPELabels")]
    protected PrintPELabels_Info _PrintPELabels;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_Organization")]
    protected new Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_IsManuallyPrintLabels")]
    protected Info _IsManuallyPrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_HoldContainers")]
    protected Info _HoldContainers;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_ContainerName")]
    protected Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Info_Containers")]
    protected Info _Containers;

    public Info HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldReason));
      }
    }

    public new EventDetail_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (EventDetail_Info) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
      }
    }

    public new Info SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassification));
      }
    }

    public PrintPELabels_Info PrintPELabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintPELabels), (object) value);
      }
      get
      {
        return (PrintPELabels_Info) this.PropertyGet(nameof (PrintPELabels));
      }
    }

    public new Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public Info IsManuallyPrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManuallyPrintLabels), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsManuallyPrintLabels));
      }
    }

    public Info HoldContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldContainers));
      }
    }

    public Info ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerName));
      }
    }

    public Info Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Containers));
      }
    }
  }
}
