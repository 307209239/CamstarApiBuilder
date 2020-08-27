// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateProductionEvent
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
  public class CreateProductionEvent : CreateEvent
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_ServiceDetail")]
    protected new EventDetail _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Classification")]
    protected new NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_SubClassification")]
    protected new NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_PrintPELabels")]
    protected PrintPELabels _PrintPELabels;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Organization")]
    protected new NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_IsManuallyPrintLabels")]
    protected Primitive<bool> _IsManuallyPrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_HoldContainers")]
    protected Primitive<bool> _HoldContainers;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_ContainerName")]
    protected Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "CreateProductionEvent_Containers")]
    protected ContainerRef[] _Containers;

    public override bool Equals(object obj)
    {
      return obj is CreateProductionEvent && object.Equals((object) this._HoldReason, (object) ((CreateProductionEvent) obj)._HoldReason) && (object.Equals((object) this._ServiceDetail, (object) ((CreateProductionEvent) obj)._ServiceDetail) && object.Equals((object) this._Classification, (object) ((CreateProductionEvent) obj)._Classification)) && (object.Equals((object) this._SubClassification, (object) ((CreateProductionEvent) obj)._SubClassification) && object.Equals((object) this._PrintPELabels, (object) ((CreateProductionEvent) obj)._PrintPELabels) && (object.Equals((object) this._Organization, (object) ((CreateProductionEvent) obj)._Organization) && object.Equals((object) this._IsManuallyPrintLabels, (object) ((CreateProductionEvent) obj)._IsManuallyPrintLabels))) && (object.Equals((object) this._HoldContainers, (object) ((CreateProductionEvent) obj)._HoldContainers) && object.Equals((object) this._ContainerName, (object) ((CreateProductionEvent) obj)._ContainerName) && this.CompareArrays((Array) this._Containers, (Array) ((CreateProductionEvent) obj)._Containers)) && base.Equals(obj);
    }

    public NamedObjectRef HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HoldReason));
      }
    }

    public new EventDetail ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (EventDetail) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public new NamedObjectRef SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassification));
      }
    }

    public PrintPELabels PrintPELabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintPELabels), (object) value);
      }
      get
      {
        return (PrintPELabels) this.PropertyGet(nameof (PrintPELabels));
      }
    }

    public new NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public Primitive<bool> IsManuallyPrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManuallyPrintLabels), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsManuallyPrintLabels));
      }
    }

    public Primitive<bool> HoldContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldContainers), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HoldContainers));
      }
    }

    public Primitive<string> ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerName));
      }
    }

    public ContainerRef[] Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (Containers));
      }
    }
  }
}
