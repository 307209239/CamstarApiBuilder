// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReorderProcessObject_Info
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
  public class ReorderProcessObject_Info : ProcessObjectTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObject_Info_ServiceDetails")]
    protected ReorderProcessObjectDetail_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObject_Info_ProcessObject")]
    protected new Info _ProcessObject;

    public ReorderProcessObjectDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ReorderProcessObjectDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }
  }
}
