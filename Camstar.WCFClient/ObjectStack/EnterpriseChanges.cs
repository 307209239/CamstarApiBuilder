// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EnterpriseChanges
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
  public class EnterpriseChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_LiveConnectProxySite")]
    protected NamedObjectRef _LiveConnectProxySite;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Factories")]
    protected NamedObjectRef[] _Factories;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_ReportHeading")]
    protected Primitive<string> _ReportHeading;

    public override bool Equals(object obj)
    {
      return obj is EnterpriseChanges && object.Equals((object) this._LiveConnectProxySite, (object) ((EnterpriseChanges) obj)._LiveConnectProxySite) && (object.Equals((object) this._TrainingReqGroup, (object) ((EnterpriseChanges) obj)._TrainingReqGroup) && object.Equals((object) this._Name, (object) ((EnterpriseChanges) obj)._Name)) && (object.Equals((object) this._ObjectToChange, (object) ((EnterpriseChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._Factories, (Array) ((EnterpriseChanges) obj)._Factories) && object.Equals((object) this._ReportHeading, (object) ((EnterpriseChanges) obj)._ReportHeading)) && base.Equals(obj);
    }

    public NamedObjectRef LiveConnectProxySite
    {
      [param: In] set
      {
        this.PropertySet(nameof (LiveConnectProxySite), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LiveConnectProxySite));
      }
    }

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef[] Factories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factories), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Factories));
      }
    }

    public Primitive<string> ReportHeading
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportHeading), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReportHeading));
      }
    }
  }
}
