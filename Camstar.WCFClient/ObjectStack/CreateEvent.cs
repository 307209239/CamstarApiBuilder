// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateEvent
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
  public class CreateEvent : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_ServiceDetail")]
    protected EventDetail _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Organization")]
    protected new NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Submit")]
    protected Primitive<bool> _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_EventName")]
    protected Primitive<string> _EventName;

    public override bool Equals(object obj)
    {
      return obj is CreateEvent && object.Equals((object) this._ServiceDetail, (object) ((CreateEvent) obj)._ServiceDetail) && (object.Equals((object) this._QualityObject, (object) ((CreateEvent) obj)._QualityObject) && object.Equals((object) this._SubClassification, (object) ((CreateEvent) obj)._SubClassification)) && (object.Equals((object) this._Organization, (object) ((CreateEvent) obj)._Organization) && object.Equals((object) this._Classification, (object) ((CreateEvent) obj)._Classification) && (object.Equals((object) this._Submit, (object) ((CreateEvent) obj)._Submit) && object.Equals((object) this._EventName, (object) ((CreateEvent) obj)._EventName))) && base.Equals(obj);
    }

    public EventDetail ServiceDetail
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

    public new NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public NamedObjectRef SubClassification
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

    public NamedObjectRef Classification
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

    public Primitive<bool> Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Submit));
      }
    }

    public Primitive<string> EventName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EventName));
      }
    }
  }
}
