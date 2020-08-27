// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainersTxn_PopulateList_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ContainersTxn_PopulateList_Parameters : ContainersTxn_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "Resultset")]
    protected string _Resultset;
    [DataMember(EmitDefaultValue = false, Name = "Parameters")]
    protected string _Parameters;

    public string Resultset
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resultset), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Resultset));
      }
    }

    public string Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Parameters));
      }
    }
  }
}
