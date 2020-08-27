// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerTxn_CheckQtyIssued_Parameters
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
  public class ContainerTxn_CheckQtyIssued_Parameters : ContainerTxn_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "AllowUnder")]
    protected string _AllowUnder;
    [DataMember(EmitDefaultValue = false, Name = "AllowOver")]
    protected string _AllowOver;
    [DataMember(EmitDefaultValue = false, Name = "QtyRequired")]
    protected string _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "QtyIssued")]
    protected string _QtyIssued;

    public string AllowUnder
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowUnder), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (AllowUnder));
      }
    }

    public string AllowOver
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOver), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (AllowOver));
      }
    }

    public string QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (QtyRequired));
      }
    }

    public string QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (QtyIssued));
      }
    }
  }
}
