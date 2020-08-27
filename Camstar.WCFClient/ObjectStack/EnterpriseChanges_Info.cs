// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EnterpriseChanges_Info
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
  public class EnterpriseChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Info_LiveConnectProxySite")]
    protected Info _LiveConnectProxySite;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Info_Factories")]
    protected Info _Factories;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Info_ReportHeading")]
    protected Info _ReportHeading;

    public Info LiveConnectProxySite
    {
      [param: In] set
      {
        this.PropertySet(nameof (LiveConnectProxySite), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LiveConnectProxySite));
      }
    }

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
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

    public Info Factories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factories), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factories));
      }
    }

    public Info ReportHeading
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportHeading), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportHeading));
      }
    }
  }
}
