// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportSourceHistoryDetail
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
  public class ReportSourceHistoryDetail : OtherCheckBoxFieldHistDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Literature")]
    protected Primitive<bool> _Literature;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_UserFacility")]
    protected Primitive<bool> _UserFacility;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_HealthProfessional")]
    protected Primitive<bool> _HealthProfessional;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Distributor")]
    protected Primitive<bool> _Distributor;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Foreign")]
    protected Primitive<bool> _Foreign;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Consumer")]
    protected Primitive<bool> _Consumer;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_Study")]
    protected Primitive<bool> _Study;
    [DataMember(EmitDefaultValue = false, Name = "ReportSourceHistoryDetail_CompanyRepresentative")]
    protected Primitive<bool> _CompanyRepresentative;

    public override bool Equals(object obj)
    {
      return obj is ReportSourceHistoryDetail && object.Equals((object) this._Literature, (object) ((ReportSourceHistoryDetail) obj)._Literature) && (object.Equals((object) this._UserFacility, (object) ((ReportSourceHistoryDetail) obj)._UserFacility) && object.Equals((object) this._HealthProfessional, (object) ((ReportSourceHistoryDetail) obj)._HealthProfessional)) && (object.Equals((object) this._Distributor, (object) ((ReportSourceHistoryDetail) obj)._Distributor) && object.Equals((object) this._Foreign, (object) ((ReportSourceHistoryDetail) obj)._Foreign) && (object.Equals((object) this._Consumer, (object) ((ReportSourceHistoryDetail) obj)._Consumer) && object.Equals((object) this._Study, (object) ((ReportSourceHistoryDetail) obj)._Study))) && object.Equals((object) this._CompanyRepresentative, (object) ((ReportSourceHistoryDetail) obj)._CompanyRepresentative) && base.Equals(obj);
    }

    public Primitive<bool> Literature
    {
      [param: In] set
      {
        this.PropertySet(nameof (Literature), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Literature));
      }
    }

    public Primitive<bool> UserFacility
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserFacility), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UserFacility));
      }
    }

    public Primitive<bool> HealthProfessional
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessional), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HealthProfessional));
      }
    }

    public Primitive<bool> Distributor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Distributor), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Distributor));
      }
    }

    public Primitive<bool> Foreign
    {
      [param: In] set
      {
        this.PropertySet(nameof (Foreign), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Foreign));
      }
    }

    public Primitive<bool> Consumer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Consumer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Consumer));
      }
    }

    public Primitive<bool> Study
    {
      [param: In] set
      {
        this.PropertySet(nameof (Study), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Study));
      }
    }

    public Primitive<bool> CompanyRepresentative
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompanyRepresentative), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CompanyRepresentative));
      }
    }
  }
}
