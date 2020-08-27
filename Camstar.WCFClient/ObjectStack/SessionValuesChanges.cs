// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SessionValuesChanges
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
  public class SessionValuesChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_ServiceTypeId")]
    protected Primitive<int> _ServiceTypeId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_ServiceTypeName")]
    protected Primitive<string> _ServiceTypeName;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_LocationIconId")]
    protected Primitive<int> _LocationIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_WorkCenter")]
    protected NamedObjectRef _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_WorkCenterIconId")]
    protected Primitive<int> _WorkCenterIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_EnterpriseIconId")]
    protected Primitive<int> _EnterpriseIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Workstation")]
    protected NamedObjectRef _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_FactoryIconId")]
    protected Primitive<int> _FactoryIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Factory")]
    protected NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is SessionValuesChanges && object.Equals((object) this._ServiceTypeId, (object) ((SessionValuesChanges) obj)._ServiceTypeId) && (object.Equals((object) this._ObjectToChange, (object) ((SessionValuesChanges) obj)._ObjectToChange) && object.Equals((object) this._ServiceTypeName, (object) ((SessionValuesChanges) obj)._ServiceTypeName)) && (object.Equals((object) this._LocationIconId, (object) ((SessionValuesChanges) obj)._LocationIconId) && object.Equals((object) this._WorkCenter, (object) ((SessionValuesChanges) obj)._WorkCenter) && (object.Equals((object) this._WorkCenterIconId, (object) ((SessionValuesChanges) obj)._WorkCenterIconId) && object.Equals((object) this._Operation, (object) ((SessionValuesChanges) obj)._Operation))) && (object.Equals((object) this._EnterpriseIconId, (object) ((SessionValuesChanges) obj)._EnterpriseIconId) && object.Equals((object) this._IsFrozen, (object) ((SessionValuesChanges) obj)._IsFrozen) && (object.Equals((object) this._Resource, (object) ((SessionValuesChanges) obj)._Resource) && object.Equals((object) this._Workstation, (object) ((SessionValuesChanges) obj)._Workstation)) && (object.Equals((object) this._FactoryIconId, (object) ((SessionValuesChanges) obj)._FactoryIconId) && object.Equals((object) this._Factory, (object) ((SessionValuesChanges) obj)._Factory))) && base.Equals(obj);
    }

    public Primitive<int> ServiceTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ServiceTypeId));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> ServiceTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ServiceTypeName));
      }
    }

    public Primitive<int> LocationIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocationIconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LocationIconId));
      }
    }

    public NamedObjectRef WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Primitive<int> WorkCenterIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenterIconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (WorkCenterIconId));
      }
    }

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }

    public Primitive<int> EnterpriseIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnterpriseIconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (EnterpriseIconId));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public NamedObjectRef Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Workstation));
      }
    }

    public Primitive<int> FactoryIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryIconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FactoryIconId));
      }
    }

    public NamedObjectRef Factory
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
