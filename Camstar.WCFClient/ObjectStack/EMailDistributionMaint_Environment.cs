// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailDistributionMaint_Environment
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
  public class EMailDistributionMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("The list of people who should receive an EMailMessage.", "EMailDistribution", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("The list of people who should receive an EMailMessage.", "EMailDistributionChanges", false, false, false, "EMailDistributionChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionMaint_Environment_ObjectChanges")]
    protected EMailDistributionChanges_Environment _ObjectChanges;
    [Metadata("The list of people who should receive an EMailMessage.", "EMailDistribution", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public EMailDistributionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EMailDistributionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
