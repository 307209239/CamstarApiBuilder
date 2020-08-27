// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportSourceHistoryDetail_Environment
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
  public class ReportSourceHistoryDetail_Environment : OtherCheckBoxFieldHistDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Environment_Literature")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051314, false, false, false, "0")]
    protected Environment _Literature;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051316, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Environment_UserFacility")]
    protected Environment _UserFacility;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Environment_HealthProfessional")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051305, false, false, false, "0")]
    protected Environment _HealthProfessional;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051312, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Environment_Distributor")]
    protected Environment _Distributor;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Environment_Foreign")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051313, false, false, false, "0")]
    protected Environment _Foreign;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Environment_Consumer")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051311, false, false, false, "0")]
    protected Environment _Consumer;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051315, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Environment_Study")]
    protected Environment _Study;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Environment_CompanyRepresentative")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051310, false, false, false, "0")]
    protected Environment _CompanyRepresentative;

    public Environment Literature
    {
      [param: In] set
      {
        this.PropertySet(nameof (Literature), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Literature));
      }
    }

    public Environment UserFacility
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserFacility), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserFacility));
      }
    }

    public Environment HealthProfessional
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessional), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HealthProfessional));
      }
    }

    public Environment Distributor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Distributor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Distributor));
      }
    }

    public Environment Foreign
    {
      [param: In] set
      {
        this.PropertySet(nameof (Foreign), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Foreign));
      }
    }

    public Environment Consumer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Consumer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Consumer));
      }
    }

    public Environment Study
    {
      [param: In] set
      {
        this.PropertySet(nameof (Study), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Study));
      }
    }

    public Environment CompanyRepresentative
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompanyRepresentative), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompanyRepresentative));
      }
    }
  }
}
