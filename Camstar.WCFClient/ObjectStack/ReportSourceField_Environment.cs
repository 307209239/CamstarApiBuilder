// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportSourceField_Environment
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
  public class ReportSourceField_Environment : OtherCheckBoxField_Environment
  {
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051316, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Environment_UserFacility")]
    protected Environment _UserFacility;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Environment_Literature")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051314, false, false, false, "0")]
    protected Environment _Literature;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051310, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Environment_CompanyRepresentative")]
    protected Environment _CompanyRepresentative;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051305, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Environment_HealthProfessional")]
    protected Environment _HealthProfessional;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Environment_Distributor")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051312, false, false, false, "0")]
    protected Environment _Distributor;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Environment_Foreign")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051313, false, false, false, "0")]
    protected Environment _Foreign;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051315, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Environment_Study")]
    protected Environment _Study;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051311, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Environment_Consumer")]
    protected Environment _Consumer;

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
  }
}
