// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SessionValuesChanges_Info
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
  public class SessionValuesChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_ServiceTypeId")]
    protected Info _ServiceTypeId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_ServiceTypeName")]
    protected Info _ServiceTypeName;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_LocationIconId")]
    protected Info _LocationIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_WorkCenter")]
    protected Info _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_WorkCenterIconId")]
    protected Info _WorkCenterIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_EnterpriseIconId")]
    protected Info _EnterpriseIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_Workstation")]
    protected Info _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_FactoryIconId")]
    protected Info _FactoryIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Info_Factory")]
    protected Info _Factory;

    public Info ServiceTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceTypeId));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info ServiceTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceTypeName));
      }
    }

    public Info LocationIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocationIconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LocationIconId));
      }
    }

    public Info WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Info WorkCenterIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenterIconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenterIconId));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public Info EnterpriseIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnterpriseIconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EnterpriseIconId));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workstation));
      }
    }

    public Info FactoryIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryIconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryIconId));
      }
    }

    public Info Factory
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
