// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportSourceField_Info
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
  public class ReportSourceField_Info : OtherCheckBoxField_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Info_UserFacility")]
    protected Info _UserFacility;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Info_Literature")]
    protected Info _Literature;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Info_CompanyRepresentative")]
    protected Info _CompanyRepresentative;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Info_HealthProfessional")]
    protected Info _HealthProfessional;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Info_Distributor")]
    protected Info _Distributor;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Info_Foreign")]
    protected Info _Foreign;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Info_Study")]
    protected Info _Study;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceField_Info_Consumer")]
    protected Info _Consumer;

    public Info UserFacility
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserFacility), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserFacility));
      }
    }

    public Info Literature
    {
      [param: In] set
      {
        this.PropertySet(nameof (Literature), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Literature));
      }
    }

    public Info CompanyRepresentative
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompanyRepresentative), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompanyRepresentative));
      }
    }

    public Info HealthProfessional
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessional), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HealthProfessional));
      }
    }

    public Info Distributor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Distributor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Distributor));
      }
    }

    public Info Foreign
    {
      [param: In] set
      {
        this.PropertySet(nameof (Foreign), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Foreign));
      }
    }

    public Info Study
    {
      [param: In] set
      {
        this.PropertySet(nameof (Study), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Study));
      }
    }

    public Info Consumer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Consumer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Consumer));
      }
    }
  }
}
