// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateProductionEvent_Environment
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
  public class CreateProductionEvent_Environment : CreateEvent_Environment
  {
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, false, "NamedObjectRef", 1048800, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_HoldReason")]
    protected Environment _HoldReason;
    [Metadata("The EventDetail service detail is used for creating and updating events", "EventDetail", false, false, false, "EventDetail", 1051158, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_ServiceDetail")]
    protected new EventDetail_Environment _ServiceDetail;
    [Metadata("Used to classify QualityObjects", "Classification", false, true, false, "NamedObjectRef", 1051055, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_Classification")]
    protected new Environment _Classification;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, true, false, "NamedObjectRef", 1051146, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_SubClassification")]
    protected new Environment _SubClassification;
    [Metadata("The service is used to print multiple Production Events and Containers", "PrintPELabels", false, false, false, "PrintPELabels", 16778749, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_PrintPELabels")]
    protected PrintPELabels_Environment _PrintPELabels;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_Organization")]
    protected new Environment _Organization;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778748, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_IsManuallyPrintLabels")]
    protected Environment _IsManuallyPrintLabels;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052908, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_HoldContainers")]
    protected Environment _HoldContainers;
    [Metadata("Generic String", "", false, false, false, "String", 1052919, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_ContainerName")]
    protected Environment _ContainerName;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1052907, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Environment_Containers")]
    protected Environment _Containers;

    public Environment HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HoldReason));
      }
    }

    public new EventDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (EventDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
      }
    }

    public new Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public PrintPELabels_Environment PrintPELabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintPELabels), (object) value);
      }
      get
      {
        return (PrintPELabels_Environment) this.PropertyGet(nameof (PrintPELabels));
      }
    }

    public new Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public Environment IsManuallyPrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManuallyPrintLabels), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsManuallyPrintLabels));
      }
    }

    public Environment HoldContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HoldContainers));
      }
    }

    public Environment ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerName));
      }
    }

    public Environment Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Containers));
      }
    }
  }
}
